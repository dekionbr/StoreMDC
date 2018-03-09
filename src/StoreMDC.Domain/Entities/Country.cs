using System.Collections.Generic;

namespace StoreMDC.Domain.Entities
{
    public class Country : Entity
    {
        public string Name { get; set; }
        public ICollection<State> States { get; set; }
    }
}
