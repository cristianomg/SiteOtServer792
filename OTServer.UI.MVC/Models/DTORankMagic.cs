﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OTServer.UI.MVC.Models
{
    public class DTORankMagic
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Name { get; set; }
        public int Magic { get; set; }
    }
}
