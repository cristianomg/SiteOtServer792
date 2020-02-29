using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "account")]
	public class Account
	{
		public string AccountNumber { get; set; }
		[XmlElement(ElementName = "characters")]
		public Characters Characters { get; set; }
		[XmlAttribute(AttributeName = "pass")]
		public string Pass { get; set; }
		[XmlAttribute(AttributeName = "premDays")]
		public string PremDays { get; set; }
		[XmlAttribute(AttributeName = "premEnd")]
		public string PremEnd { get; set; }
	}
}
