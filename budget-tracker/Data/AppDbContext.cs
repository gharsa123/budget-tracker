using Microsoft.EntityFrameworkCore;
using BudgetTracker.Models;

namespace BudgetTracker.Data
{
    public class AppDbContext : DbContext
{
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
