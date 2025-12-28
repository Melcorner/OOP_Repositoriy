using Domain.Box.ValueObjects;
using Domain.Product.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.ProjectContexts.Database.Configurations;

public sealed class BoxEntityConfiguration : IEntityTypeConfiguration<Box.Box>
{
    public void Configure(EntityTypeBuilder<Box.Box> builder)
    {
        builder.ToTable("box");
        builder.HasKey(x => x.BoxID).HasName("pk_box");
        builder.HasIndex(x => x.BoxID).IsUnique();
        
        builder.Property(x => x.BoxID)
            .HasColumnName("box_id")
            .IsRequired()
            .HasConversion(toDb => toDb.Id, fromDb => BoxID.Create());

        builder.Property(x => x.BoxTrackNumber)
            .HasColumnName("box_track_number")
            .IsRequired()
            .HasConversion(toDb => toDb.Value, fromDb => BoxTrackNumber.Create(fromDb));

        builder.Property(x => x.BoxTFID)
            .HasColumnName("box_tf_id")
            .IsRequired()
            .HasConversion(toDb => toDb.Id, fromDb => BoxTFID.Create());

        builder.ComplexProperty(x => x.Contents,
            cpb =>
            {
                cpb.Property(x => x.Amount)
                    .HasColumnName("box_amount")
                    .IsRequired();
                cpb.Property(x =>x.ProductID)
                    .HasColumnName("box_product_id")
                    .IsRequired();
            }
        );

        builder.HasMany<Product.Product>().WithMany();
        builder.HasOne<Delivery.Delivery>().WithOne();
        builder.HasOne<TarrifPlan.TarrifPlan>().WithMany();
    }
}