# DotNetCore.Validation

## Extensions

```cs
public static class Extensions
{
    public static void AddValidationService(this IServiceCollection services) { }

    public static Result Validation<T>(this IValidator<T> validator, T instance) { }
}
```

## ValidationService

```cs
public interface IValidationService
{
    bool IsDate(string value);

    bool IsEmail(string value);

    bool IsInteger(string value);

    bool IsLogin(string value);

    bool IsNumber(string value);

    bool IsPassword(string value);

    bool IsTime(string value);

    bool IsUrl(string value);
}
```

```cs
public sealed class ValidationService : IValidationService
{
    public bool IsDate(string value) { }

    public bool IsEmail(string value) { }

    public bool IsInteger(string value) { }

    public bool IsLogin(string value) { }

    public bool IsNumber(string value) { }

    public bool IsPassword(string value) { }

    public bool IsTime(string value) { }

    public bool IsUrl(string value) { }
}
```
