namespace Airport.Core.Models
{
    public class User : BaseModel
    {
        public string Name{ get; set; }
        public  BaggageInfo  BaggageInfo { get; set; }
    }
}