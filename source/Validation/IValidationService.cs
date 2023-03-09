namespace DotNetCore.Validation;

public interface IValidationService
{
    bool IsDate(string value);

    bool IsEmail(string value);

    bool IsInteger(string value);

    bool IsLogin(string value);

    bool IsNumber(string value);

    bool IsPassword(string value);

    bool IsTime(string value);

    bool IsUrl(string value);
}
