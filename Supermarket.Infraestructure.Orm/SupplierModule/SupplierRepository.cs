using Supermarket.Domain.SupplierModule;
using Supermarket.Infraestructure.Orm.Shared;

namespace Supermarket.Infraestructure.Orm.SupplierModule;
public class SupplierRepository : BaseOrmRepository<Supplier>, ISupplierRepository
{
    public SupplierRepository(SupermarketDbContext context) : base(context)
    {
    }
}

