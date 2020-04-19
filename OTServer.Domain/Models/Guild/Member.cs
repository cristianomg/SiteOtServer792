using System;
using System.Xml.Serialization;

namespace OTServer.Domain.Models.Guild
{
	[XmlRoot(ElementName = "member")]
	public class Member
	{
		[XmlAttribute(AttributeName = "status")]
		public string Status { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "rank")]
		public string Rank { get; set; }
		[XmlAttribute(AttributeName = "nick")]
		public string Nick { get; set; }
	}
}
