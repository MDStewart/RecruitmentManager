namespace RecruitmentManager.Data;

public static class DbInitializer
{
    public static void Initialize(HRMSContext context)
    {
        if (context.Jobs.Any() && context.Candidates.Any() && context.Applications.Any())
        {
            return; // DB has been seeded
        }


    }
}
