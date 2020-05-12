using OTServer.Domain.Models.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace OTServer.Domain.Factory
{
    public class PlayerFactory
    {
        public static Player NewPlayer(string account, string name, int voc, string sexo)
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
                        new Slot
                        {
                            Slotid = "1",
                            Item = new Item
                            {
                                Id = "5903"
                            }
                        },
                        new Slot
                        {
                            Slotid = "2",
                            Item = new Item
                            {
                                Id = "13682"
                            }
                        },
                        new Slot
                        {
                            Slotid = "3",
                            Item = new Item
                            {
                                Id = "1988",
                                Inside = new Inside
                                {
                                    Item = new List<Item>
                                    {
                                        new Item
                                        {
                                            Id = "2120"
                                        },
                                        new Item
                                        {
                                            Id = "2554"
                                        },
                                        new Item
                                        {
                                            Id = "2160",
                                            Count = 5,
                                        },
                                        new Item
                                        {
                                            Id = "5927",
                                            Inside =  new Inside
                                            {
                                                Item = new List<Item>
                                                {
                                                    new Item
                                                    {
                                                        Id = "2273",
                                                        Count = 1,
                                                        Charges = 1
                                                    },
                                                    new Item
                                                    {
                                                        Id = "2268",
                                                        Count = 1,
                                                        Charges = 1,
                                                    },
                                                    new Item
                                                    {
                                                        Id = "2293",
                                                        Count = 1,
                                                        Charges = 1,
                                                    },
                                                    new Item
                                                    {
                                                        Id = "2313",
                                                        Count = 1,
                                                        Charges = 1
                                                    },
                                                    new Item
                                                    {
                                                        Id = "2305",
                                                        Count = 1,
                                                        Charges = 1
                                                    }
                                                }
                                            }
                                        },
                                        new Item
                                        {
                                            Id = "2352",
                                        },
                                        new Item
                                        {
                                            Id = "2455"
                                        },
                                        new Item
                                        {
                                            Id = "13537"
                                        },
                                        new Item
                                        {
                                            Id = "6568"
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
                                Id = "2508"
                            }
                        },
                        new Slot
                        {
                            Slotid = "5",
                            Item = new Item
                            {
                                Id = "2542"
                            } 
                        },
                        new Slot
                        {
                            Slotid = "6",
                            Item = new Item
                            {
                                Id = "2453"
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
                                Id = "6132"
                            }
                        },
                        new Slot
                        {
                            Slotid = "10",
                            Item = new Item
                            {
                                Id = "2361"
                            }
                        }
                    }
                },
                Storage = new Storage
                {
                    Data = new List<Data>
                    {
                        new Data
                        {
                            Key=9893,
                            Value= 1587925899
                        },
                        new Data
                        {
                           Key=80023,
                           Value=5
                        },
                        new Data
                        {
                            Key=100500,
                            Value= 5
                        },
                        new Data
                        {
                            Key=200380,
                            Value= 5
                        },
                        new Data
                        {
                            Key=200400,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500500,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500510,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500520,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500530,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500540,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500550,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500560,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500570,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500580,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500590,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500600,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500610,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500620,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500630,
                            Value= 5
                        },
                        new Data
                        {
                            Key=500640,
                            Value= 5
                        },
                        new Data
                        {
                            Key=600600,
                            Value= 5
                        },
                        new Data
                        {
                            Key=600610,
                            Value= 5
                        },
                        new Data
                        {
                            Key=600620,
                            Value= 5
                        },
                        new Data
                        {
                            Key=600630,
                            Value= 5
                        },
                        new Data
                        {
                            Key=600640,
                            Value= 5
                        },
                        new Data
                        {
                            Key=600650,
                            Value= 5
                        },
                        new Data
                        {
                            Key=600660,
                            Value= 5
                        },
                        new Data
                        {
                            Key=600670,
                            Value= 5
                        },
                        new Data
                        {
                            Key=600680,
                            Value= 5
                        },
                        new Data
                        {
                            Key=600690,
                            Value= 5
                        },
                        new Data
                        {
                            Key=600700,
                            Value= 5
                        },
                        new Data
                        {
                            Key=600710,
                            Value= 5
                        },
                        new Data
                        {
                            Key=600720,
                            Value= 5
                        },
                        new Data
                        {
                            Key=600730,
                            Value= 5
                        },
                        new Data
                        {
                            Key=700500,
                            Value= 5
                        },
                        new Data
                        {
                            Key=700510,
                            Value= 5
                        },
                        new Data
                        {
                            Key=700520,
                            Value= 5
                        },
                        new Data
                        {
                            Key=700530,
                            Value= 5
                        },
                        new Data
                        {
                            Key=700540,
                            Value= 5
                        },
                        new Data
                        {
                            Key=700550,
                            Value= 5
                        },
                        new Data
                        {
                            Key=700560,
                            Value= 5
                        },
                        new Data
                        {
                            Key=700570,
                            Value= 5
                        },
                        new Data
                        {
                            Key=700580,
                            Value= 5
                        },
                        new Data
                        {
                            Key=700590,
                            Value= 5
                        },
                        new Data
                        {
                            Key=700600,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800500,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800510,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800520,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800530,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800540,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800550,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800560,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800570,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800580,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800586,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800590,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800600,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800620,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800630,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800640,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800650,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800660,
                            Value= 5
                        },
                        new Data
                        {
                            Key=800670,
                            Value= 5
                        },
                        new Data
                        {
                            Key=888888,
                            Value= 5
                        },
                        new Data
                        {
                            Key=10001001,
                            Value= 8912896
                        },
                        new Data
                        {
                            Key=10001002,
                            Value= 8978432
                        },
                        new Data
                        {
                            Key=10001003,
                            Value= 9043968
                        },
                        new Data
                        {
                            Key=10001004,
                            Value= 9175040
                        },
                        new Data
                        {
                            Key=10001005,
                            Value= 9240576
                        },
                        new Data
                        {
                            Key=10001006,
                            Value= 9306112
                        },
                        new Data
                        {
                            Key=10001007,
                            Value= 9633792
                        },
                        new Data
                        {
                            Key=10001008,
                            Value= 9699328
                        },
                        new Data
                        {
                            Key=10001009,
                            Value= 9764864
                        },
                        new Data
                        {
                            Key=10001010,
                            Value= 10158080
                        },
                        new Data
                        {
                            Key=10001011,
                            Value= 10223616
                        },
                        new Data
                        {
                            Key=10001012,
                            Value= 10289152
                        },
                        new Data
                        {
                            Key=10001013,
                            Value= 8585216
                        },
                        new Data
                        {
                            Key=10001014,
                            Value= 9568256
                        },
                        new Data
                        {
                            Key=10001015,
                            Value= 10092544
                        },
                        new Data
                        {
                            Key=10001016,
                            Value= 15007744
                        },
                        new Data
                        {
                            Key=10001017,
                            Value= 27394048
                        },
                        new Data
                        {
                            Key=10001018,
                            Value= 14811136
                        },
                        new Data
                        {
                            Key=10001019,
                            Value= 21561344
                        },
                        new Data
                        {
                            Key=10001020,
                            Value= 20840448
                        },
                        new Data
                        {
                            Key=10001021,
                            Value= 24248320
                        },
                        new Data
                        {
                            Key=10001022,
                            Value= 20774912
                        },
                    }
                }

            };
            return player;
        }
    }
}
