using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Domain.Contracts
{
    public interface IAppVersionService
    {
        string Version { get; }

        string Company { get; }

        string Product { get; }
    }
}
