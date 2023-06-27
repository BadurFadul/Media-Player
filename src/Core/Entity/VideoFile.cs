

namespace MediaPlayer.src.MediaPlayer;

public class VideoFile : MediaFile
{
    public VideoFile(string filename, string fileid, string filepath, TimeSpan duration, string title, int year) : base(filename, fileid, filepath, duration, title, year)
    {
    }

    public override void MediaType()
    {
        Console.WriteLine("This is a videofile media");
    }
}
