using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "data")]
	public class Data
	{
		[XmlAttribute(AttributeName = "key")]
		public long Key { get; set; }
		[XmlAttribute(AttributeName = "value")]
		public long Value { get; set; }
	}
}
