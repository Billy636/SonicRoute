using System;
using System.Threading.Tasks;

namespace SonicRoute
{
    internal enum AutoStartFailure { None, OperationFailed, DisabledByUser, RestrictedByPolicy }
    internal enum StoreStartupState { Disabled = 0, DisabledByUser = 1, Enabled = 2, DisabledByPolicy = 3, EnabledByPolicy = 4 }
    internal sealed class AutoStartResult
    {
        internal bool Enabled { get; }
        internal AutoStartFailure Failure { get; }
        internal AutoStartResult(bool enabled, AutoStartFailure failure) { Enabled=enabled;Failure=failure; }
    }
    internal interface IStartupTaskHandle
    {
        int State { get; }
        Task<int> RequestEnableAsync();
        void Disable();
    }
    internal sealed class DelegateStartupTaskHandle : IStartupTaskHandle
    {
        private readonly Func<int> _state;
        private readonly Func<Task<int>> _enable;
        private readonly Action _disable;
        internal DelegateStartupTaskHandle(Func<int> state,Func<Task<int>> enable,Action disable)
        { _state=state;_enable=enable;_disable=disable; }
        public int State => _state();
        public Task<int> RequestEnableAsync() => _enable();
        public void Disable() => _disable();
    }
    internal static class AutoStartSettings
    {
        internal static bool IsEnabled(int state) => state == (int)StoreStartupState.Enabled || state == (int)StoreStartupState.EnabledByPolicy;
        internal static bool IsKnownState(int state) => state >= (int)StoreStartupState.Disabled && state <= (int)StoreStartupState.EnabledByPolicy;
        internal static async Task<AutoStartResult> ApplyStoreAsync(bool requested,bool previous,Func<Task<IStartupTaskHandle>> acquire)
        {
            IStartupTaskHandle? task=null;
            bool actual=previous;
            try
            {
                task=await acquire();
                int state = task.State;
                if (!IsKnownState(state)) return new AutoStartResult(actual, AutoStartFailure.OperationFailed);
                actual=IsEnabled(state);
                // Preserve system/user decisions and avoid unnecessary mutating calls.
                if (actual == requested) return new AutoStartResult(actual, AutoStartFailure.None);
                if (state == (int)StoreStartupState.DisabledByUser)
                    return new AutoStartResult(actual, AutoStartFailure.DisabledByUser);
                if (state == (int)StoreStartupState.DisabledByPolicy || state == (int)StoreStartupState.EnabledByPolicy)
                    return new AutoStartResult(actual, AutoStartFailure.RestrictedByPolicy);
                if(requested) state=await task.RequestEnableAsync();
                else {task.Disable();state=task.State;}
                if (!IsKnownState(state)) return new AutoStartResult(actual, AutoStartFailure.OperationFailed);
                actual=IsEnabled(state);
                if(actual==requested) return new AutoStartResult(actual,AutoStartFailure.None);
                return new AutoStartResult(actual,state == (int)StoreStartupState.DisabledByUser ? AutoStartFailure.DisabledByUser:
                    state == (int)StoreStartupState.DisabledByPolicy || state == (int)StoreStartupState.EnabledByPolicy
                        ? AutoStartFailure.RestrictedByPolicy : AutoStartFailure.OperationFailed);
            }
            catch
            {
                // A request can throw after the OS changed its state. Read it again when possible.
                if(task!=null){try{int state=task.State;if(IsKnownState(state))actual=IsEnabled(state);}catch{}}
                return new AutoStartResult(actual,AutoStartFailure.OperationFailed);
            }
        }
        internal static Task<AutoStartResult> ApplyPortableAsync(bool requested,bool previous,Func<bool> read,Action<bool> write)
        {
            bool actual=previous;
            try
            {
                actual=read();write(requested);actual=read();
                return Task.FromResult(new AutoStartResult(actual,actual==requested?AutoStartFailure.None:AutoStartFailure.OperationFailed));
            }
            catch
            {
                try{actual=read();}catch{}
                return Task.FromResult(new AutoStartResult(actual,AutoStartFailure.OperationFailed));
            }
        }
    }
}
