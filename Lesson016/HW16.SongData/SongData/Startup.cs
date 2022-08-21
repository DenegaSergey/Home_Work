using Newtonsoft.Json;
using SongData.Core.Interfaces;
using SongData.Core.Models;

namespace SongData.UI
{
    public class Startup
    {
        private readonly ISongInfoService _songInfoService;

        public Startup(ISongInfoService songInfoService)
        {
            _songInfoService = songInfoService;
        }

        public void Start()
        {

            _songInfoService.GetSongList();



            _songInfoService.GetSongData();
            

            // string songs = _songInfoService.GetSongData();
            //string result = JsonConvert.SerializeObject(songs, Formatting.Indented);
            //Console.WriteLine(result);

            //Console.WriteLine("");
            //string str = Console.ReadLine();
            //Genre genre = (Genre)Enum.Parse(typeof(Genre), str, ignoreCase: true);
            //switch (genre)
            //{
            //    case Genre.FolkRock:

            //        break;
            //    case Genre.SoftRock:

            //        break;
            //    case Genre.BluesRock:

            //        break;
            //    case Genre.Soul:
            //        Console.WriteLine();

            //        break;
            //    case Genre.RithmAndBlues:
            //        Console.WriteLine();
            //        break;
            //    default:
            //        break;
            //}

        }

    }
    
}