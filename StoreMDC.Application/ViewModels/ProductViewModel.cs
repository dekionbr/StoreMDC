using System.ComponentModel.DataAnnotations;

namespace StoreMDC.Application.ViewModels
{
    public class ProductViewModel : Entity
    {
        [Required(ErrorMessage = "Inclua o preço do produto")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual CategoryViewModel Category { get; set; }
    }
}
