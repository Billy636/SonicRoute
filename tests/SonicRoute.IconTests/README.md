# Process icon regression checks

Run on Windows with the .NET SDK, without administrator elevation:

```powershell
dotnet run --project tests/SonicRoute.IconTests -f net8.0-windows
dotnet run --project tests/SonicRoute.IconTests -f net48
```

The checks compile the production `AppIconService.cs` directly for both runtimes,
without a test framework or changes to the application configuration. They cover
the current process, cache reuse, invalid/missing PIDs and a process that has exited.

To reproduce issue #5, keep an elevated application (such as MAA) or Endfield running,
then pass its PID to either command while the test runner stays unelevated:

```powershell
$appPids = @(Get-Process -Name MAA,Endfield | ForEach-Object { $_.Id })
dotnet run --project tests/SonicRoute.IconTests -f net8.0-windows -- $appPids
dotnet run --project tests/SonicRoute.IconTests -f net48 -- $appPids
```

Every supplied PID must return a frozen image. Before the fix, the two live-process
checks failed with the affected applications; after the fix, both passed. Processes
that deny even limited-information queries may still have no icon.
