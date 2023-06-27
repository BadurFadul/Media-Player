
namespace MediaPlayer.src.MediaPlayer;

    public class User
    {
        private readonly List<Playlist> _playlists = new();
        private int _userId;

        public int UserId {get {return _userId;}}
        public string UserFirstName {get; set;} = String.Empty;
        public string UserLastName {get; set;} = String.Empty;

        public User(int userid, string userfirstname, string userlastname)
        {
            _userId = userid;
            UserFirstName = userfirstname;
            UserLastName = userlastname;
            _playlists = new List<Playlist>();
        }
        
        public void AddNewList(Playlist list)
        {
            _playlists.Add(list);
        }

        public void RemoveFromList(Playlist list)
        {
            _playlists.Remove(list);
        }

        public void EmptyOneList(Playlist list)
       {
            Playlist foundList = _playlists.Find(pl => pl.Equals(list));
            if(foundList != null)
            {
                //foundList.EmptyList();
            }else
            {
                 throw new ArgumentNullException("Playlist is not found");
            }
       }
    }
