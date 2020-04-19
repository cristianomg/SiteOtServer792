using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OTServer.Domain.Models.Guild
{
    [XmlRoot(ElementName = "guilds")]
    public class Guilds
    {
        [XmlElement(ElementName = "guild")]
        public List<Guild> Guild { get; set; }
    }
}
