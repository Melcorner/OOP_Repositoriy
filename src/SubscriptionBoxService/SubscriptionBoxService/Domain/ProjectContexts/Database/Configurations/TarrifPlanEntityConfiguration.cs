using Domain.TarrifPlan.TarrifFilling.ValueObjects;
using Domain.TarrifPlan.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.ProjectContexts.Database.Configurations;

public sealed class TarrifPlanEntityConfiguration : IEntityTypeConfiguration<TarrifPlan.TarrifPlan>
{
    public void Configure(EntityTypeBuilder<TarrifPlan.TarrifPlan> builder)
    {
        builder.ToTable("tarrif_plans");
        builder.HasKey(x => x.TarrifPlanId).HasName("pk_tarrif_plan");
        builder.HasIndex(x => x.TarrifPlanId).IsUnique();
        
        builder.Property(x => x.TarrifPlanId)
            .HasColumnName("tarrif_plan_id")
            .IsRequired()
            .HasConversion(toDb => toDb.Id, fromDb => TarrifPlanID.Create());
        
        builder.Property(x => x.TarrifPlanName)
            .HasColumnName("tarrif_plan_name")
            .HasMaxLength(100)
            .IsRequired()
            .HasConversion(toDb => toDb.Value, fromDb => TarrifPlanName.Create(fromDb));

        builder.Property(x => x.TarrifPlanPrice)
            .HasColumnName("tarrif_plan_price")
            .IsRequired()
            .HasConversion(toDb => toDb.Price, fromDb => TarrifPlanPrice.Create(fromDb));

        builder.ComplexProperty(
            x => x.Fillings,
            cpb =>
            {
                cpb.Property(x => x.Amount)
                    .HasColumnName("tarrif_plan_amount")
                    .IsRequired()
                    .HasConversion(toDb => toDb.Amount, fromDb => TFProductAmount.Create(fromDb));

                cpb.Property(x => x.Category)
                    .HasColumnName("tarrif_plan_category")
                    .IsRequired();
            }
        );

        builder.HasMany<Box.Box>().WithOne();
        builder.HasMany<Subscription.Subscription>().WithOne();

    }
}