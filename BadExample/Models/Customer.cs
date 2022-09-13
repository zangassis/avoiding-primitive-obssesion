namespace BadExample.Models;

public class Customer
{
    public Customer(string? name, string? email, string? phoneNumber, bool clubMember)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        ClubMember = clubMember;
    }

    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public bool ClubMember { get; set; }
}
