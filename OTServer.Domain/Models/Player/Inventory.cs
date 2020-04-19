using System.Collections.Generic;
using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "inventory")]
	public class Inventory
	{
		[XmlElement(ElementName = "slot")]
		public List<Slot> Slot { get; set; }
	}	
}
