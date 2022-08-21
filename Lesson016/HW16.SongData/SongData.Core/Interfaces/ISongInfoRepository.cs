using SongData.Core.Models;

namespace SongData.Core.Interfaces
{
    public interface ISongInfoRepository
    {
        List<Song> GetAll();
        Song GetFirstOrDefaultById(int id);

        void GetSongByDict();
        void GetSongList();

    }
}
