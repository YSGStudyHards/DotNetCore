using Microsoft.Extensions.DependencyInjection;

namespace DotNetCore.Results;

public static class Extensions
{
    public static void AddResultService(this IServiceCollection services) => services.AddSingleton<IResultService, ResultService>();
}
