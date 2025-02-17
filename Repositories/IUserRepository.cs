using Latiendita.Models;

namespace Latiendita.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(int id);
        Task<IEnumerable<User>> GetUsersAsync();
        Task AddUserAsync(User user);
        Task UpdateUserAsync(int id, User user);
        Task DeleteUserAsync(int id);
    }
}
