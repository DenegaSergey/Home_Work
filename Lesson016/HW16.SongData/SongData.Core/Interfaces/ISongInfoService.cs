using SongData.Core.Models;

namespace SongData.Core.Interfaces
{
    public interface ISongInfoService
    {
        Song GetSongByID(int id);

        string GetSongs();

        string GetSongData();

        void GetSongList();
    }
}
