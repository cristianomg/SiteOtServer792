using OTServer.Domain.Models.Player;

namespace OTServer.UI.MVC.Models
{
    public class DTOPlayerSearch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Resets { get; set; }
        public string Voc { get; set; }
        public long Exp { get; set; }
        public Deaths Deaths { get; set; }
        public Health Health { get; set; }
        public Mana Mana { get; set; }
    }
}
