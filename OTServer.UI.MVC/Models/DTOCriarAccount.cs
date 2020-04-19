using ProtechSolution.Commum.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OTServer.UI.MVC.Models
{
    public class DTOCriarAccount
    {
		[DisplayName("Número da Account * ")]
		[StringLength(20, MinimumLength = 6)]
		[Required]
		[RegularExpression("[0-9]{6,20}", ErrorMessage = "Caracteres Invalidos para o login.")]
		public string AccountNumber { get; set; }
		[StringLength(20, MinimumLength = 6)]
		[DisplayName("Senha *")]
		[Required]
		[DataType(DataType.Password, ErrorMessage = "Caracteres Invalidos para o login.")]
		public string Pass { get; set; }
		[DisplayName("Nome *")]
		[Required]
		[DataType(DataType.Text, ErrorMessage = "Caracteres Invalidos para o Nome.")]
		public string Nome { get; set; }
		[DisplayName("Localização *")]
		[Required]
		[DataType(DataType.Text, ErrorMessage = "Caracteres Invalidos para o Nome.")]
		public string Localizacao { get; set; }
		[DisplayName("E-mail *")]
		[EmailAddress(
		 ErrorMessage = "E-mail invalido")]
		[Required]
		public string Email { get; set; }

		public bool Validar()
		{
			try
			{

				AssertionConcern.AssertArgumentNotEmpty(this.AccountNumber, "invalido");
				AssertionConcern.AssertArgumentLength(this.AccountNumber, 6, 20, "invalido");
				AssertionConcern.AssertArgumentMatches("[0-9]{6,20}", this.AccountNumber, "invalido");

				AssertionConcern.AssertArgumentNotEmpty(this.Pass, "invalido");
				AssertionConcern.AssertArgumentLength(this.Pass, 6, 20, "invalido");

				AssertionConcern.AssertArgumentNotEmpty(this.Nome, "invalido");
				AssertionConcern.AssertArgumentNotEmpty(this.Email, "invalido");
				AssertionConcern.AssertArgumentNotEmpty(this.Localizacao, "invalido");

				return true;
			}
			catch
			{
				return false;
			}
		}
	}


}
