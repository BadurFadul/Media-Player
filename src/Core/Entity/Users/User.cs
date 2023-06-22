using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaPlayer.src.MediaPlayer;

    public class User
    {
        private int _userId;

        public int UserId {get {return _userId;}}
        public string UserFirstName {get; set;} = String.Empty;
        public string UserLastName {get; set;} = String.Empty;

        public User(int userid, string userfirstname, string userlastname)
        {
            _userId = userid;
            UserFirstName = userfirstname;
            UserLastName = userlastname;
        }
    }
