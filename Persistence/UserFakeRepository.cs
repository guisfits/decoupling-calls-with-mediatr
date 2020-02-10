using System.Threading.Tasks;
using Domain.Users.Entities;
using Domain.Users.Interfaces;

namespace Persistence
{
    public class UserFakeRepository : IUsers
    {
        public Task Add(User newUser)
        {
            return Task.CompletedTask;
        }
    }
}
