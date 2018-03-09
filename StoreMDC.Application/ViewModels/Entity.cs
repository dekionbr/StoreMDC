using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StoreMDC.Application.ViewModels
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é Obrigatório")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }

    }
}
