using Supermarket.Domain.Shared;

namespace Supermarket.Domain.ProductModule;
public class Product : BaseEntity<Product>
{
    public string Name { get; set; }
    public string Brand { get; set; }
    public MeasuresEnum MeasureType { get; set; }
    public int MeasureValue { get; set; }
    public CategoriesEnum Category { get; set; }
    public decimal Price { get; set; }
    public string Barcode { get; set; }

    public Product(string name, string brand, MeasuresEnum measureType, int measureValue, CategoriesEnum category, decimal price, string barcode)
    {
        Name = name;
        Brand = brand;
        MeasureType = measureType;
        MeasureValue = measureValue;
        Category = category;
        Price = price;
        Barcode = barcode;
    }

    public override void UpdateRecord(Product UpdatedRecord)
    {
        Name = UpdatedRecord.Name;
        Brand = UpdatedRecord.Brand;
        MeasureType = UpdatedRecord.MeasureType;
        MeasureValue = UpdatedRecord.MeasureValue;
        Category = UpdatedRecord.Category;
        Price = UpdatedRecord.Price;
        Barcode = UpdatedRecord.Barcode;
    }
}
