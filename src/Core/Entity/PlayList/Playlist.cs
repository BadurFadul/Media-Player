using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaPlayer.src.MediaPlayer;

    public class Playlist
    {
        private Guid _id;
        private Dictionary<Guid, MediaFile> _playlists = new();

        public Guid Id {get {return _id;}}
        public string PlaylistName {get; set;} = string.Empty;
        public Dictionary<Guid,MediaFile> Playlists {get {return _playlists;}}

        public Playlist(Guid id, string playlistname)
        {
            _id = id;
            PlaylistName = playlistname;
            _playlists = new Dictionary<Guid, MediaFile>();
        }
    }
