using DotNetCore.Results;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetCore.Validation;

public static class Extensions
{
    public static void AddValidationService(this IServiceCollection services) => services.AddSingleton<IValidationService, ValidationService>();

    public static Result Validation<T>(this IValidator<T> validator, T instance)
    {
        if (instance is null) return Result.Error(default);

        var result = validator.Validate(instance);

        return result.IsValid ? Result.Success() : Result.Error(result.ToString());
    }
}
