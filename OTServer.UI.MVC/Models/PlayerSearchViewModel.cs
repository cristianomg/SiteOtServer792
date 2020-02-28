using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Models;

namespace OTServer.UI.MVC.Models
{
    public class PlayerSearchViewModel
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
