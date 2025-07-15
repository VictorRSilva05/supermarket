using Supermarket.Domain.ProductModule;
using Supermarket.Domain.Shared;
using Supermarket.Domain.SupplierModule;

namespace Supermarket.Domain.BatchModule;
public class Batch : BaseEntity<Batch>
{
    public string BatchNumber { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public DateTime ManufactureDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public Supplier Supplier { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice => UnitPrice * Quantity;

    public Batch(string batchNumber, Product product, int quantity, DateTime manufactureDate, DateTime expiryDate, Supplier supplier)
    {
        BatchNumber = batchNumber;
        Product = product;
        Quantity = quantity;
        ManufactureDate = manufactureDate;
        ExpiryDate = expiryDate;
        Supplier = supplier;
    }

    public override void UpdateRecord(Batch UpdatedRecord)
    {
        BatchNumber = UpdatedRecord.BatchNumber;
        Product = UpdatedRecord.Product;
        Quantity = UpdatedRecord.Quantity;
        ManufactureDate = UpdatedRecord.ManufactureDate;
        ExpiryDate = UpdatedRecord.ExpiryDate;
        Supplier = UpdatedRecord.Supplier;
        UnitPrice = UpdatedRecord.UnitPrice;
    }
}
