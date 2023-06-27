
using MediaPlayer.src.MediaPlayer;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create a new Guid for the playlist ID
        Guid playlistId = Guid.NewGuid();
        // Create a new instance of MediaFile
        AudioFile audioFile1 = new AudioFile("song.mp3", "98765", "/path/to/audio", TimeSpan.FromMinutes(3), "Awesome song", 2022);
        VideoFile vidioFile1 = new VideoFile("song.mp4", "98765", "/path/to/video", TimeSpan.FromMinutes(4), "Awesome Video", 2022);
        Playlist playlist1 = new Playlist(playlistId,"Playlist 1");
        playlist1.AddMediaFile(audioFile1);
        playlist1.AddMediaFile(vidioFile1);

        var user = new User(12,"sam","soul");
    
    }
}
