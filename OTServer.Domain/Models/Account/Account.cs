using System.Xml.Serialization;

namespace OTServer.Domain.Models.Account
{
	[XmlRoot(ElementName = "account")]
	public class Account
	{
		public Account()
		{
			Characters = new Characters();
		}
		public string AccountNumber { get; set; }
		[XmlElement(ElementName = "characters")]
		public Characters Characters { get; set; }
		[XmlAttribute(AttributeName = "pass")]
		public string Pass { get; set; }
		[XmlAttribute(AttributeName = "premDays")]
		public string PremDays { get; set; }
		[XmlAttribute(AttributeName = "premEnd")]
		public string PremEnd { get; set; }
		[XmlAttribute(AttributeName = "recoveryKey")]
		public string RecoveryKey { get; set; }
		[XmlAttribute(AttributeName = "visibleRk")]
		public bool VisibleRk { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Nome { get; set; }
		[XmlAttribute(AttributeName = "location")]
		public string Localizacao { get; set; }
		[XmlAttribute(AttributeName = "email")]
		public string Email { get; set; }
	}
}
