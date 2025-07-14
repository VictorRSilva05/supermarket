namespace Supermarket.Domain.Shared;
public abstract class BaseEntity<T>
{
    public Guid Id { get; set; }

    public abstract void UpdateRecord(T UpdatedRecord);
}
