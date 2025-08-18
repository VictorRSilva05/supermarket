using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Supermarket.Domain.ReceipetModule;

namespace Supermarket.Infraestructure.Orm.ReceiptModule;
public class ReceiptConfiguration : IEntityTypeConfiguration<Receipt>
{
    public void Configure(EntityTypeBuilder<Receipt> builder)
    {
        builder.Property(d => d.Id)
            .ValueGeneratedNever()
            .IsRequired();

        builder.HasOne(d => d.Batch)
            .WithMany()
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(d => d.ReceiptDate)
            .IsRequired()
            .HasColumnType("datetime");

        builder.HasOne(d => d.Supplier)
            .WithMany()
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
