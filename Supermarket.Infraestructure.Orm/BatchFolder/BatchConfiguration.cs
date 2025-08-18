using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Supermarket.Domain.BatchModule;

namespace Supermarket.Infraestructure.Orm.BatchFolder;
public class BatchConfiguration : IEntityTypeConfiguration<Batch>
{
    public void Configure(EntityTypeBuilder<Batch> builder)
    {
        builder.Property(d => d.Id)
            .ValueGeneratedNever()
            .IsRequired();

        builder.Property(d => d.BatchNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasOne(d => d.Product)
            .WithMany()
            .IsRequired();

        builder.Property(d => d.Quantity)
            .IsRequired();

        builder.Property(d => d.ManufactureDate)
            .IsRequired()
            .HasColumnType("datetime");

        builder.Property(d => d.ExpiryDate)
            .IsRequired()
            .HasColumnType("datetime");

        builder.HasOne(d => d.Supplier)
            .WithMany()
            .IsRequired();

        builder.Property(d => d.UnitPrice)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(d => d.TotalPrice)
            .HasComputedColumnSql("[UnitPrice] * [Quantity]")
            .IsRequired();
    }
}
