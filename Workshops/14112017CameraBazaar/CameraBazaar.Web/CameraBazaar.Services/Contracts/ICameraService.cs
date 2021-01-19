namespace CameraBazaar.Services.Contracts
{
    using System.Collections.Generic;
    using CameraBazaar.Services.Models;

    public interface ICameraService
    {
        void AddCam(string userId, AddCameraModel addCameraModel);

        IEnumerable<CameraShortDetailsModel> GetCamerasDetailsForUser(string id);

        IEnumerable<CameraShortDetailsModel> GetAllCamerasDetails();

        bool CameraExists(int? id);

        CameraFullDetailsModel GetCameraFullDetails(int? id);

        bool UserCanEditCamera(string userId, int cameraId);

        EditCameraModel GetCameraCompleteEditInfromatio(int cameraId);

        void EditCamera(EditCameraModel editCameraModel);

        void DeleteCamera(int cameraId);

        bool UserIsBanned(string userId);
    }
}
