using System.Xml.Serialization;
using System.Collections.Generic;
namespace OTServer.Domain.Models.Guild
{
	[XmlRoot(ElementName = "guild")]
	public class Guild
	{
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlElement(ElementName = "member")]
		public List<Member> Member { get; set; }
	}
}
