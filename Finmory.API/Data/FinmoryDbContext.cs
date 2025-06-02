using Microsoft.EntityFrameworkCore;
using Finmory.API.Models;
using Finmory.API.Data.Configurations; // Asegurate que este namespace coincida con donde pusiste las configuraciones

namespace Finmory.API.Data
{
    public class FinmoryDbContext : DbContext
    {
        public FinmoryDbContext(DbContextOptions<FinmoryDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<FinancialAccount> FinancialAccounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<FinancialGoal> FinancialGoals { get; set; }
        public DbSet<GoalContribution> GoalContributions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FinancialAccountConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new SubcategoryConfiguration());
            modelBuilder.ApplyConfiguration(new BudgetConfiguration());
            modelBuilder.ApplyConfiguration(new FinancialGoalConfiguration());
            modelBuilder.ApplyConfiguration(new GoalContributionConfiguration());
        }
    }
}
