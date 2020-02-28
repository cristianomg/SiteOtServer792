using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OTServer.UI.MVC.Models;

namespace OTServer.UI.MVC.Controllers
{
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
        public IActionResult GetKillsPlayer(int id)
        {
            var player = players.Where(x => x.Id == id).FirstOrDefault();
            var playerDto = _mapper.Map<PlayerSearchViewModel>(player);
            return PartialView(playerDto);
        }
    }
}