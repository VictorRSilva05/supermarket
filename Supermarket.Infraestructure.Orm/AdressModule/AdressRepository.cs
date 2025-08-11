using Supermarket.Domain.AdressModule;
using Supermarket.Domain.Shared;
using Supermarket.Infraestructure.Orm.Shared;

namespace Supermarket.Infraestructure.Orm.AdressModule;
public class AdressRepository : BaseOrmRepository<Adress>, IAdressRepository
{
    public AdressRepository(SupermarketDbContext context) : base(context)
    {
    }

}
