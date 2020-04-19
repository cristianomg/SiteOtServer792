using System.Collections.Generic;
using System.Xml.Serialization;

namespace OTServer.Domain.Models.Account
{
	[XmlRoot(ElementName = "characters")]
	public class Characters
	{
		[XmlElement(ElementName = "character")]
		public List<Character> Character { get; set; }
	}
}
