namespace DotNetCore.Objects;

public record Order
{
    public Order() => Ascending = true;

    public bool Ascending { get; set; }

    public string Property { get; set; }
}
