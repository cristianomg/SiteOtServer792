using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OTServer.UI.MVC.Models;
using Teste.Models;

namespace OTServer.UI.MVC.Controllers
{
    [ResponseCache(CacheProfileName = "Default30")]
    public class PlayerController : BaseController
    {
        public PlayerController(IMapper mapper) : base(mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SearchById(int id)
        {
            var player = players.Where(x => x.Id == id).FirstOrDefault();
            var playerDto = _mapper.Map<PlayerSearchViewModel>(player);
            return PartialView(playerDto);
        }

        [HttpGet]
        public IActionResult GetKillsPlayer(int id, int page = 0)
        {
            ViewBag.page = page;
            var nomePlayer = players.Where(x=>x.Id == id).First().Name;
            List<KillsViewModel> kills = new List<KillsViewModel>();
            var listaMortes = (from player in players
                               select
                               new
                               {
                                   playerName = player.Name,
                                   mortes = player.Deaths.Death.Where(x => x.Name == nomePlayer).ToList()
                               })
            .Where(x => x.mortes.Any())
            .ToList();

            listaMortes.ForEach(x => x.mortes.ForEach(y => kills.Add( new KillsViewModel
            {
                Name = x.playerName,
                Level = y.Level,
                Time = y.Time
            })));

            kills = kills.OrderByDescending(x => x.Time).Skip(page*10).Take(10).ToList();
            return PartialView(kills);
        }
    }
}