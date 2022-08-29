using SongData.Core.Interfaces;
using SongData.Core.Models;

namespace SongData.BLL.Services
{
    public class SongInfoService : ISongInfoService
    {
        public readonly ISongInfoRepository _songInfoRepository;

        public SongInfoService(ISongInfoRepository songInfoRepository)
        {
            _songInfoRepository = songInfoRepository;
        }

        public string GetSongs()
        {
            var songs = _songInfoRepository.GetAll();
            var result = " ";
            foreach (var song in songs)
            {
                result += $"Id: {song.Id}  Name: {song.Name} /* Author: {song.Author}  Year: {song.Year}  Duration: {song.Duration}*/\n";
            }
            return result;
        }

        public Song GetSongByID(int id)
        {
            return _songInfoRepository.GetFirstOrDefaultById(id);
        }

        public string GetSongData()  
        {
             _songInfoRepository.GetSongByDict();
             return null;
        }

        public void GetSongList()
        {
            _songInfoRepository.GetSongList();
        }
    }
}