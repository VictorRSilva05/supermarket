using Supermarket.Domain.Shared;

namespace Supermarket.Domain.SupplierModule;
public class Supplier : BaseEntity<Supplier>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Ein { get; set; }
    public Adress Address { get; set; }

    public Supplier(string name, string email, string phone, string ein, Adress address)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Ein = ein;
        Address = address;
    }

    public override void UpdateRecord(Supplier UpdatedRecord)
    {
        Name = UpdatedRecord.Name;
        Email = UpdatedRecord.Email;
        Phone = UpdatedRecord.Phone;
        Ein = UpdatedRecord.Ein;
        Address = UpdatedRecord.Address;
    }
}
