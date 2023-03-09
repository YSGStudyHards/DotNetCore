using DotNetCore.Results;

namespace DotNetCore.Mediator.Tests;

public sealed class InsertCategoryCommandHandler : IHandler<InsertCategoryCommand, long>
{
    public Task<Result<long>> HandleAsync(InsertCategoryCommand request) => Task.FromResult(Result<long>.Success(1L));
}
