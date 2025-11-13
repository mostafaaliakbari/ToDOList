
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);
        builder.HasIndex(u => u.UserName).IsUnique();
        builder.Property(u => u.UserName).IsRequired();
        builder.Property(u => u.Password).IsRequired();


    }
}

