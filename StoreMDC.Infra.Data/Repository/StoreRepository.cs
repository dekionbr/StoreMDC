using StoreMDC.Domain.Entities;
using StoreMDC.Infra.Data.Repository.Generics;
using StoreMDC.Infra.Data.Context;
using StoreMDC.Domain.Interfaces.Repository;

namespace StoreMDC.Infra.Data.Repository
{
    public class StoreRepository : Repository<Store>, IStoreRepository
    {
        public StoreRepository(StoreMDCContext context) : base(context)
        {
        }
    }
}
