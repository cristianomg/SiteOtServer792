using System.Collections.Generic;
using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "inside")]
	public class Inside
	{
		[XmlElement(ElementName = "item")]
		public List<Item> Item { get; set; }
	}
}
