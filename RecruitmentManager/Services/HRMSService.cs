using RecruitmentManager.Models;
using RecruitmentManager.Data;
using Microsoft.EntityFrameworkCore;

namespace RecruitmentManager.Services;

public class HRMSService
{
    private readonly HRMSContext _context;

    public HRMSService(HRMSContext context)
    {
        _context = context;
    }

    public IEnumerable <Job> GetJobs()
    {
        return _context.Jobs
            .AsNoTracking()
            .ToList();
    }

    public IEnumerable<Job> GetCurrentJobs()
    {
        return _context.Jobs
            .Where(job => job.EndDate.CompareTo(DateTime.Now) >= 0)
            .AsEnumerable();
    }

    public Job? GetByJobId(int jobId)
    {
        return _context.Jobs
            .AsNoTracking()
            .SingleOrDefault(job => job.PIN == jobId);
    }
    
    public Job Create(Job newJob)
    {
        _context.Jobs.Add(newJob);
        _context.SaveChanges();

        return newJob;
    }

    public Candidate? GetByCandidateId(int candidateId)
    {
        return _context.Candidates
            .AsNoTracking()
            .SingleOrDefault (candidate => candidate.Id == candidateId);
    }

    public Candidate Create(Candidate newCandidate)
    {
        _context.Candidates.Add(newCandidate);
        _context.SaveChanges();

        return newCandidate;
    }

    public void ApplyToJob(int jobId, int applicantId)
    {
        var jobToApply = _context.Jobs.Find(jobId);
        var candidate = _context.Candidates.Find(applicantId);
        if (jobToApply is null || candidate is null)
        {
            throw new InvalidOperationException("Job ID or Candidate does not exist");
        }
         
        _context.SaveChanges();
    }
}
