using DotNetCore.Results;

namespace DotNetCore.Mediator.Tests;

public sealed class CategoryByIdQueryHandler : IHandler<CategoryByIdQuery, Category>
{
    public Task<Result<Category>> HandleAsync(CategoryByIdQuery request)
    {
        var category = new Category(request.Id, nameof(Category));

        return Task.FromResult(Result<Category>.Success(category));
    }
}
