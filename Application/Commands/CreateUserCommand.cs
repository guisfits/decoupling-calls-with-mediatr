namespace Application.Commands
{
    public class CreateUserCommand
    {
        public CreateUserCommand(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
