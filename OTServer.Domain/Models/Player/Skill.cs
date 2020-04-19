using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "skill")]
	public class Skill
	{
		[XmlAttribute(AttributeName = "skillid")]
		public int Skillid { get; set; }
		[XmlAttribute(AttributeName = "level")]
		public int Level { get; set; }
		[XmlAttribute(AttributeName = "tries")]
		public long Tries { get; set; }
	}
}
