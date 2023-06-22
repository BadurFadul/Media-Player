

namespace MediaPlayer.src.MediaPlayer;

public class VideoFile : MediaFile
{
    public VideoFile(string filepath, TimeSpan duration, string title, int year) : base(filepath, duration, title, year)
    {
    }

    public override void MediaType()
    {
        Console.WriteLine("This is a videofile media");
    }
}
