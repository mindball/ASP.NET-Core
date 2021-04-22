using LearningSystem.Services.Users.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningSystem.Services.Users
{
    public interface IUsersService
    {
        Task<UserProfileServiceModel> ProfileAsync(string userId);

        Task<IEnumerable<UserListingServiceModel>> FindUsersAsync(string searchText);

        public  Task<byte[]> GetPdfCertificate(string courseId, string userId);
    }
}
