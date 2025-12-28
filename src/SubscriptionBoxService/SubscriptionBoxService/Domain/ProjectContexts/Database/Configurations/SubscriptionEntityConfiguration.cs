using Domain.Subscription.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Domain.ProjectContexts.Database.Configurations;

public sealed class SubscriptionEntityConfiguration : IEntityTypeConfiguration<Subscription.Subscription>
{
    public void Configure(EntityTypeBuilder<Subscription.Subscription> builder)
    {
        builder.ToTable("subscriptions");
        builder.HasKey(x => x.Id).HasName("pk_subscription");
        builder.HasIndex(x => x.Id).IsUnique();
        
        builder.Property(x => x.Id)
            .HasColumnName("id")
            .IsRequired()
            .HasConversion(toDb => toDb.Id, fromDb => SubID.Create());
        
        builder.Property(x => x.UserId)
            .HasColumnName("sub_user_id")
            .IsRequired()
            .HasConversion(toDb => toDb.Id, fromDb => SubUserID.Create());
        
        builder.Property(x => x.Date)
            .HasColumnName("sub_date")
            .IsRequired()
            .HasConversion(toDb => toDb.Date, fromDb => SubDate.Create(fromDb));
        
        builder.Property(x => x.Price)
            .HasColumnName("sub_price")
            .IsRequired()
            .HasConversion(toDb => toDb.Value, fromDb => SubPrice.Create(fromDb));
        
        builder.Property(x => x.Period)
            .HasColumnName("sub_period")
            .IsRequired()
            .HasConversion(toDb => toDb.Value, fromDb => SubPeriod.Create(fromDb));

        builder.Property(x => x.TarrifPlanID)
            .HasColumnName("sub_tarrif_plan_id")
            .IsRequired()
            .HasConversion(toDb => toDb.Id, fromDb => SubTFID.Create());

        builder.ComplexProperty(
            x => x.Status,
            cpb =>
            {
                cpb.Property(x => x.Key)
                    .HasColumnName("sub_status_id")
                    .IsRequired();
                cpb.Property(x => x.Name)
                    .HasColumnName("sub_name")
                    .IsRequired();
            }
        );

        builder.HasOne<TarrifPlan.TarrifPlan>().WithMany();
        builder.HasOne<User.User>().WithMany();

    }
}