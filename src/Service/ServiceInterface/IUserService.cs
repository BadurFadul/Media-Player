using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaPlayer.src.MediaPlayer;
    public interface IUserService
    {
        void AddNewList(string name, int userId);
        bool RemoveOneList(int listId, int userId);
        IEnumerable<User> RemoveAllLists(int userId);
        bool EmptyOneList(int listId, int userId);
        void GetAllList(int userId);
        void GetListById(int listId);
    }
