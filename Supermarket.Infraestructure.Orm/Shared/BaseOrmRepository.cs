using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using Supermarket.Domain.Shared;

namespace Supermarket.Infraestructure.Orm.Shared;
public class BaseOrmRepository<T> where T : BaseEntity<T>
{
    private readonly SupermarketDbContext context;
    private DbSet<T> records;

    public BaseOrmRepository(SupermarketDbContext context)
    {
        this.context = context;
    }

    public void AddRecord(T record)
    {
        records.Add(record);
    }

    public bool UpdateRecord(Guid id, T UpdatedRecord)
    {
        var selectedRecord = GetRecordById(id);

        if (selectedRecord is null)
            return false;

        selectedRecord.UpdateRecord(UpdatedRecord);

        return true;
    }

    public bool DeleteRecord(Guid id)
    {
        var selectedRecord = GetRecordById(id);

        if (selectedRecord is null)
            return false;

        records.Remove(selectedRecord);

        return true;
    }

    public virtual T? GetRecordById(Guid id)
    {
        return records.FirstOrDefault(x => x.Id.Equals(id));
    }

    public virtual List<T> GetAll()
    {
        return records.ToList();
    }
}
