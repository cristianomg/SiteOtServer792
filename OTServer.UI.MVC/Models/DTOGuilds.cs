using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTServer.UI.MVC.Models
{
    public class DTOGuilds
    {
        public DTOGuilds()
        {
            Guild = new List<DTOGuild>();
        }
        public List<DTOGuild> Guild { get; set; }

    }
}
