using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "health")]
	public class Health
	{
		[XmlAttribute(AttributeName = "now")]
		public decimal Now { get; set; }
		[XmlAttribute(AttributeName = "max")]
		public decimal Max { get; set; }
		[XmlAttribute(AttributeName = "food")]
		public string Food { get; set; }
	}
}
