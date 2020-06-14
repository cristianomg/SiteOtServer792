using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OTServer.UI.MVC.Controllers
{
    public class DownloadController : Controller
    {
        public IActionResult Index()
        {
            string file = @"~/Ilusion Install v1.exe";
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            return File(file, contentType, Path.GetFileName(file));
        }
    }
}