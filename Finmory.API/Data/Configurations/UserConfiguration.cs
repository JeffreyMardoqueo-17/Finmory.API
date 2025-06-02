using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Finmory.API.Models;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasIndex(u => u.Email).IsUnique();

        builder.HasMany(u => u.FinancialAccounts)
            .WithOne(f => f.User)
            .HasForeignKey(f => f.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.Transactions)
            .WithOne(t => t.User)
            .HasForeignKey(t => t.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.Budgets)
            .WithOne(b => b.User)
            .HasForeignKey(b => b.UserId);

        builder.HasMany(u => u.FinancialGoals)
            .WithOne(g => g.User)
            .HasForeignKey(g => g.UserId);

        builder.HasMany(u => u.GoalContributions)
            .WithOne(gc => gc.User)
            .HasForeignKey(gc => gc.UserId);
    }
}

