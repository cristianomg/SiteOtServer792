using OTServer.Domain.Models.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace OTServer.Domain.Factory
{
    public interface IPlayerFactory
    {
        Player NewPlayer(string account, string name, int voc, string sexo);
    }
}
