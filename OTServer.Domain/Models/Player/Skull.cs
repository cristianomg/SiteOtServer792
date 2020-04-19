using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{ 
	[XmlRoot(ElementName = "skull")]
	public class Skull
	{
		[XmlAttribute(AttributeName = "redskulltime")]
		public string Redskulltime { get; set; }
		[XmlAttribute(AttributeName = "redskull")]
		public string Redskull { get; set; }
	}
}
