namespace GoodExample.Models;

public class PhoneNumber
{
    public PhoneNumber(string phoneNumber)
    {
        Value = phoneNumber.Any(p => char.IsLetter(p)) ? throw new Exception("Phone numbers must contain numbers only") : phoneNumber;
    }

    public string Value { get; set; }
}