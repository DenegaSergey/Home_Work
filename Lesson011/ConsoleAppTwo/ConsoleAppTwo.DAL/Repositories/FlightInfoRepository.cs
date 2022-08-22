using Airport.Core.Models;

namespace Airport.DAL.Repositories
{
    public class FlightInfoRepository
    {
        private readonly List<FlightInfo> _flights;

        public FlightInfoRepository()
        {
            _flights = new List<FlightInfo>()
            {
                new FlightInfo()
                {
                    Id = 1,
                    Number = "MR-03",
                    From = "Minsk",
                    To = "Paris",
                    DepartureTime = new DateTime(2022,7,24, 01, 00, 00)

                },
                new FlightInfo()
                {
                    Id = 2,
                    Number = "CR-07",
                    From = "Minsk",
                    To = "Rom",
                    DepartureTime = new DateTime(2022,7,23, 22, 00, 00)
                },
                new FlightInfo()
                {
                    Id = 3,
                    Number = "TD-08",
                    From = "Minsk",
                    To = "Moscow",
                    DepartureTime = new DateTime(2022,8,22, 04, 30, 00)
                }
            };
        }

        public void Create(FlightInfo item)
        {
            _flights.Add(item);
        }

        public void Create(List<FlightInfo> listOfItems)
        {
            foreach (var item in listOfItems)
            {
                _flights.Add(item);
            }
        }
        public List<FlightInfo> GetAll()
        {
            return _flights;
        }

        public FlightInfo GetFirstOrDefaultById(int id)
        {
            foreach (var flight in _flights)
            {
                if (flight.Id == id)
                {
                    return flight;
                }
            }
            return null!;
        }

        public void Update(FlightInfo item)
        {
            foreach (var flight in _flights)
            {
                if (flight.Id == item.Id)
                {
                    flight.Number = item.Number;
                    flight.From = item.From;
                    flight.To = item.To;
                    flight.DepartureTime = item.DepartureTime;
                }
            }
        }
        
        public void Delete(int id)
        {
            foreach (var flight in _flights)
            {
                if (flight.Id == id)
                {
                    _flights.Remove(flight);
                }
            }
        }
    }
}
