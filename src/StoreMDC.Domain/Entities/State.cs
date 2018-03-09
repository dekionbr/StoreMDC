using System.Collections.Generic;

namespace StoreMDC.Domain.Entities
{
    public class State : Entity
    {
        public string Name { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
