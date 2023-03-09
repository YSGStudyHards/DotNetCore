# DotNetCore.Results

## Result

```cs
public record Result(ResultType Type, string Message)
{
    public bool HasMessage;

    public bool IsError;

    public bool IsSuccess;

    public static Result Error() { }

    public static Result Error(string message) { }

    public static Result Success() { }

    public Result<T> Convert<T>() { }
}
```

## Result<T>

```cs
public sealed record Result<T>(ResultType Type, string Message, T Value) : Result(Type, Message)
{
    public bool HasValue;

    public static new Result<T> Error(string message) { };

    public static Result<T> Success(T value) { };

    public static new Result<T> Success() { };
}
```

## ResultType

```cs
public enum ResultType
{
    None = 0,
    Success = 1,
    Error = 2
}
```

## IResultService

```cs
public interface IResultService
{
    Result Error();

    Result Error(string message);

    Result<T> Error<T>(string message);

    Result Success();

    Result<T> Success<T>(T value);
}
```

## ResultService

```cs
public sealed class ResultService : IResultService
{
    public ResultService(IStringLocalizer stringLocalizer) { }

    public Result Error() { }

    public Result Error(string message) { }

    public Result<T> Error<T>(string message) { }

    public Result Success() { }

    public Result<T> Success<T>(T value) { }
}
```

## Extensions

```cs
public static class Extensions
{
    public static void AddResultService(this IServiceCollection services) { }
}
```
