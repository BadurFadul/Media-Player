
namespace MediaPlayer.src.MediaPlayer;

    public class Playlist
    {
        private List<MediaFile> _playlists = new();
        private Guid _id;

        public Guid Id {get {return _id;}}
        public string PlaylistName {get; set;} = string.Empty;
        public List<MediaFile> Playlists {get {return _playlists;}}

        public Playlist(Guid id, string playlistname)
        {
            _id = id;
            PlaylistName = playlistname;
            _playlists = new List<MediaFile>();
        }
        public void AddMediaFile(MediaFile file)
        {
            _playlists.Add(file);
        }

         public void RemoveFile(MediaFile file, Guid userId)
        {
            if (CheckUserId(userId))
                _playlists.Remove(file);
        }

        public void EmptyList(Guid userId)
        {
            if (CheckUserId(userId))
                _playlists.Clear();
        }

        private bool CheckUserId(Guid userId)
        {
            if (userId == _id) return true;
            return false;
        }
    }
