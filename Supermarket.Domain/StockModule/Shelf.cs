using Supermarket.Domain.ProductModule;
using Supermarket.Domain.Shared;

namespace Supermarket.Domain.StockModule;
public class Shelf : BaseEntity<Shelf>
{
    public string ShelfName { get; set; }
    public List<Product> Products { get; set; }

    public Shelf()
    {
        Products = new List<Product>();
    }

    public Shelf(string shelfName, List<Product> products) : this()
    {
        ShelfName = shelfName;
        Products = products;
    }

    public override void UpdateRecord(Shelf UpdatedRecord)
    {
        ShelfName = UpdatedRecord.ShelfName;
        Products = UpdatedRecord.Products ?? new List<Product>();
    }
}
