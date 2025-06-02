using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Finmory.API.Models;

public class GoalContributionConfiguration : IEntityTypeConfiguration<GoalContribution>
{
    public void Configure(EntityTypeBuilder<GoalContribution> builder)
    {
        builder.HasOne(gc => gc.FinancialGoal)
            .WithMany(g => g.Contributions)
            .HasForeignKey(gc => gc.FinancialGoalId);

        builder.HasOne(gc => gc.User)
            .WithMany(u => u.GoalContributions)
            .HasForeignKey(gc => gc.UserId);
    }
}
