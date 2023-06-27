
namespace MediaPlayer.src.MediaPlayer;

    public class MediaService: ImediaService
    {
        private IMediaRepository _mediaRepository;

        public MediaService(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }

    public void CreateNewFile(string fileName, string filePath, TimeSpan duration)
    {
        throw new NotImplementedException();
    }

    public void DeleteFileById(int fileId)
    {
        throw new NotImplementedException();
    }

    public void GetAllFiles()
    {
        throw new NotImplementedException();
    }

    public void GetFileById(int fileId)
    {
        throw new NotImplementedException();
    }

    public void Next()
    {
        throw new NotImplementedException();
    }

    public void Pause()
    {
        throw new NotImplementedException();
    }

    public void Play(MediaFile file)
    {
        throw new NotImplementedException();
    }

    public void Previous()
    {
        throw new NotImplementedException();
    }

    public void Repeat()
    {
        throw new NotImplementedException();
    }

    public void Seek(TimeSpan position)
    {
        throw new NotImplementedException();
    }

    public void SetVolume(double volume)
    {
        throw new NotImplementedException();
    }

    public void Shuffle()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}
