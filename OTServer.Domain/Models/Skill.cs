using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
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
