
namespace MediaPlayer.src.MediaPlayer;

public class UserService : IUserService
{
    private IuserRepository _userRepository;

    public UserService(IuserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public void AddNewList(string name, int userId)
    {
        throw new NotImplementedException();
    }

    public bool EmptyOneList(int listId, int userId)
    {
        throw new NotImplementedException();
    }

    public void GetAllList(int userId)
    {
        throw new NotImplementedException();
    }

    public void GetListById(int listId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> RemoveAllLists(int userId)
    {
        throw new NotImplementedException();
    }

    public bool RemoveOneList(int listId, int userId)
    {
        throw new NotImplementedException();
    }
}
