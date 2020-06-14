using OTServer.Domain.Models.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace OTServer.Domain.Factory
{
    public class PlayerFactory
    {
        public static Player GetNewPlayer(PlayerType type, string account, string name, int voc, string sexo)
        {
            switch (type)
            {
                case PlayerType.basicPlayer:
                    return new BasicPlayerFactory().NewPlayer(account, name, voc, sexo);
                default:
                    return null;
            }
        }
    }
}
