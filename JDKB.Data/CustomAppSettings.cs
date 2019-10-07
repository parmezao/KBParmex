using JDKB.Domain.Contracts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Data
{
    public class CustomAppSettings : ICustomAppSettings
    {
        private readonly IConfiguration _config;

        public CustomAppSettings(IConfiguration config)
        {
            _config = config;
        }

        public ICollection<KeyValuePair<string, string>> GetEmailCredentials()
        {
            ICollection<KeyValuePair<String, String>> credential = new Dictionary<String, String>();

            credential.Add(new KeyValuePair<string, string>("Email", _config["EmailCredential:Email"]));
            credential.Add(new KeyValuePair<string, string>("Password", _config["EmailCredential:Password"]));
            credential.Add(new KeyValuePair<string, string>("Host", _config["EmailCredential:Host"]));
            credential.Add(new KeyValuePair<string, string>("Port", _config["EmailCredential:Port"]));

            return credential;
        }

        public ICollection<KeyValuePair<string, string>> GetLogPath()
        {
            ICollection<KeyValuePair<String, String>> pathLog = new Dictionary<String, String>();

            pathLog.Add(new KeyValuePair<string, string>("Path", _config["LogPath:Path"]));

            return pathLog;
        }
    }
}
