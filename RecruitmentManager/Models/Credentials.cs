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

    public string? Password { get; set; }

}