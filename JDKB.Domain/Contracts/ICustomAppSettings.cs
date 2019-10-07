using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Domain.Contracts
{
    public interface ICustomAppSettings
    {
        ICollection<KeyValuePair<string, string>> GetEmailCredentials();

        ICollection<KeyValuePair<string, string>> GetLogPath();
    }
}
