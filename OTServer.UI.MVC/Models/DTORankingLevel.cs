using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OTServer.UI.MVC.Models
{
    public class DTORankingLevel
    {
        public int Id { get; set; }
        [Display(Name = "Nome", Description = "Nome")]
        public string Name { get; set; }
        [Display(Name = "Level", Description = "Level")]
        public int Level { get; set; }
        [Display(Name = "Resets", Description = "Resets")]
        public int Resets { get; set; }
        [Display(Name = "Vocs")]
        public string Voc { get; set; }
        [Display(Name = "Experience", Description = "Experience")]
        public string Exp { get; set; }
    }

}
