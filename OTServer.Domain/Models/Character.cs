using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "character")]
	public class Character
	{
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
	}
}
