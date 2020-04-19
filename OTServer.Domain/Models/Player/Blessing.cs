using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "blessing")]
	public class Blessing
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
	}
}
