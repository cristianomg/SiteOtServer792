using System.Collections.Generic;
using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "storage")]
	public class Storage
	{
		[XmlElement(ElementName = "data")]
		public List<Data> Data { get; set; }
	}
}
