using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Supermarket.Domain.AdressModule;

namespace Supermarket.Infraestructure.Orm.AdressModule;
public class AdressConfiguration : IEntityTypeConfiguration<Adress>
{
    public void Configure(EntityTypeBuilder<Adress> builder)
    {
        builder.Property(d => d.Id)
            .ValueGeneratedNever()
            .IsRequired();

        builder.Property(d => d.PostalCode)
            .IsRequired();

        builder.Property(d => d.City)
            .IsRequired();

        builder.Property(d => d.Neighborhood)
            .IsRequired();

        builder.Property(d => d.Street)
            .IsRequired();
    }
}
