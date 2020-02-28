using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "data")]
	public class Data
	{
		[XmlAttribute(AttributeName = "key")]
		public long Key { get; set; }
		[XmlAttribute(AttributeName = "value")]
		public long Value { get; set; }
	}
}
