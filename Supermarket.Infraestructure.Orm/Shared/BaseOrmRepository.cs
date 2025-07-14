using Microsoft.EntityFrameworkCore;
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

    public void UpdateRecord(Guid id, T record)
    {
        throw new NotImplementedException();
    }

    public void DeleteRecord(Guid id)
    {
        throw new NotImplementedException();
    }

    public virtual T? GetRecordById(Guid id)
    {
        return records.FirstOrDefault(x => x.Id == id);
    }

    public virtual List<T> GetAll()
    {
        return records.ToList();
    }
}
