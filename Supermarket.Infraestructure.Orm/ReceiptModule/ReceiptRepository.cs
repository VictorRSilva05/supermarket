using Supermarket.Domain.ReceipetModule;
using Supermarket.Infraestructure.Orm.Shared;

namespace Supermarket.Infraestructure.Orm.ReceiptModule;
public class ReceiptRepository : BaseOrmRepository<Receipt>, IReceiptRepository
{
    public ReceiptRepository(SupermarketDbContext context) : base(context)
    {
    }
}

