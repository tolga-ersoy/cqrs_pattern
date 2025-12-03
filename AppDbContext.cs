using CQRS_Pattern_Project.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Pattern_Project.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();
}