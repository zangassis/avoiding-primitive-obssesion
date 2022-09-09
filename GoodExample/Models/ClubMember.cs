namespace GoodExample.Models;

public class ClubMember
{
    public ClubMember(bool isClubMember)
    {
        IsClubMember = isClubMember;
    }

    public bool IsClubMember { get; set; }

    public decimal CalculateAmount(decimal productValue) =>
        IsClubMember ? productValue - 10 : productValue;
}