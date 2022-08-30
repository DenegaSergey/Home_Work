namespace Airport.Core.Models
{
    public class FlightInfo : BaseModel
    {
        public string Number { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime DepartureTime{ get; set; }
    }
}
