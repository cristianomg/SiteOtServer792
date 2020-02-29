using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OTServer.UI.MVC.Models;
using Teste.Models;

namespace OTServer.UI.MVC.Controllers
{
    [ResponseCache(CacheProfileName = "Default30")]
    public class RankingController : BaseController
    {

        public RankingController(IMapper mapper) : base(mapper)
        {
        }
        [HttpGet]
        [Route("Level")]
        public IActionResult Index(int page=0)
        {
            
            ViewBag.page = page > 0 ? page : 0;

            var ordenado = players.OrderByDescending(x => x.Resets).ThenByDescending(x => x.Level).ThenByDescending(x => x.Exp).ThenBy(x => x.Name).Skip(page * 10).Take(10);
            var viewModel = _mapper.Map<List<DTORankingLevel>>(ordenado);
            return View(viewModel);
        }
        [HttpGet]
        [Route("Frags")]
        public IActionResult Frags(int page = 0)
        {
            ViewBag.page = page > 0 ? page : 0;
            var r = (from player in players
                     select new DTORankFrags
                     {
                         Id = player.Id,
                         Name = player.Name,
                         Kills = player.Storage.Data.Any(x => x.Key.Equals(7262)) ?
                         Convert.ToInt32(player.Storage.Data.Where(x => x.Key == 7262).First().Value) : 0,
                         Deaths = player.Storage.Data.Any(x => x.Key.Equals(6337)) ?
                         Convert.ToInt32(player.Storage.Data.Where(x => x.Key == 6337).First().Value) : 0,
                         Points = player.Storage.Data.Any(x => x.Key.Equals(5211)) ?
                         Convert.ToInt32(player.Storage.Data.Where(x => x.Key == 5211).First().Value) : 0
                     }).OrderByDescending(x=>x.Points).Skip(page*10).Take(10);
            return View(r);
        }
        
        [HttpGet]
        [Route("Magic")]
        public IActionResult Magic(int page = 0)
        {
            ViewBag.page = page > 0 ? page : 0;

            var result = (from player in players
                          select new DTORankMagic
                          {
                              Id = player.Id,
                              Name = player.Name,
                              Magic = player.Maglevel
                          }).OrderByDescending(x=>x.Magic).ThenBy(x=>x.Name).Skip(page*10).Take(10);

            return View(result);
        }

        [HttpGet]
        [Route("Skill")]
        public IActionResult Skill(int skill = 0, int page = 0)
        {
            ViewBag.page = page > 0 ? page : 0;
            string skillType = null;
            switch (skill)
            {
                case 0:
                    skillType = "Fist Fighting";
                    break;
                case 1:
                    skillType = "Club Fighting";
                    break;
                case 2:
                    skillType = "Sword Fighting";
                    break;
                case 3:
                    skillType = "Axe Fighting";
                    break;
                case 4:
                    skillType = "Distance Fighting";
                    break;
                case 5:
                    skillType = "Shielding";
                    break;
                default:
                    return Redirect("/ranking");
            }

            ViewBag.skillDs = skillType;
            ViewBag.skillId = skill;

            var result = (from player in players
                          select new DTORankSkill
                          {
                              Id = player.Id,
                              Name = player.Name,
                              Skill = player.Skills.Skill.Where(x => x.Skillid == skill).First().Level
                          }).OrderByDescending(x =>x.Skill).ThenBy(x => x.Name).Skip(page * 10).Take(10);

            return View(result);
        }

    }
}