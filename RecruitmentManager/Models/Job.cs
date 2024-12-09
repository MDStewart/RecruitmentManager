using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RecruitmentManager.Models;

/// <summary>
/// Job postings; JSON array
/// </summary>
public partial class Job
{
    [Key]
    public int PIN { get; set; }

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

    public string Office {  get; set; }

    public string Title { get; set; }

    public string Supervisor { get; set; }

    public string Status { get; set; }

    public bool FirstTimePosted { get; set; }

    public DateOnly InternalPostingStartDate { get; set; }

    public DateOnly InternalClosingDate { get; set; }

}