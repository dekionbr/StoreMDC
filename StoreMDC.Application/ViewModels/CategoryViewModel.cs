using System.Collections.Generic;

namespace StoreMDC.Application.ViewModels
{
    public class CategoryViewModel : Entity
    {
        public int StoreId { get; set; }
        public StoreViewModel Store { get; set; }
        public ICollection<ProductViewModel> Products { get; set; }

    }
}
