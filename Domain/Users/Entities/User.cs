namespace Domain.Users.Entities
{
    public class User
    {
        public User(string name)
        {
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}
