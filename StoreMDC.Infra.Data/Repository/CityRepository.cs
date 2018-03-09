using StoreMDC.Domain.Entities;
using StoreMDC.Domain.Interfaces.Repository;
using StoreMDC.Infra.Data.Context;
using StoreMDC.Infra.Data.Repository.Generics;

namespace StoreMDC.Infra.Data.Repository
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(StoreMDCContext context) : base(context)
        {
        }
    }
}
