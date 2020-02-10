using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Commands;
using Domain.Users.Entities;
using Domain.Users.Interfaces;
using MediatR;

namespace Application.Handlers
{
    class UserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly IUsers _users;

        public UserCommandHandler(IUsers users)
        {
            _users = users;
        }

        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            Validate(request);

            var user = new User(request.Name);
            await _users.Add(user);

            return Unit.Value;
        }

        private void Validate(CreateUserCommand command)
        {
            if (string.IsNullOrEmpty(command.Name))
                throw new ArgumentException(nameof(command.Name));
        }
    }
}
