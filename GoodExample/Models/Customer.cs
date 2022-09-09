namespace GoodExample.Models;
public class Customer
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public ClubMember ClubMember { get; set; }

    public Customer(string? name, string? email, string? phone, ClubMember clubMember)
    {
        Name = name;
        Email = email;
        Phone = phone;
        ClubMember = clubMember;
    }
}