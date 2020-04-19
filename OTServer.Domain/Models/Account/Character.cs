using System.Xml.Serialization;

namespace OTServer.Domain.Models.Account
{
	[XmlRoot(ElementName = "character")]
	public class Character
	{
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}
}
