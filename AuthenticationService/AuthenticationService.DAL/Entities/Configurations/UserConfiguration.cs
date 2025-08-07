using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuthenticationService.DAL.Entities.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .Property(r => r.FirstName)
            .HasMaxLength(50)
            .IsRequired(); 

        builder
            .Property(r => r.LastName)
            .HasMaxLength(50)
            .IsRequired();
    }
}