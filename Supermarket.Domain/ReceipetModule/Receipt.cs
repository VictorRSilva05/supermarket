using Supermarket.Domain.BatchModule;
using Supermarket.Domain.Shared;
using Supermarket.Domain.SupplierModule;

namespace Supermarket.Domain.ReceipetModule;
public class Receipt : BaseEntity<Receipt>
{
    public Batch Batch { get; set; }
    public DateTime ReceiptDate { get; set; }
    public Supplier Supplier { get; set; }

    public Receipt(Batch batch, DateTime receiptDate, Supplier supplier)
    {
        Batch = batch;
        ReceiptDate = receiptDate;
        Supplier = supplier;
    }

    public override void UpdateRecord(Receipt UpdatedRecord)
    {
        Batch = UpdatedRecord.Batch;
        ReceiptDate = UpdatedRecord.ReceiptDate;
        Supplier = UpdatedRecord.Supplier;
    }
}
