using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "storage")]
	public class Storage
	{
		[XmlElement(ElementName = "data")]
		public List<Data> Data { get; set; }
	}
}
