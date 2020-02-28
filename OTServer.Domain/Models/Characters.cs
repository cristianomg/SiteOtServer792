using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "characters")]
	public class Characters
	{
		[XmlElement(ElementName = "character")]
		public List<Character> Character { get; set; }
	}
}
