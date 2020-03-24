using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OTServer.UI.MVC.Models
{
    public class DTODeletarPersonagem
    {
        [Required]
        public string Senha { get; set; }
        [Required]
        public string RecoveryKey { get; set; }
    }
}
