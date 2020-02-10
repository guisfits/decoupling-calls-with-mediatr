using MediatR;

namespace Application.Commands
{
    public class CreateUserCommand : IRequest
    {
        public string Name { get; set; }
    }
}
