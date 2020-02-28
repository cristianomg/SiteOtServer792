using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "item")]
	public class Item
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "inside")]
		public Inside Inside { get; set; }
		[XmlAttribute(AttributeName = "text")]
		public string Text { get; set; }
	}
}
