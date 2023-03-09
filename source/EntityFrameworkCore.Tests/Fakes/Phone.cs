using DotNetCore.Domain;

namespace DotNetCore.EntityFrameworkCore.Tests;

public class Phone : Entity
{
    public string Number { get; set; }

    public long CustomerId { get; set; }

    public Customer Customer { get; set; }
}
