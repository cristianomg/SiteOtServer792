using OTServer.UI.MVC.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OTServer.UI.MVC.Models
{
    public class DTOCriarPersonagem
    {
        [Required]
        [RegularExpression("^[A-Za-z]{5,20}")]
        [MinLength(5)]
        [MaxLength(20)]
        public string Nome { get; set; }
        [Required]
        [Range(0, 1)]
        public Sexo Sexo { get; set; }
        [Required]
        [Range(1, 4)]
        public Voc Voc { get; set; }

    }
}
