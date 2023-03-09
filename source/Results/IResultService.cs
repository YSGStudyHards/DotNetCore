namespace DotNetCore.Results;

public interface IResultService
{
    Result Error();

    Result Error(string message);

    Result<T> Error<T>(string message);

    Result Success();

    Result<T> Success<T>(T value);
}
