using Microsoft.EntityFrameworkCore;
using Authors.Models;
using Authors.Persistence.Configurations;

namespace Authors.Persistence;

public class AuthorDbContext: DbContext
{
    public DbSet<Author> Authors { get; set; }

    public AuthorDbContext(DbContextOptions<AuthorDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new AuthorConfiguration());
    }
}
