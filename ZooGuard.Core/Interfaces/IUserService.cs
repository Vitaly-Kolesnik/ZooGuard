using ZooGuard.Core.Entites;

namespace ZooGuard.Core.Interfaces
{
    public interface IUserService
    {
        int Add(User user);
        User Get(int id);
        User Get(string login);
    }
}
