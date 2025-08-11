namespace Supermarket.Domain.Shared;
public interface IRepository<T> where T : BaseEntity<T>
{
    public void AddRecord(T record);
    public bool UpdateRecord(Guid id, T updatedRecord);
    public bool DeleteRecord(Guid id);
    public List<T> GetAll();
    public T? GetRecordById(Guid id);
}
