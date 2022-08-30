namespace Airport.DAL.Repositories
{
    public class BaggageInfoRepository
    {
        private readonly BaggageInfoRepository _baggageInfoRepository;

        public BaggageInfoRepository(BaggageInfoRepository baggage)
        {
            _baggageInfoRepository = baggage;
        }
    }
}
