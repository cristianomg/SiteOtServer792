using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "death")]
	public class Death
	{
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "level")]
		public int Level { get; set; }
		[XmlAttribute(AttributeName = "time")]
		public long Time { get; set; }
	}
}
