using System.Collections.Generic;
using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "deaths")]
	public class Deaths
	{
		public Deaths()
		{
			Death = new List<Death>();
		}
		[XmlElement(ElementName = "death")]
		public List<Death> Death { get; set; }
	}
}
