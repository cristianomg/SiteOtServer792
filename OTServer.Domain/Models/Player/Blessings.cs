using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "blessings")]
	public class Blessings
	{
		[XmlElement(ElementName = "blessing")]
		public Blessing Blessing { get; set; }
	}
}
