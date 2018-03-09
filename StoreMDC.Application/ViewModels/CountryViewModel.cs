using System.Collections.Generic;

namespace StoreMDC.Application.ViewModels
{
    public class CountryViewModel : Entity
    {
        public ICollection<StateViewModel> States { get; set; }
    }
}
