using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airport.Core.Models;

namespace Airport.DAL.Repositories
{
    public class BaggageInfoRepository
    {
        private readonly BaggageInfo _baggage;

        public BaggageInfoRepository()
        {
            _baggage = new BaggageInfo()
            {
                MinWight = 0,
            };
            _baggage = new BaggageInfo()
            {
                MaxWight = 15,
            };
        }

        public int GetMaxWight()
        {
            var user = new User();
            user.BaggageInfo.MaxWight = 300;

            return _baggage.MaxWight;
        }
    }
}
