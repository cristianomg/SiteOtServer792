using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "skills")]
	public class Skills
	{
		[XmlElement(ElementName = "skill")]
		public List<Skill> Skill { get; set; }
	}
}
