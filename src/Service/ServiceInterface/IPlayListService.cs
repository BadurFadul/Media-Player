using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaPlayer.src.MediaPlayer;
    public interface IPlayListService
    {
        void AddNewFile(int playListId, int fileId, int userId);
        bool RemoveFile(int playListId, int fileId, int userId);
        void EmptyList(int playListId, int userId);
    }
