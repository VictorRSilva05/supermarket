using Supermarket.Domain.Shared;

namespace Supermarket.Domain.SupplierModule;
public class Adress : BaseEntity<Adress>
{
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string Neighborhood { get; set; }
    public string Street { get; set; }

    public Adress(string postalCode, string city, string neighborhood, string street)
    {
        PostalCode = postalCode;
        City = city;
        Neighborhood = neighborhood;
        Street = street;
    }

    public override void UpdateRecord(Adress UpdatedRecord)
    {
        PostalCode = UpdatedRecord.PostalCode;
        City = UpdatedRecord.City;
        Neighborhood = UpdatedRecord.Neighborhood;
        Street = UpdatedRecord.Street;
    }
}
