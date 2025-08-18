using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Supermarket.Domain.SupplierModule;

namespace Supermarket.Infraestructure.Orm.SupplierModule;
public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
{
    public void Configure(EntityTypeBuilder<Supplier> builder)
    {
        builder.Property(d => d.Id)
            .ValueGeneratedNever()  
            .IsRequired();

        builder.Property(d => d.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(d => d.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(d => d.Phone)
            .IsRequired()
            .HasMaxLength(15);

        builder.Property(d => d.Ein)
            .IsRequired()
            .HasMaxLength(15);

        builder.HasOne(d => d.Address)
            .WithMany()
            .OnDelete(DeleteBehavior.Cascade);      
    }
}
