using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "skull")]
	public class Skull
	{
		[XmlAttribute(AttributeName = "redskulltime")]
		public string Redskulltime { get; set; }
		[XmlAttribute(AttributeName = "redskull")]
		public string Redskull { get; set; }
	}
}
