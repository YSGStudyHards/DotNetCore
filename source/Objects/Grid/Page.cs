namespace DotNetCore.Objects;

public record Page
{
    public Page() => Index = 1;

    public int Index { get; set; }

    public int Size { get; set; }
}
