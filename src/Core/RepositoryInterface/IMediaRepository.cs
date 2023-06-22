

namespace MediaPlayer.src.MediaPlayer;

    public interface IMediaRepository
    {
        void Play(MediaFile file);
        void Pause();
        void Stop();
        void Next();
        void Previous();
        void Seek(TimeSpan position);
        void SetVolume(double volume);
        //void LoadPlaylist(Playlist playlist);
        void Shuffle();
        void Repeat();
    }
