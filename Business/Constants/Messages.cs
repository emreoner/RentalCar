using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car Added";
        public static string CarNameInvalid = "Car Name is Invalid";
        public static string CarsListed = "Cars Listed";

        public static string CarImageMaxCountReached = "Max Car Image Count Reached";
        public static string CarImageAdded = "Car Image Added";

        public static string CarImageUploadError = "Car Image Upload Error";

        public static string CarImageUpdated = "Car Image Updated";
        public static string CarImageDeleted = "Car Image Deleted";

        public static string CarDefaulImageListed = "Car Default Image Listed";

        public static string UserNotFound = "User Not Found";

        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Successful Login";
        public static string UserAlreadyExists = "User Already Exists";
        public static string UserRegistered = "User Registered";
        public static string AccessTokenCreated = "Access Token Created";
        public static string AuthorizationDenied = "Authorization Denied";
    }
}
