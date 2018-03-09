using System.Collections.Generic;

namespace StoreMDC.Application.ViewModels
{
    public class StateViewModel : Entity
    {
        public int CountryId { get; set; }
        public virtual CountryViewModel Country { get; set; }
        public virtual ICollection<CityViewModel> Cities { get; set; }
    }
}
