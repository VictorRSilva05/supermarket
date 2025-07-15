using Supermarket.Domain.Shared;

namespace Supermarket.Domain.StockModule;
public class Tower : BaseEntity<Tower>
{
    public string TowerName { get; set; }
    public List<Shelf> Shelves { get; set; }

    public Tower()
    {
        Shelves = new List<Shelf>();
    }

    public Tower(string towerName, List<Shelf> shelves) : this()
    {
        TowerName = towerName;
        Shelves = shelves;
    }
    public override void UpdateRecord(Tower UpdatedRecord)
    {
        throw new NotImplementedException();
    }
}
