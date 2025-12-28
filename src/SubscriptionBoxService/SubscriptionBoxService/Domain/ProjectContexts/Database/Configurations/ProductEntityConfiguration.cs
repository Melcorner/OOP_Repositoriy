using Domain.Product.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.ProjectContexts.Database.Configurations;

public sealed class ProductEntityConfiguration : IEntityTypeConfiguration<Product.Product>
{
    public void Configure(EntityTypeBuilder<Product.Product> builder)
    {
        builder.ToTable("products");
        builder.HasKey(x=>x.ProductId).HasName("pk_products");
        builder.HasIndex(x => x.ProductId).IsUnique();
        
        builder.Property(x => x.ProductId)
            .HasColumnName("product_id")
            .IsRequired()
            .HasConversion(toDb => toDb.Id, fromDb => ProductID.Create());
        
        builder.Property(x => x.ProductName)
            .HasColumnName("name")
            .IsRequired()
            .HasConversion(toDb => toDb.Value, fromDb => ProductName.Create(fromDb));
        
        builder.Property(x => x.ProductPrice)
            .HasColumnName("price")
            .IsRequired()
            .HasConversion(toDb => toDb.Value, fromDb => ProductPrice.Create(fromDb));
        
        builder.Property(x => x.ProductAmountInStock)
            .HasColumnName("amount_in_stock")
            .IsRequired()
            .HasConversion(toDb => toDb.Value, fromDb => ProductAmountInStock.Create(fromDb));
        
        builder.ComplexProperty(
            x => x.ProductCategory,
            cpb =>
            {
                cpb.Property(x => x.Key)
                    .HasColumnName("category_id")
                    .IsRequired();
                cpb.Property(x => x.Name)
                    .HasColumnName("category_name")
                    .IsRequired();
            }
        );

        builder.HasMany<Box.Box>().WithMany();
    }
}