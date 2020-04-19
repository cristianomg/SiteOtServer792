using System.Collections.Generic;
using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "depots")]
	public class Depots
	{
		[XmlElement(ElementName = "depot")]
		public List<Depot> Depot { get; set; }
	}
}
