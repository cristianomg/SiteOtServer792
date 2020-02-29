﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Teste.Models;

namespace OTServer.UI.MVC.Controllers
{
    public class BaseController : Controller
    {
        protected List<Player> players = new List<Player>();
        protected List<Account> accounts = new List<Account>();

        protected IMapper _mapper;

        public BaseController(IMapper mapper)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            _mapper = mapper;
            var diretorioPlayer = config.GetConnectionString("CaminhoPlayers");
            var diretorioAccounts = config.GetConnectionString("CaminhoAccounts");

            players = LerArquivosPlayer(diretorioPlayer);
            accounts = LerArquivosAccount(diretorioAccounts);
        }

        private List<Player> LerArquivosPlayer(string diretorio)
        {
            string[] arquivos = Directory.GetFiles(diretorio);
            var serializer = new XmlSerializer(typeof(Player));
            var player = new Player();
            List<Player> players = new List<Player>();
            int count = 1;
            foreach (var item in arquivos)
            {
                var localArquivo = item;
                try
                {
                    using (var textReader = new StreamReader(localArquivo))
                    {
                        player = (Player)serializer.Deserialize(textReader);
                        player.Id = count;
                    }
                    players.Add(player);
                    count++;
                }
                catch
                {
                    Console.WriteLine(localArquivo);
                }
            }
            return players;
        }

        private List<Account> LerArquivosAccount(string diretorio)
        {
            string[] arquivos = Directory.GetFiles(diretorio);
            var serializer = new XmlSerializer(typeof(Account));
            var account = new Account();
            List<Account> accounts = new List<Account>();
            int count = 1;
            foreach (var item in arquivos)
            {
                var localArquivo = item;
                try
                {
                    using (var textReader = new StreamReader(localArquivo))
                    {
                        account = (Account)serializer.Deserialize(textReader);
                        account.AccountNumber = item.Split("\\").Last().Split(".").First();
                    }
                    accounts.Add(account);
                    count++;
                }
                catch (Exception)
                {
                    Console.WriteLine(localArquivo);
                }
            }
            return accounts;
        }
    }
}