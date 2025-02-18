using System.ComponentModel.DataAnnotations;

namespace RecruitmentManager.Models;

/// <summary>
/// Candidate applying to a job posting
/// </summary>
public class Applicant
{
    [Key]
    public int Id { get; set; }
    public string? MiddleName { get; set; }

    public string Address { get; set; }

    public string? Address2 { get; set; }

    public string City { get; set; }

    public string State {  get; set; }

    public string ZipCode { get; set; }

    public string? AlternatePhone { get; set; }

    public DateOnly GraduationDate { get; set; }

    public DateTime? LastModified { get; set; }

    public DateTime DateAdded { get; set; }

    public virtual Job JobPosting {  get; set; }

    public virtual Candidate Candidate { get; set; }
}
