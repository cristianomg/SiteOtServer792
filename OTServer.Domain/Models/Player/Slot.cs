using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "slot")]
	public class Slot
	{
		[XmlElement(ElementName = "item")]
		public Item Item { get; set; }
		[XmlAttribute(AttributeName = "slotid")]
		public string Slotid { get; set; }
	}
}
