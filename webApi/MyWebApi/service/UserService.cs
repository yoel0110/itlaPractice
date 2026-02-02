using MyWebApi.model;

namespace MyWebApi.service
{
    public class UserService : IUserService
    {
        private List<User> users = new List<User>();
        public static int totalInstace;
        public UserService()
        {
            users.Add(new User { ID = totalInstace, LastName = "Jhon", Name = "Leet" });
            UserService.totalInstace++;
        }

        public void Save(User user)
        {
            users.Add(user);
        }

        public void Delete(User user)
        {
            users.Remove(user);
        }

        public List<User> List()
        {
            return users;
        }
    }
}
