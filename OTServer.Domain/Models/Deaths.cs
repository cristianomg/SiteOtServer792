using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "deaths")]
	public class Deaths
	{
		[XmlElement(ElementName = "death")]
		public List<Death> Death { get; set; }
	}
}
