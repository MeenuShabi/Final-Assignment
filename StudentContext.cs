using System.Data.Entity;

public class StudentContext : DbContext
{
    public StudentContext() : base("StudentDbConnection")
    {
    }

    public DbSet<StudentMS> Students { get; set; }
}
