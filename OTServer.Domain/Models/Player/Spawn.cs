using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "spawn")]
	public class Spawn
	{
		[XmlAttribute(AttributeName = "x")]
		public string X { get; set; }
		[XmlAttribute(AttributeName = "y")]
		public string Y { get; set; }
		[XmlAttribute(AttributeName = "z")]
		public string Z { get; set; }
	}
}
