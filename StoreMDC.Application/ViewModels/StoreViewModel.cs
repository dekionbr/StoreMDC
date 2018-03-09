using System.Collections.Generic;

namespace StoreMDC.Application.ViewModels
{
    public class StoreViewModel : Entity
    {
        public ICollection<CategoryViewModel> Categories { get; set; }
    }
}
