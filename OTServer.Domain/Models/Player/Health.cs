using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "health")]
	public class Health
	{
		[XmlAttribute(AttributeName = "now")]
		public decimal Now { get; set; }
		[XmlAttribute(AttributeName = "max")]
		public decimal Max { get; set; }
		[XmlAttribute(AttributeName = "food")]
		public string Food { get; set; }
	}
}
