
namespace MediaPlayer.src.MediaPlayer;

    public abstract class MediaFile
    {
        private bool _isPlaying;
        private readonly string _fileid;
        public string FilePath {get; set;} = String.Empty;
        public string FileName {get; set;}
        public TimeSpan Duration {get; set;}
        public string Title {get; set;} = String.Empty;
        public int Year {get; set;}

        public MediaFile(string filename, string fileid, string filepath, TimeSpan duration, string title, int year)
        {
            FileName = filename;
            _fileid = fileid;
            FilePath = filepath;
            Duration = duration;
            Title = title;
            Year = year;
            _isPlaying =false;
        }
        public abstract void MediaType();

        public void Play()
        {
            if (!_isPlaying)
            {
                _isPlaying = true;
                Console.WriteLine("Playing...");
            }
        }

        public void Pause()
        {
            if (_isPlaying)
            {
                _isPlaying = false;
                Console.WriteLine("Paused.");
            }
        }

        public void Stop()
        {
            if (_isPlaying)
            {
                _isPlaying = false;
                Console.WriteLine("Stopped.");
            }
        }

    }
