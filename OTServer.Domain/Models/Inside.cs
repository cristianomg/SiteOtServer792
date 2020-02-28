using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "inside")]
	public class Inside
	{
		[XmlElement(ElementName = "item")]
		public List<Item> Item { get; set; }
	}
}
