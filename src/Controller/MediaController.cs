

namespace MediaPlayer.src.MediaPlayer;

    public class MediaController
    {
        private ImediaService _mediaService;

        public MediaController(ImediaService mediaservice)
        {
            _mediaService = mediaservice;
        }
         public void DeleteFileById(int id)
        {
            _mediaService.DeleteFileById(id);
        }

        public void GetAllFiles()
        {
            _mediaService.GetAllFiles();
        }
    }
