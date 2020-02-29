using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Teste.Models;

namespace OTServer.UI.MVC.Models
{
    public class DTOPainelAccount
    {
        public string AccountNumber { get; set; }
        [DisplayName("Sua RecoveryKey: ")]
        public string RecoveryKey { get; set; }
        [DisplayName("Senha: ")]
        public string Pass { get; set; }
        [DisplayName("Dias Restantes: ")]
        public string PremDays { get; set; }
        [DisplayName("Personagens: ")]
        public Characters Characters { get; set; }
        public string Nome { get; set; }
        public string Localização { get; set; }
        public string Email { get; set; }

    }
}
