using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "depots")]
	public class Depots
	{
		[XmlElement(ElementName = "depot")]
		public List<Depot> Depot { get; set; }
	}
}
