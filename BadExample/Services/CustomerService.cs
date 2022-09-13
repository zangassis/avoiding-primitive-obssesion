using BadExample.Models;

namespace BadExample.Services;
public class CustomerService
{
    public static void ServiceProcess(Customer customer, decimal productValue)
    {
        decimal amount = 0;
        decimal discountValue = 10;

        if (customer.ClubMember == true)
        {
            amount = productValue - discountValue;
        }
        else
        {
            amount = productValue;
        }

        if (customer.PhoneNumber.Any(p => char.IsLetter(p)))
        {
            throw new Exception("Phone numbers must contain numbers only");
        }

        string message = @$"Name: {customer.Name} - Email: {customer.Email} - Amount: {amount}";
        Console.WriteLine(message);
    }
}