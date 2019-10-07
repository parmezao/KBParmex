using JDKB.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace JDKB.Data
{
    public class AppVersionService : IAppVersionService
    {
        public string Version =>
            Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;

        public string Company =>
            Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyCompanyAttribute>().Company;

        public string Product =>
            Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyProductAttribute>().Product;
    }
}
