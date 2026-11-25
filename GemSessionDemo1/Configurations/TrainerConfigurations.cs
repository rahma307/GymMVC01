using GymSessionDemo1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSessionDemo1.Configurations
{
    public class TrainerConfigurations : UserConfigurations<Trainer>, IEntityTypeConfiguration<Trainer>
    {
        public  new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(p => p.CreatedAt).HasDefaultValueSql("GETDATE()");
            base.Configure(builder);


        }
    }
}
