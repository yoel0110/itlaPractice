namespace MyWebApi.model
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public string password { get; set; }
    }

    public class UserDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
