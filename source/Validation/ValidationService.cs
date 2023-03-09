using System.Net.Mail;
using System.Numerics;
using System.Text.RegularExpressions;

namespace DotNetCore.Validation;

public sealed class ValidationService : IValidationService
{
    public bool IsDate(string value) => DateOnly.TryParseExact(value, "dd/MM/yyyy", out _);

    public bool IsEmail(string value) => MailAddress.TryCreate(value, out _);

    public bool IsInteger(string value) => BigInteger.TryParse(value, out _);

    public bool IsLogin(string value) => new Regex(@"^[a-z0-9._-]{10,50}$").IsMatch(value);

    public bool IsNumber(string value) => Decimal.TryParse(value, out _);

    public bool IsPassword(string value) => new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^a-zA-Z\d\s]).{10,50}$").IsMatch(value);

    public bool IsTime(string value) => TimeOnly.TryParseExact(value, "HH:mm:ss", out _);

    public bool IsUrl(string value) => Uri.TryCreate(value, UriKind.RelativeOrAbsolute, out _);
}
