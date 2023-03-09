using DotNetCore.Results;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.AspNetCore;

public static class ResultExtensions
{
    public static IActionResult ApiResult<T>(this Result<T> result) => new ApiResult<T>(result);

    public static IActionResult ApiResult<T>(this Task<Result<T>> result) => new ApiResult<T>(result.Result);

    public static IActionResult ApiResult(this Result result) => new ApiResult(result);

    public static IActionResult ApiResult(this Task<Result> result) => new ApiResult(result.Result);

    public static IActionResult ApiResult<T>(this T result) => ApiResult(Result<T>.Success(result));

    public static IActionResult ApiResult<T>(this Task<T> result) => ApiResult(result.Result);
}
