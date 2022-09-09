using GoodExample.Models;

namespace GoodExample.Services;
public class CustomerService
{
    public static void ServiceProcess(Customer customer, decimal productValue)
    {
        decimal amount = customer.ClubMember.CalculateAmount(productValue);

        string message = @$"Name: {customer.Name} - Email: {customer.Email} - Amount: {amount}";
        Console.WriteLine(message);
    }
}