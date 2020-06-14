using OTServer.Domain.Models.Player;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace OTServer.Domain.Strategy
{
    public class PlayerReader : IReader<Player>
    {
        public List<Player> ReaderFiles(string directory)
        {
            string[] arquivos = Directory.GetFiles(directory);
            var serializer = new XmlSerializer(typeof(Player));
            var player = new Player();
            List<Player> players = new List<Player>();
            int count = 1;
            foreach (var item in arquivos)
            {
                var localArquivo = item;
                try
                {
                    using (var textReader = new StreamReader(localArquivo))
                    {
                        player = (Player)serializer.Deserialize(textReader);
                        player.Id = count;
                        if (player.Deaths == null)
                            player.Deaths = new Deaths();
                    }
                    players.Add(player);
                    count++;
                }
                catch
                {
                    Console.WriteLine(localArquivo);
                }
            }
            return players;
        }
    }
}
