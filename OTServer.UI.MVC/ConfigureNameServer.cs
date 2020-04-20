using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OTServer.UI.MVC
{
    public class ConfigureNameServer
    {
        public string NameServer { get; set; }
        public ConfigureNameServer()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            NameServer = config.GetConnectionString("NomeDoServer");
        }
    }
}
