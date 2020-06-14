using OTServer.Domain.Models.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace OTServer.Domain.Factory
{
    public class BasicPlayerFactory : IPlayerFactory
    {
        public Player NewPlayer(string account, string name, int voc, string sexo)
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
                Spawn = new Spawn { X = "1030", Y = "999", Z = "7" },
                Temple = new Temple { X = "1030", Y = "999", Z = "7" },
                Health = new Health { Now = 185, Max = 185, Food = "0" },
                Mana = new Mana { Now = 35, Max = 35, Spent = "0" },
                Look = new Look
                {
                    Type = "144",
                    Head = "114",
                    Body = "119",
                    Legs = "94",
                    Feet = "79",
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
                        new Slot
                        {
                            Slotid = "1",
                            Item = new Item
                            {
                                Id = "2460"
                            }
                        },
                        new Slot
                        {
                            Slotid = "2",
                            Item = new Item
                            {
                                Id = "13682",
                            }
                        },
                        new Slot
                        {
                            Slotid = "3",
                            Item = new Item
                            {
                                Id = "3940",
                                Inside = new Inside
                                {
                                    Item = new List<Item>
                                    {
                                        new Item
                                        {
                                            Id = "2273"
                                        },
                                        new Item
                                        {
                                            Id = "2294"
                                        },
                                        new Item
                                        {
                                            Id = "2268"
                                        },
                                        new Item
                                        {
                                            Id = "2313"
                                        },
                                        new Item
                                        {
                                            Id = "2666"
                                        },
                                        new Item
                                        {
                                            Id = "13682"
                                        },
                                        new Item
                                        {
                                            Id = "13682"
                                        }
                                    }
                                }
                            }
                        },
                        new Slot
                        {
                            Slotid = "4",
                            Item = new Item
                            {
                                Id = "2465",
                            }
                        },
                        new Slot
                        {
                            Slotid = "5",
                            Item = new Item
                            {
                                Id = "2511"
                            }
                        },
                        new Slot
                        {
                            Slotid = "6",
                            Item = new Item
                            {
                                Id = "2183"
                            }
                        },
                        new Slot
                        {
                            Slotid = "7",
                            Item = new Item
                            {
                                Id = "2647"
                            }
                        },
                        new Slot
                        {
                            Slotid = "8",
                            Item = new Item
                            {
                                Id = "2642"
                            }
                        },
                        new Slot
                        {
                            Slotid = "10",
                            Item = new Item
                            {
                                Id = "2120"
                            }
                        }
                    }
                },
                Depots = new Depots
                {
                    Depot = new List<Depot> 
                    { 
                        new Depot
                        {
                            Depotid = "1",
                            Item = new Item 
                            {
                                Id = "2590",
                                Inside = new Inside
                                {
                                    Item = new List<Item>
                                    {
                                        new Item
                                        {
                                            Id = "2594"
                                        },
                                        new Item
                                        {
                                            Id ="2667",
                                            Count = 100
                                        },
                                        new Item
                                        {
                                            Id = "2667",
                                            Count = 100
                                        }
                                    }
                                }
                            }
                            
                        }
                    }
                }
               
            };
            return player;
        }
    }
}
