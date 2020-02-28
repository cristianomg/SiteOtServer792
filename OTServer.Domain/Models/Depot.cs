using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "depot")]
	public class Depot
	{
		[XmlElement(ElementName = "item")]
		public Item Item { get; set; }
		[XmlAttribute(AttributeName = "depotid")]
		public string Depotid { get; set; }
	}
}
