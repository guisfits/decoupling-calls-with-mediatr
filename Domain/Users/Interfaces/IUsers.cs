using System.Threading.Tasks;
using Domain.Users.Entities;

namespace Domain.Users.Interfaces
{
    public interface IUsers
    {
        Task Add(User newUser);
    }
}
