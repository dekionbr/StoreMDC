using System.Collections.Generic;

namespace StoreMDC.Domain.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
