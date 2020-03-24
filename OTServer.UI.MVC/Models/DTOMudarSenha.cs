using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OTServer.UI.MVC.Models
{
    public class DTOMudarSenha
    {
        [Required]
        [DisplayName("Senha Atual: ")]
        [DataType(DataType.Password, ErrorMessage = "Caracteres Invalidos para o login.")]
        public string SenhaAtual { get; set; }
        [Required]
        [DisplayName("Nova Senha: ")]
        [DataType(DataType.Password, ErrorMessage = "Caracteres Invalidos para o login.")]
        public string SenhaNova { get; set; }
        [DisplayName("Confirme a nova Senha: ")]
        [DataType(DataType.Password, ErrorMessage = "Caracteres Invalidos para o login.")]
        public string SenhaNovaConfirmacao { get; set; }
        [Required]
        [DisplayName("Recovery Key: ")]
        public string RecoveryKey { get; set; }
    }
}
