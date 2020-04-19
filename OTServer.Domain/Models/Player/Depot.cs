using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "depot")]
	public class Depot
	{
		[XmlElement(ElementName = "item")]
		public Item Item { get; set; }
		[XmlAttribute(AttributeName = "depotid")]
		public string Depotid { get; set; }
	}
}
