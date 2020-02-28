using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "inventory")]
	public class Inventory
	{
		[XmlElement(ElementName = "slot")]
		public List<Slot> Slot { get; set; }
	}	
}
