using Domain.Delivery.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.ProjectContexts.Database.Configurations;

public sealed class DeliveryEntityConfiguration : IEntityTypeConfiguration<Delivery.Delivery>
{
    public void Configure(EntityTypeBuilder<Delivery.Delivery> builder)
    {
        builder.ToTable("delivery");
        builder.HasKey(x => x.TrackNumber).HasName("pk_delivery");
        builder.HasIndex(x => x.TrackNumber).IsUnique();
        
        builder.Property(x => x.TrackNumber)
            .HasColumnName("tarck_number")
            .IsRequired()
            .HasConversion(toDb => toDb.Value, fromDb => DeliveryBoxTrackNum.Create(fromDb));

        builder.Property(x => x.UserID)
            .HasColumnName("user_id")
            .IsRequired()
            .HasConversion(toDb => toDb.Id, fromDb => DeliveryUserID.Create());
        
        builder.Property(x => x.UserAddress)
            .HasColumnName("user_address")
            .IsRequired()
            .HasConversion(toDb => toDb.Value, fromDb => DeliveryUserAddress.Create(fromDb));

        builder.ComplexProperty(x => x.Status,
            cpb =>
            {
                cpb.Property(x => x.Key)
                    .HasColumnName("delivery_status_id")
                    .IsRequired();
                cpb.Property(x => x.Name)
                    .HasColumnName("delivery_status_name")
                    .IsRequired();
            }
        );
        
        builder.HasOne<User.User>().WithMany().HasForeignKey(x => x.UserID);
        builder.HasOne<Box.Box>().WithMany().HasForeignKey(x => x.TrackNumber);
    }
}