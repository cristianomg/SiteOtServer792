using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OTServer.UI.MVC.Models
{
    public class DTORankFrags
    {
        public int Id { get; set; }
        [Display(Name="Nome")]
        public string Name { get; set; }
        [Display(Name = "Kills")]
        public long Kills { get; set; }
        [Display(Name = "Deaths")]
        public long Deaths { get; set; }
        [Display(Name = "Pontos")]
        public long Points { get; set; }

    }
}
