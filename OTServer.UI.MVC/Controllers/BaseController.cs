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
using OTServer.Domain.Strategy;

namespace OTServer.UI.MVC.Controllers
{
    public class BaseController : Controller
    {
        protected List<Player> players = new List<Player>();
        protected List<Account> accounts = new List<Account>();
        protected Guilds guilds;
        protected List<Player> playersOnline = new List<Player>();

        protected IMapper _mapper;
        private readonly string diretorioPlayer;
        private readonly string diretorioAccounts;
        private readonly string diretorioGuilds;
        private readonly string diretorioPlayersOnline;

        protected const string SessionAccount = "_Account";
        protected const string SessionPassoword = "_Pass";
        protected const string SessionIsLoginValid = "_IsLoginValid";

        public BaseController(IMapper mapper)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            _mapper = mapper;
            diretorioPlayer = config.GetConnectionString("CaminhoPlayers");
            diretorioAccounts = config.GetConnectionString("CaminhoAccounts");
            diretorioGuilds = config.GetConnectionString("CaminhoGuilds");
            diretorioPlayersOnline = config.GetConnectionString("CaminhoOnlineList");

            players = new PlayerReader().ReaderFiles(this.diretorioPlayer);
            accounts = new AccountReader().ReaderFiles(this.diretorioAccounts);
            guilds = new GuildReader().ReaderFiles(this.diretorioGuilds).FirstOrDefault();
            playersOnline = CarregarPlayersOnline(this.diretorioPlayersOnline);
        }
        private List<Player> CarregarPlayersOnline(string diretorio)
        {
            List<Player> listaPlayersOnline = new List<Player>();
            try
            {
                using (StreamReader textReader = new StreamReader(diretorio))
                {
                    string[] text = textReader.ReadToEnd().Split(':').ElementAt(1).Split('.').ElementAt(0).Split(',');
                    foreach(var p in text)
                    {
                        var player = players.FirstOrDefault(x=>x.Name == p.Trim());
                        if (player != null )
                            listaPlayersOnline.Add(player);
                    }
                }
            }
            catch (Exception)
            {
            }
            return listaPlayersOnline;
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
        protected bool CriarPlayer(Player player)
        {
            try
            {
                var arquivo = $"{this.diretorioPlayer}\\{player.Name}.xml";
                if (System.IO.File.Exists(arquivo))
                    return false;

                var account = accounts.FirstOrDefault(x => x.AccountNumber == player.Account);
                if (account == null)
                    return false;

                account.Characters.Character.Add(new Character {Name= player.Name });
                AtualizarAccount(account);
                System.Xml.Serialization.XmlSerializer serializer = new XmlSerializer(typeof(Player));
                TextWriter writer = new StreamWriter(arquivo);
                serializer.Serialize(writer, player);
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        protected bool DeletarPersonagem(Player player)
        {
            try
            {
                var arquivo = $"{this.diretorioPlayer}\\{player.Name}.xml";
                if (!System.IO.File.Exists(arquivo))
                    return false;

                var account = accounts.FirstOrDefault(x => x.AccountNumber == player.Account);
                if (account == null)
                    return false;

                account.Characters.Character.Remove(new Character { Name= player.Name });
                //AtualizarAccount(account);

                return true;



            }
            catch (Exception e)
            {
                return false;
            }
        }


    }
}