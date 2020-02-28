using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "deaths")]
	public class Deaths
	{
		public Deaths()
		{
			List<Death> Death = new List<Death>();
		}
		[XmlElement(ElementName = "death")]
		public List<Death> Death { get; set; }
	}
}
