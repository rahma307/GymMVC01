using GymSessionDemo1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSessionDemo1.Configurations
{
    public class UserConfigurations<T> : IEntityTypeConfiguration<T> where T : User
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(p => p.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50);


            builder.Property(p => p.Phone)
                .HasColumnType("varchar")
                .HasMaxLength(11);


            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.HasIndex(x => x.Phone)
              .IsUnique();

            builder.ComplexProperty(x => x.Address);

            builder.ToTable(t =>
            {
                t.HasCheckConstraint("User_PhoneCheck", "Len(Phone)=11 AND (Phone like '010%' oR Phone like '011%' OR Phone like '012%' OR Phone like '015%')");
                t.HasCheckConstraint("Email_formatCheck", "Email like '_%@_%._%'");
            });


        }
    }
}
