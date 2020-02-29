using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Models;

namespace OTServer.UI.MVC.Models
{
    public class DTOPainelAccount
    {
        public string AccountNumber { get; set; }
        public string RecoveryKey { get; set; }
        public string Pass { get; set; }
        public string PremDays { get; set; }
        public Characters Characters { get; set; }
    }
}
