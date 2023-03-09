# DotNetCore.Services

## CsvService

### ICsvService

```cs
public interface ICsvService
{
    Task<IEnumerable<T>> ReadAsync<T>(string path, string separator) where T : new();

    Task WriteAsync<T>(string path, string separator, IEnumerable<T> items);
}
```

### CsvService

```cs
public class CsvService : ICsvService
{
    public async Task<IEnumerable<T>> ReadAsync<T>(string path, string separator) where T : new() { }

    public Task WriteAsync<T>(string path, string separator, IEnumerable<T> items) { }
}
```

### Example

```cs
public class Program
{
    public static void Main()
    {
        ICsvService csvService = new CsvService();

        var customers = csvService.ReadAsync<Customer>("Customers.csv", ";").Result;

        csvService.WriteAsync("Customers.csv", ";", customers).Wait();
    }
}
```

## FileCache

```cs
public interface IFileCache
{
    void Clear(string file);

    T Set<T>(string file, TimeSpan expiration, T value);

    bool TryGetValue<T>(string file, out T value);
}
```

```cs
public sealed class FileCache : IFileCache
{
    public void Clear(string file) { }

    public T Set<T>(string file, TimeSpan expiration, T value) { }

    public bool TryGetValue<T>(string file, out T value) { }
}
```

## JsonStringLocalizer

```cs
public class JsonStringLocalizer : IStringLocalizer
{
   public JsonStringLocalizer(string path) { }
}
```

## Extensions

```cs
public static class Extensions
{
    public static void AddCsvService(this IServiceCollection services) { }

    public static void AddFileCache(this IServiceCollection services) { }

    public static void AddJsonStringLocalizer(this IServiceCollection services) { }
}
```
