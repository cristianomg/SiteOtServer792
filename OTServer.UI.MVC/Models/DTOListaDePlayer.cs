using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace OTServer.UI.MVC.Models
{
    public class DTOListaDePlayer
    {
        [DisplayName("Nome")]
		public string Name { get; set; }
        [DisplayName("Sexo")]
        public string Sex { get; set; }
        [DisplayName("Acesso")]
        public int Access { get; set; }
        [DisplayName("Level")]
        public int Level { get; set; }
        [DisplayName("Resets")]
        public int Resets { get; set; }
        [DisplayName("Ultimo Acesso")]
        public string Lastlogin { get; set; }
        [DisplayName("Vocação")]
        public string Voc { get; set; }


    }
}
