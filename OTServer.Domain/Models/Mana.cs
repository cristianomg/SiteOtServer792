using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "mana")]
	public class Mana
	{
		[XmlAttribute(AttributeName = "now")]
		public decimal Now { get; set; }
		[XmlAttribute(AttributeName = "max")]
		public decimal Max { get; set; }
		[XmlAttribute(AttributeName = "spent")]
		public string Spent { get; set; }
	}
}
