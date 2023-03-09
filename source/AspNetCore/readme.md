# DotNetCore.AspNetCore

## Attributes

### EnumAuthorizeAttribute

```cs
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public sealed class EnumAuthorizeAttribute : AuthorizeAttribute
{
    public EnumAuthorizeAttribute(params object[] roles) { }
}
```

## Extensions

### ActionContextExtensions

```cs
public static class ActionContextExtensions
{
    public static Task Ok(this ActionContext context, object value) { }

    public static Task UnprocessableEntity(this ActionContext context, string error) { }
}
```

### ApplicationBuilderExtensions

```cs
public static class ApplicationBuilderExtensions
{
    public static void UseCorsAllowAny(this IApplicationBuilder application) { }

    public static void UseException(this IApplicationBuilder application) { }

    public static void UseHttps(this IApplicationBuilder application) { }

    public static void UseLocalization(this IApplicationBuilder application, params string[] cultures) { }

    public static void ConfigureFormOptions(this IServiceCollection services) { }
}
```

### BinaryFileExtensions

```cs
public static class BinaryFileExtensions
{
    public static IActionResult FileResult(this Task<BinaryFile> binaryFile) { }
}
```

### HttpRequestExtensions

```cs
public static class HttpRequestExtensions
{
    public static IList<BinaryFile> Files(this HttpRequest request) { }
}
```

### ResultExtensions

```cs
public static class ResultExtensions
{
    public static IActionResult ApiResult<T>(this Result<T> result) { }

    public static IActionResult ApiResult<T>(this Task<Result<T>> result) { }

    public static IActionResult ApiResult(this Result result) { }

    public static IActionResult ApiResult(this Task<Result> result) { }

    public static IActionResult ApiResult<T>(this T result) { }

    public static IActionResult ApiResult<T>(this Task<T> result) { }
}
```

### ServiceCollectionExtensions

```cs
public static class ServiceCollectionExtensions
{
    public static IMvcBuilder AddAuthorizationPolicy(this IMvcBuilder builder) { }

    public static IServiceCollection AddCorsAllowAny(this IServiceCollection services) { }

    public static IServiceCollection AddFileExtensionContentTypeProvider(this IServiceCollection services) { }

    public static IMvcBuilder AddJsonOptions(this IMvcBuilder builder) { }

    public static void AddSwaggerDefault(this IServiceCollection services) { }

    public static IServiceCollection ConfigureFormOptionsMaxLengthLimit(this IServiceCollection services) { }
}
```

## Action Results

### ApiResult

```cs
public sealed class ApiResult : IActionResult
{
    public ApiResult(Result result) { }

    public Task ExecuteResultAsync(ActionContext context) { }
}
```

### ApiResult<T>

```cs
public sealed class ApiResult<T> : IActionResult
{
    public ApiResult(Result<T> result) { }

    public Task ExecuteResultAsync(ActionContext context) { }
}
```
