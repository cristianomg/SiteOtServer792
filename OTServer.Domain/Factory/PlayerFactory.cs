using OTServer.Domain.Models.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace OTServer.Domain.Factory
{
    public class PlayerFactory
    {
        public static Player NewPlayer(string account, string name, string voc, string sexo)
        {
            var player = new Player
            {
                Name = name,
                Account = account,
                Sex = sexo,
                Lookdir = "0",
                Exp = 4200,
                Voc = voc,
                Level = 8,
                Resets = 0,
                Access = 0,
                Cap = 470,
                Maglevel = 0,
                Soul = "250",
                Spawn = new Spawn { X = "121", Y = "311", Z = "7" },
                Temple = new Temple { X = "121", Y = "311", Z = "7" },
                Health = new Health { Now = 185, Max = 185, Food = "0" },
                Mana = new Mana { Now = 35, Max = 35, Spent = "0" },
                Look = new Look
                {
                    Type = "128",
                    Head = "78",
                    Body = "68",
                    Legs = "58",
                    Feet = "95",
                    Addons = "0"
                },
                Skills = new Skills
                {
                    Skill = new List<Skill>
                    {
                        new Skill{ Skillid = 0, Level = 10, Tries = 10},
                        new Skill{ Skillid = 1, Level = 10, Tries = 10},
                        new Skill{ Skillid = 2, Level = 10, Tries = 10},
                        new Skill{ Skillid = 3, Level = 10, Tries = 10},
                        new Skill{ Skillid = 4, Level = 10, Tries = 10},
                        new Skill{ Skillid = 5, Level = 10, Tries = 10},
                        new Skill{ Skillid = 6, Level = 10, Tries = 10},
                    }
                },
                Inventory = new Inventory
                {
                    Slot = new List<Slot>
                    {
                        new Slot { Slotid = "1", Item = new Item { Id = "5903" } },
                        new Slot { Slotid = "2", Item = new Item { Id = "5903" } },
                        new Slot
                        {
                            Slotid = "3",
                            Item = new Item
                            {
                                Id = "5903",
                                Inside = new Inside
                                {
                                    Item = new List<Item>
                                    {
                                        new Item { Id = "2120" },
                                        new Item { Id = "2554" },
                                        new Item { Id = "2160" },
                                        new Item { Id = "2120" },
                                        new Item { Id = "2120" },
                                    }
                                }
                            }
                        }
                    }
                },
            };
            return player;
        }
    }
}
