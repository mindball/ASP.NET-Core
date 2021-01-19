namespace CameraBazaar.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using CameraBazaar.Services.Models;

    public interface IUserService
    {
        UserDetailsModel GetUserProfile(string id);

        bool UserExistsById(string id);

        bool UserExistsByUsername(string username);

        EditProfileModel GetProfileEditInfo(string id);

        void EditProfile(EditProfileModel editProfileModel);

        void SaveLoginDate(string username, DateTime logginTime);

        IEnumerable<UserSellerStatusModel> GetAllUsersInfo();

        void ChangeStatus(string username);
    }
}
