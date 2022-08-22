namespace MotorcyclesStore.Core.Models
{
    public class MotoInfo : BaseModel
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public DateTime Year { get; set; }
        public int Odometer { get; set; }
        public int Price { get; set; }
    }
}
