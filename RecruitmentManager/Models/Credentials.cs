using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RecruitmentManager.Models;

public class Credentials : IdentityUser
{
    [Key]
    new public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string? PreferredName { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public string Password { get; set; }

    public int AccessFailedCount { get; set; }

    public string ConcurrencyStamp { get; set; }

    public bool EmailConfirmed { get; set; }

    public bool LockoutEnabled { get; set; }

    public DateOnly LockoutEnd { get; set; }

    public string NormalizedEmail { get; set; }

    public string NormalizedUserName { get; set; }

    public string SecurityStamp { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public string UserName { get; set; }
}
