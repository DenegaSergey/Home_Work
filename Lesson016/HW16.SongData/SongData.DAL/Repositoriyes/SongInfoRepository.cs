using SongData.Core.Interfaces;
using SongData.Core.Models;

namespace SongData.DAL.Repositoriyes
{
    public class SongInfoRepository : ISongInfoRepository
    {
        private readonly List<Song> songsList = new List<Song>()
        {
            new Song()
            {
                Id = 1, Name = "Like a Rolling Stone", Duration = 6.13, Author = "Bob Dylan", //FolkRock
                Year = new DateTime(1965, 1, 1)
            },
            new Song()
            {
                Id = 2, Name = "Satisfaction", Duration = 3.54, Author = "The Rolling Stones", //BluesRock
                Year = new DateTime(1965, 1, 1)
            },
            new Song()
            {
                Id = 3, Name = "Imagine", Duration = 3.52, Author = "John Lennon", Year = new DateTime(1971, 1, 1) //SoftRock
            },
            new Song()
            {
                Id = 4, Name = "What’s Going On", Duration = 3.52, Author = "Marvin Gaye", //Soul
                Year = new DateTime(1971, 6, 21)
            },
            new Song()
            {
                Id = 5, Name = "Respect", Duration = 3.52, Author = "Aretha Franklin", //RithmAndBlues
                Year = new DateTime(1971, 6, 21)
            }

        };

        public void GetSongList()
        {
            foreach (Song song in songsList)
            {
               Console.WriteLine(song.Id + " " + song.Name ); 
            }
        }
        public void GetSongByDict()
        {
            Dictionary<int, List<Song>> dictionarySongs = songsList.GroupBy(m => m.Id)
                .ToDictionary(keySelector: g => g.Key, elementSelector: g => g.ToList());

            foreach (var songGroup in dictionarySongs)
            {
                Console.WriteLine($"{songGroup.Key} = {string.Join(", ", songGroup.Value.Select(s => s.Name/* + "-" + s.Author + "-" + s.Duration*/))}");
            }
        }

        public List<Song> GetAll()
        {
            return songsList;
        }

        public Song GetFirstOrDefaultById(int id)
        {
            foreach (Song song in songsList)
            {
                if (song.Id == id)
                {
                    return song;
                }
            }
            return null!;
        }
    }
}
