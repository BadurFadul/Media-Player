
namespace MediaPlayer.src.MediaPlayer;

    public abstract class MediaFile
    {
        public string FilePath {get; set;} = String.Empty;
        public TimeSpan Duration {get; set;}
        public string Title {get; set;} = String.Empty;
        public int Year {get; set;}

        public MediaFile(string filepath, TimeSpan duration, string title, int year)
        {
            FilePath = filepath;
            Duration = duration;
            Title = title;
            Year = year;
        }

        public abstract void MediaType();
    }
