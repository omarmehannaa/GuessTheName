using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public static class ConnectionInformation
    {
        public  static IPAddress IPAddress { get; } = IPAddress.Parse("127.0.0.1");
        public static int Port { get; } = 8080;

    }
}
