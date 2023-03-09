# DotNetCore.Logging

## Extensions

```cs
public static class Extensions
{
    public static IHostBuilder UseSerilog(this IHostBuilder builder) { }

    public static void Log(this ILogger logger, HttpResponseMessage response) { }
}
```
