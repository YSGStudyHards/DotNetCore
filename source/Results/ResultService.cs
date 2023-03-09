using Microsoft.Extensions.Localization;

namespace DotNetCore.Results;

public sealed class ResultService : IResultService
{
    private readonly IStringLocalizer _stringLocalizer;

    public ResultService(IStringLocalizer stringLocalizer) => _stringLocalizer = stringLocalizer;

    public Result Error() => Result.Error();

    public Result Error(string message) => Result.Error(_stringLocalizer[message]);

    public Result<T> Error<T>(string message) => Result<T>.Error(_stringLocalizer[message]);

    public Result Success() => Result.Success();

    public Result<T> Success<T>(T value) => Result<T>.Success(value);
}
