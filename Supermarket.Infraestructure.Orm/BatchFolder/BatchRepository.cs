using Supermarket.Domain.BatchModule;
using Supermarket.Infraestructure.Orm.Shared;

namespace Supermarket.Infraestructure.Orm.BatchFolder;
public class BatchRepository : BaseOrmRepository<Batch>, IBatchRepository
{
    public BatchRepository(SupermarketDbContext context) : base(context)
    {
    }
}

