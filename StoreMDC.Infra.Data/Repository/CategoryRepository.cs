using StoreMDC.Domain.Entities;
using StoreMDC.Domain.Interfaces.Repository;
using StoreMDC.Infra.Data.Context;
using StoreMDC.Infra.Data.Repository.Generics;

namespace StoreMDC.Infra.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(StoreMDCContext context) : base(context)
        {
        }
    }
}
