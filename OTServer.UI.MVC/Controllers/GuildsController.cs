using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OTServer.UI.MVC.Models;

namespace OTServer.UI.MVC.Controllers
{
    public class GuildsController : BaseController
    {
        public GuildsController(IMapper mapper) : base(mapper)
        {

        }
        public IActionResult Index()
        {
            var guilds = this.guilds.Guild;
            var dtoGuilds = new DTOGuilds();
            foreach(var guild in guilds)
            {
                var dtoGuild = new DTOGuild { Name = guild.Name, Member = new List<DTOMember>()};
                foreach(var member in guild.Member)
                {
                    var responseMember = this.players.FirstOrDefault(x => x.Name == member.Name);
                    if (responseMember != null)
                    {
                        var dtoMember = new DTOMember
                        {
                            Name = member.Name,
                            Rank = member.Rank,
                            Nick = !String.IsNullOrEmpty(member.Nick) ? member.Nick : "Sem Nick",
                            Status = member.Status,
                            Level = responseMember.Level,
                            Voc = responseMember.Voc,
                        };
                        dtoGuild.Member.Add(dtoMember);
                    }

                }
                if (dtoGuild.Member.Any())
                    dtoGuilds.Guild.Add(dtoGuild);
            }
            return View(dtoGuilds);
        }
    }
}