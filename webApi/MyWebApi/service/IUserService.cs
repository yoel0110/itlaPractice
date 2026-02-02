using MyWebApi.model;

namespace MyWebApi.service
{
    public interface IUserService
    {
        void Save(User user);
        void Delete(User user);
        List<User> List();
    }
}
