

namespace MediaPlayer.src.MediaPlayer;

public class PlayListService : IPlayListService
{
    private IPlayListRepository _playlistRepository;
    public PlayListService(IPlayListRepository playListRepository)
    {
        _playlistRepository = playListRepository;
    }
    
    public void AddNewFile(int playListId, int fileId, int userId)
    {
        throw new NotImplementedException();
    }

    public void EmptyList(int playListId, int userId)
    {
        throw new NotImplementedException();
    }

    public bool RemoveFile(int playListId, int fileId, int userId)
    {
        throw new NotImplementedException();
    }
}
