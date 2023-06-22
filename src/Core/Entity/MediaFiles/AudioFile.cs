

namespace MediaPlayer.src.MediaPlayer;

public class AudioFile : MediaFile
{
    public AudioFile(string filepath, TimeSpan duration, string title, int year) : base(filepath, duration, title, year)
    {
    }

    public override void MediaType()
    {
        Console.WriteLine("This is a Audio media player");
    }
}
