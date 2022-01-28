using Microsoft.EntityFrameworkCore;

public class TestDBContext : DbContext
{
    public TestDBContext(DbContextOptions<TestDBContext> options)
          : base(options)
    {
    }

    public DbSet<Testing> Test { get; set; }


  

    protected override void OnModelCreating(ModelBuilder builder)
    {
        
    }