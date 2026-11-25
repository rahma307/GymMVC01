using GymSessionDemo1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSessionDemo1.Configurations
{
    public class MemberConfigurations : UserConfigurations<Member> ,IEntityTypeConfiguration<Member>
    {
        public  new  void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(p => p.CreatedAt).HasDefaultValueSql("GETDATE()").HasColumnName("joinDate");
            base.Configure(builder);

        }
    }
}
