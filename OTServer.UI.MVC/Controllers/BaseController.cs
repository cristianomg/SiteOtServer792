using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OTServer.Domain.Models.Account;
using OTServer.Domain.Models.Guild;
using OTServer.Domain.Models.Player;

namespace OTServer.UI.MVC.Controllers
{
    public class BaseController : Controller
    {
        protected List<Player> players = new List<Player>();
        protected List<Account> accounts = new List<Account>();
        protected Guilds guilds;

        protected IMapper _mapper;
        private readonly string diretorioPlayer;
        private readonly string diretorioAccounts;
        private readonly string diretorioGuilds;

        public BaseController(IMapper mapper)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            _mapper = mapper;
            diretorioPlayer = config.GetConnectionString("CaminhoPlayers");
            diretorioAccounts = config.GetConnectionString("CaminhoAccounts");
            diretorioGuilds = config.GetConnectionString("CaminhoGuilds");

            players = LerArquivosPlayer(this.diretorioPlayer);
            accounts = LerArquivosAccount(this.diretorioAccounts);
            guilds = LerArquivosGuilds(this.diretorioGuilds);

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
                        if (player.Deaths == null)
                            player.Deaths = new Deaths();
                    }
                    players.Add(player);
                    count++;
                }
                catch(Exception e)
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
                catch (Exception e)
                {
                    Console.WriteLine(localArquivo);
                }
            }
            return accounts;
        }
        private Guilds LerArquivosGuilds(string diretorio)
        {
            var serializer = new XmlSerializer(typeof(Guilds));
            var guilds = new Guilds();
                try
                {
                    using(var textReader = new StreamReader(diretorio))
                    {
                        guilds = (Guilds)serializer.Deserialize(textReader);
                    }
                }
                catch (Exception)
                {
                }
            return guilds;
        }
        protected bool AtualizarAccount(Account account)
        {
            var arquivo = $"{this.diretorioAccounts}\\{account.AccountNumber}.xml";
            try
            {
                if (System.IO.File.Exists(arquivo))
                {
                    Console.WriteLine("tEste");
                    System.IO.File.Delete(arquivo);
                }
                System.Xml.Serialization.XmlSerializer serializer = new XmlSerializer(typeof(Account));
                TextWriter writer = new StreamWriter(arquivo);
                serializer.Serialize(writer, account);
                writer.Close();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        protected bool CriarAccount(Account account)
        {
            try
            {
                var arquivo = $"{this.diretorioAccounts}\\{account.AccountNumber}.xml";
                if (System.IO.File.Exists(arquivo))
                {
                    return false;
                }
                System.Xml.Serialization.XmlSerializer serializer = new XmlSerializer(typeof(Account));
                TextWriter writer = new StreamWriter(arquivo);
                serializer.Serialize(writer, account);
                writer.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}