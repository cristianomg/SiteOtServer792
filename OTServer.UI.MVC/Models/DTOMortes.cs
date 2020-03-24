using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OTServer.UI.MVC.Models
{
    public class DTOMortes
    {
        [DisplayName("Personagem:")]
        public string Player { get; set; }
        public int Level { get; set; }
        public long Time { get; set; }
        public string PlayerQueMatou { get; set; }
    }
}
