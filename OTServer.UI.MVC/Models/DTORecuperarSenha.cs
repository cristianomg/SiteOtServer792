using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OTServer.UI.MVC.Models
{
    public class DTORecuperarSenha
    {
        [DisplayName("Account")]
        public string AccountNumber { get; set; }
        public string Email { get; set; }
        public string RecoveryKey { get; set; }
    }
}
