using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OTServer.Domain.Models.Player;
using OTServer.UI.MVC.Models;

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
            var playerDto = _mapper.Map<DTOPlayerSearch>(player);
            return PartialView(playerDto);
        }

        [HttpGet]
        public IActionResult GetKillsPlayer(int id, int page = 0)
        {
            ViewBag.page = page;
            var nomePlayer = players.Where(x => x.Id == id).First().Name;
            List<DTOKills> kills = new List<DTOKills>();
            var listaMortes = (from player in players
                               where player.Deaths.Death.Any()
                               select
                               new
                               {
                                   playerName = player.Name,
                                   mortes = player.Deaths.Death.Where(x => x.Name == nomePlayer).ToList()
                               })
            .Where(x => x.mortes.Any())
            .ToList();

            listaMortes.ForEach(x => x.mortes.ForEach(y => kills.Add(new DTOKills
            {
                Name = x.playerName,
                Level = y.Level,
                Time = y.Time
            })));

            kills = kills.OrderByDescending(x => x.Time).Skip(page * 10).Take(10).ToList();
            return PartialView(kills);
        }
        [HttpGet]
        public IActionResult SearchByName(string name)
        {
            try
            {
                if (!String.IsNullOrEmpty(name))
                {
                    var player = players.Where(x => x.Name.ToLower() == name.ToLower()).FirstOrDefault();
                    if (player == null)
                    {
                        return BadRequest();
                    }
                    var playerDto = _mapper.Map<DTOPlayerSearch>(player);
                    return PartialView("SearchById", playerDto);
                }
                return BadRequest();
            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpGet]
        [Route("ListaMortes")]
        public IActionResult ListarMortes(int page)
        {
            try
            {
                ViewBag.page = page;
                var varListaMortes = (from player in players
                                      where player.Deaths.Death.Any()
                                      select new
                                      {
                                          mortes = player.Deaths.Death,
                                          playerMorto = player
                                      }).ToList();

                List<DTOMortes> listaMortes = new List<DTOMortes>();
                varListaMortes.ForEach(x => x.mortes.ForEach(y => listaMortes.Add(new DTOMortes
                {
                    Player = x.playerMorto.Name,
                    Level = y.Level,
                    Time = y.Time,
                    PlayerQueMatou = y.Name

                })));

                listaMortes = listaMortes.OrderByDescending(x => x.Time).Skip(page * 10).Take(10).ToList();

                return View(listaMortes);
            }
            catch
            {
                return View(new List<DTOMortes>());

            }
        }

        [HttpGet]
        [Route("ListaPlayersOnline")]
        public IActionResult ListaPlayersOnline(int page)
        {
            try
            {
                ViewBag.page = page > 0 ? page : 0;

                var playersPaginado = playersOnline.Where(x=>x.Access < 3).Skip(page * 10).Take(10);

                var viewModel = _mapper.Map<List<DTORankingLevel>>(playersPaginado);

                return View(viewModel);
            }
            catch
            {
                return View(new List<DTOMortes>());

            }
        }


    }
}