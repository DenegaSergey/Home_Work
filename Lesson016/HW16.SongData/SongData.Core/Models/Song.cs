using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongData.Core.Models
{
    public class Song : BaseModel
    {
        public string Name { get; set; }
        public double Duration { get; set; }
        public string Author { get; set; }
        public DateTime Year { get; set; }

    }
}
