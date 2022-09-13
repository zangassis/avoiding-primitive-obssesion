namespace GoodExample.Models;
public class Customer
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public PhoneNumber PhoneNumber { get; set; }
    public ClubMember ClubMember { get; set; }

    public Customer(string? name, string? email, PhoneNumber phoneNumber, ClubMember clubMember)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        ClubMember = clubMember;
    }
}