using Supermarket.Domain.Shared;

namespace Supermarket.Domain.GondolaModule;
public class Gondola : BaseEntity<Gondola>
{
    public string GondolaName { get; set; }
    public List<Shelf> Shelves { get; set; }

    public Gondola()
    {
        Shelves = new List<Shelf>();
    }

    public Gondola(string gondolaName, List<Shelf> shelves) : this()
    {
        GondolaName = gondolaName;
        Shelves = shelves;
    }
    public override void UpdateRecord(Gondola UpdatedRecord)
    {
        throw new NotImplementedException();
    }
}
