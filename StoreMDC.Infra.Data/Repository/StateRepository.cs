using StoreMDC.Domain.Entities;
using StoreMDC.Domain.Interfaces.Repository;
using StoreMDC.Infra.Data.Context;
using StoreMDC.Infra.Data.Repository.Generics;

namespace StoreMDC.Infra.Data.Repository
{
    public class StateRepository : Repository<State>, IStateRepository
    {
        public StateRepository(StoreMDCContext context) : base(context)
        {
        }
    }
}
