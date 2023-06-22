
namespace MediaPlayer.src.MediaPlayer;

    public class MediaLibrary
    {
        private Guid _id;
        private Dictionary<Guid, MediaFile> _mediaFiles = new();

        public Guid Id {get {return _id;}}
        public string LibraryName {get; set;} = string.Empty;
        public Dictionary<Guid,MediaFile> MediaFiles {get {return _mediaFiles;}}

        public MediaLibrary(Guid id, string libraryname)
        {
            _id = id;
            LibraryName = libraryname;
            _mediaFiles = new Dictionary<Guid, MediaFile>();
        }

    }