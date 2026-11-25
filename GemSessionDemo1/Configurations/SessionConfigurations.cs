using GymSessionDemo1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSessionDemo1.Configurations
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.ToTable(T =>
            {
                T.HasCheckConstraint("Session_CapacityCheck", "Capacity between 1 AND 25 ");

                T.HasCheckConstraint("Session_StartEndCheck", "EndDate>StartDate ");


            });

            builder.HasOne(s => s.sessionTrainer)
                .WithMany(t => t.TrainerSessions)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
