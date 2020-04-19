using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTServer.UI.MVC.Models
{
    public class DTOGuild
    {
        public string Name { get; set; }
        public List<DTOMember> Member { get; set; }

    }
}
