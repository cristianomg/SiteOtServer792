using OTServer.Domain.Models.Guild;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace OTServer.Domain.Strategy
{
    public class GuildReader : IReader<Guilds>
    {
        public List<Guilds> ReaderFiles(string directory)
        {
            var serializer = new XmlSerializer(typeof(Guilds));
            var guilds = new Guilds();
            try
            {
                using (var textReader = new StreamReader(directory))
                {
                    guilds = (Guilds)serializer.Deserialize(textReader);
                }
                return new List<Guilds>{ guilds };
            }
            catch (Exception)
            {
            }
            return null;
        }
    }
}
