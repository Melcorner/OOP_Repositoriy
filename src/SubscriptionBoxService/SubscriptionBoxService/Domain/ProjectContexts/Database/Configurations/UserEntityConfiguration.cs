using Domain.User.UserProfile.ValueObjects;
using Domain.User.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.ProjectContexts.Database.Configurations;

public sealed class UserEntityConfiguration : IEntityTypeConfiguration<User.User>
{
    public void Configure(EntityTypeBuilder<User.User> builder)
    {
        builder.ToTable("users");
        builder.HasKey(x => x.Id).HasName("pk_users");
        builder.HasIndex(x => x.Id).IsUnique();

        builder.Property(x => x.Id)
            .HasColumnName("user_id")
            .IsRequired()
            .HasConversion(toDb => toDb.Id, fromDb => UserID.Create());
        
        builder.Property(x => x.Address)
            .HasColumnName("user_name")
            .IsRequired()
            .HasConversion(toDb => toDb.Value, fromDb => UserAddress.Create(fromDb));
        
        builder.ComplexProperty(
            x => x.Credentials,
            cpb =>
            {
                cpb.Property(x => x.Login).HasColumnName("login").IsRequired();
                cpb.Property(x => x.Password).HasColumnName("password").IsRequired();
            }
        );

        builder.ComplexProperty(
            x => x.Profiles,
            cpb =>
            {
                cpb.Property(x => x.Name)
                    .HasColumnName("name")
                    .IsRequired()
                    .HasConversion(toDb => toDb.Value, fromDb => UserName.Create(fromDb));
                cpb.Property(x => x.Surname)
                    .HasColumnName("surname")
                    .IsRequired()
                    .HasConversion(toDb => toDb.Value, fromDb => UserSurname.Create(fromDb));
                cpb.Property(x => x.Email)
                    .HasColumnName("email")
                    .IsRequired()
                    .HasConversion(toDb => toDb.Value, fromDb => UserEmail.Create(fromDb));
                cpb.Property(x => x.DoB)
                    .HasColumnName("dob")
                    .IsRequired()
                    .HasConversion(toDb => toDb.Date, fromDb => UserDoB.Create(fromDb));
            }
        );
        builder.HasMany<Subscription.Subscription>().WithOne();
        builder.HasMany<Delivery.Delivery>().WithOne();
    }
}