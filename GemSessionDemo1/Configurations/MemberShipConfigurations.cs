using GymSessionDemo1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSessionDemo1.Configurations
{
    public class MemberShipConfigurations : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasOne(m => m.Member)
                 .WithMany(me => me.MemberSubscriptions)
                 .HasForeignKey(m=>m.MemberId)
                 .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(p => p.Plan)
                .WithMany(pl => pl.PlanSubscriptions)
                .HasForeignKey(p=>p.PlanId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Ignore(p => p.Status);

            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GETDATE()");

            builder.HasKey(p => p.Id);


        }
    }
}
