namespace StoreMDC.Application.ViewModels
{
    public class CityViewModel : Entity
    {
        public int StateId { get; set; }
        public virtual StateViewModel State { get; set; }

    }
}
