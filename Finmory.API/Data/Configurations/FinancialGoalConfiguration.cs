using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Finmory.API.Models;

public class FinancialGoalConfiguration : IEntityTypeConfiguration<FinancialGoal>
{
    public void Configure(EntityTypeBuilder<FinancialGoal> builder)
    {
        builder.HasOne(g => g.User)
            .WithMany(u => u.FinancialGoals)
            .HasForeignKey(g => g.UserId);
    }
}