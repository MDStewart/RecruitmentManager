using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RecruitmentManager.Models;

/// <summary>
/// Job postings; JSON array
/// </summary>
public partial class Job
{
    public int Id { get; set; }

    [Required]
    public string? Position { get; set; }

    public decimal StartingSalary { get; set; }

    [Required]
    public string? Location { get; set; }

    [Required]
    public DateOnly EndDate { get; set; }

    public string? MinimumQualifications { get; set; }

    public string? SpecialRequirements { get; set; }

    public string? PrimaryFunctions { get; set; }

    [JsonIgnore]
    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
}