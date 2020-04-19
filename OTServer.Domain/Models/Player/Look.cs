using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{ 
	[XmlRoot(ElementName = "look")]
	public class Look
	{
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName = "head")]
		public string Head { get; set; }
		[XmlAttribute(AttributeName = "body")]
		public string Body { get; set; }
		[XmlAttribute(AttributeName = "legs")]
		public string Legs { get; set; }
		[XmlAttribute(AttributeName = "feet")]
		public string Feet { get; set; }
		[XmlAttribute(AttributeName = "addons")]
		public string Addons { get; set; }
	}
}
