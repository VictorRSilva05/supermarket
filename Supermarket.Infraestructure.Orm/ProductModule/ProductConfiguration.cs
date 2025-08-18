using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Supermarket.Domain.ProductModule;

namespace Supermarket.Infraestructure.Orm.ProductModule;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(d => d.Id)
            .ValueGeneratedNever()
            .IsRequired();

        builder.Property(d => d.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(d => d.Brand)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(d => d.MeasureType)
            .IsRequired();

        builder.Property(d => d.MeasureValue)
            .IsRequired();

        builder.Property(d => d.Category)
            .IsRequired();

        builder.Property(d => d.Price)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(d => d.Barcode)
            .IsRequired()
            .HasMaxLength(50);
    }
}
