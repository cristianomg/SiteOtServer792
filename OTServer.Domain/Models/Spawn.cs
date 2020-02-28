using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "spawn")]
	public class Spawn
	{
		[XmlAttribute(AttributeName = "x")]
		public string X { get; set; }
		[XmlAttribute(AttributeName = "y")]
		public string Y { get; set; }
		[XmlAttribute(AttributeName = "z")]
		public string Z { get; set; }
	}
}
