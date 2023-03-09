using DotNetCore.Results;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.AspNetCore;

public sealed class ApiResult : IActionResult
{
    private readonly Result _result;

    public ApiResult(Result result) => _result = result;

    public Task ExecuteResultAsync(ActionContext context) => _result.IsError ? context.UnprocessableEntity(_result.Message) : context.Ok(_result.Message);
}

public sealed class ApiResult<T> : IActionResult
{
    private readonly Result<T> _result;

    public ApiResult(Result<T> result) => _result = result;

    public Task ExecuteResultAsync(ActionContext context) => _result.IsError ? context.UnprocessableEntity(_result.Message) : context.Ok(_result.Value);
}
