﻿using System.Xml.Serialization;

namespace OTServer.Domain.Models.Player
{
	[XmlRoot(ElementName = "item")]
	public class Item
	{
		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }
		[XmlElement(ElementName = "inside")]
		public Inside Inside { get; set; }
		[XmlAttribute(AttributeName = "text")]
		public string Text { get; set; }
		[XmlAttribute(AttributeName = "count")]
		public int Count { get; set; }
		[XmlAttribute(AttributeName = "charges")]
		public int Charges { get; set; }
	}
}
