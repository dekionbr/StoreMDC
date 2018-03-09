using System.Collections.Generic;

namespace StoreMDC.Domain.Entities
{
    public class Store : Entity
    {
        public string Name { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
