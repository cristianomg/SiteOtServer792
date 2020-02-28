using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Teste.Models
{
	[XmlRoot(ElementName = "player")]
	public class Player
	{
		public int Id { get; set; }
		[XmlElement(ElementName = "spawn")]
		public Spawn Spawn { get; set; }
		[XmlElement(ElementName = "temple")]
		public Temple Temple { get; set; }
		[XmlElement(ElementName = "health")]
		public Health Health { get; set; }
		[XmlElement(ElementName = "mana")]
		public Mana Mana { get; set; }
		[XmlElement(ElementName = "skull")]
		public Skull Skull { get; set; }
		[XmlElement(ElementName = "look")]
		public Look Look { get; set; }
		[XmlElement(ElementName = "skills")]
		public Skills Skills { get; set; }
		[XmlElement(ElementName = "addons")]
		public string Addons { get; set; }
		[XmlElement(ElementName = "deaths")]
		public Deaths Deaths { get; set; }
		[XmlElement(ElementName = "spells")]
		public string Spells { get; set; }
		[XmlElement(ElementName = "blessings")]
		public string Blessings { get; set; }
		[XmlElement(ElementName = "inventory")]
		public Inventory Inventory { get; set; }
		[XmlElement(ElementName = "depots")]
		public Depots Depots { get; set; }
		[XmlElement(ElementName = "storage")]
		public Storage Storage { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "account")]
		public string Account { get; set; }
		[XmlAttribute(AttributeName = "sex")]
		public string Sex { get; set; }
		[XmlAttribute(AttributeName = "lookdir")]
		public string Lookdir { get; set; }
		[XmlAttribute(AttributeName = "exp")]
		public int Exp { get; set; }
		[XmlAttribute(AttributeName = "voc")]
		public string Voc { get; set; }
		[XmlAttribute(AttributeName = "level")]
		public int Level { get; set; }
		[XmlAttribute(AttributeName = "access")]
		public int Access { get; set; }
		[XmlAttribute(AttributeName = "resets")]
		public int Resets { get; set; }
		[XmlAttribute(AttributeName = "cap")]
		public long Cap { get; set; }
		[XmlAttribute(AttributeName = "maglevel")]
		public int Maglevel { get; set; }
		[XmlAttribute(AttributeName = "soul")]
		public string Soul { get; set; }
		[XmlAttribute(AttributeName = "maxdepotitems")]
		public string Maxdepotitems { get; set; }
		[XmlAttribute(AttributeName = "lastlogin")]
		public string Lastlogin { get; set; }
	}
}
