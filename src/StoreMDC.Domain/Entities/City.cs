namespace StoreMDC.Domain.Entities
{
    public class City : Entity
    {
        public string Name { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }

    }
}
