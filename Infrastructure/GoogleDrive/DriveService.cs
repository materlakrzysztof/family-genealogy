using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.GoogleDrive
{
    public class GoogleDriveService
    {
        public DriveService GetService()
        {
            ClientSecrets clientSecrets = new ClientSecrets
            {
                ClientId = "ClientId", // <- change
                ClientSecret = "ClientSecret" // <- change
            };

            /* set where to save access token. The token stores the user's access and refresh tokens, and is created automatically when the authorization flow completes for the first time. */
            string tokenPath = "Token_save_location"; // <- change

            string[] scopes = { DriveService.Scope.Drive };

            UserCredential authorizedUserCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(
              clientSecrets,
              scopes,
              "user",
              CancellationToken.None,
              new FileDataStore(tokenPath, true)
            ).Result;

            DriveService service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = authorizedUserCredential,
                ApplicationName = "Name_of_your_application", // <- change
            });
            return service;
        }
    }
}
