using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "slot")]
	public class Slot
	{
		[XmlElement(ElementName = "item")]
		public Item Item { get; set; }
		[XmlAttribute(AttributeName = "slotid")]
		public string Slotid { get; set; }
	}
}
