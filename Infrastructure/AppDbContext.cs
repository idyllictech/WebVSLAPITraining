using Microsoft.EntityFrameworkCore;
using WebVslApiTraining.Domain;

namespace WebVslApiTraining.Infrastructure
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
    {
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
    }
}
