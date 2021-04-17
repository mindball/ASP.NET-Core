using LearningSystem.Services.Users.Models;
using System.Threading.Tasks;

namespace LearningSystem.Services.Users
{
    public interface IUsersService
    {
        Task<UserProfileServiceModel> ProfileAsync(string userId);
    }
}
