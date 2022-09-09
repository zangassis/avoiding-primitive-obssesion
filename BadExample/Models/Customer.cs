namespace BadExample.Models;

public class Customer
{
    public Customer(string? name, string? email, string? phone, bool clubMember)
    {
        Name = name;
        Email = email;
        Phone = phone;
        ClubMember = clubMember;
    }

    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public bool ClubMember { get; set; }
}
