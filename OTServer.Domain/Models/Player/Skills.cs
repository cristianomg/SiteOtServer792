using System.Collections.Generic;
using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "skills")]
	public class Skills
	{
		[XmlElement(ElementName = "skill")]
		public List<Skill> Skill { get; set; }
	}
}
