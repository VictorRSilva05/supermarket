using Supermarket.Domain.ProductModule;
using Supermarket.Infraestructure.Orm.Shared;

namespace Supermarket.Infraestructure.Orm.ProductModule;
public class ProductRepository : BaseOrmRepository<Product>, IProductRepository
{
    public ProductRepository(SupermarketDbContext context) : base(context)
    {
    }
}
