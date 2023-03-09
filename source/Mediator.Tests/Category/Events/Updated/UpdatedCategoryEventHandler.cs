using DotNetCore.Results;

namespace DotNetCore.Mediator.Tests;

public sealed class UpdatedCategoryEventHandler : IHandler<UpdatedCategoryEvent>
{
    public Task<Result> HandleAsync(UpdatedCategoryEvent request) => Task.FromResult(Result.Success());
}
