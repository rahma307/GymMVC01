using GymSessionDemo1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSessionDemo1.Configurations
{
    public class PlanConfigurations : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");


            builder.ToTable(t =>
            {
                t.HasCheckConstraint("Plan_DurationCheck", "DurationDays between 1 AND 365");

            });
        }
    }
}
