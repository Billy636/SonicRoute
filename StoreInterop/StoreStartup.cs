namespace SonicRoute.StoreInterop;

public static class StoreStartup
{
    public static async Task<StoreStartupTask> GetHandleAsync()
        => new StoreStartupTask(await Windows.ApplicationModel.StartupTask.GetAsync("SonicRouteStartup"));
    public static async Task<int> ReadStateAsync()
    {
        var task = await Windows.ApplicationModel.StartupTask.GetAsync("SonicRouteStartup");
        return (int)task.State;
    }

    public static async Task SetEnabledAsync(bool enabled)
    {
        // Retain the caller's UI context: RequestEnableAsync must run on the UI thread.
        var task = await Windows.ApplicationModel.StartupTask.GetAsync("SonicRouteStartup");
        if(enabled) await task.RequestEnableAsync();
        else task.Disable();
    }

    public static async Task DisableAsync()
    {
        var task = await Windows.ApplicationModel.StartupTask.GetAsync("SonicRouteStartup");
        task.Disable();
    }
}

public sealed class StoreStartupTask
{
    private readonly Windows.ApplicationModel.StartupTask _task;
    internal StoreStartupTask(Windows.ApplicationModel.StartupTask task) => _task=task;
    public int State => (int)_task.State;
    public async Task<int> RequestEnableAsync() => (int)await _task.RequestEnableAsync();
    public void Disable() => _task.Disable();
}
