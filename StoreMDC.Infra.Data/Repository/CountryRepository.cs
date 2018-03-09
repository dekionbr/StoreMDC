using StoreMDC.Domain.Entities;
using StoreMDC.Domain.Interfaces.Repository;
using StoreMDC.Infra.Data.Context;
using StoreMDC.Infra.Data.Repository.Generics;

namespace StoreMDC.Infra.Data.Repository
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(StoreMDCContext context) : base(context)
        {
        }
    }
}
