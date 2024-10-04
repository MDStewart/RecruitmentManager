using Microsoft.EntityFrameworkCore;
using RecruitmentManager.Models;

namespace RecruitmentManager.Data;

public class HRMSContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public HRMSContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(Configuration.GetConnectionString("DevelopmentConnection"));
    }

    public DbSet<Job> Jobs { get; set; }
    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<Application> Applications { get; set; }

}
