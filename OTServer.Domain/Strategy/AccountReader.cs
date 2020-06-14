using OTServer.Domain.Models.Account;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OTServer.Domain.Strategy
{
    public class AccountReader : IReader<Account>
    {
        public List<Account> ReaderFiles(string directory)
        {
            string[] arquivos = Directory.GetFiles(directory);
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
                catch
                {
                    Console.WriteLine(localArquivo);
                }
            }
            return accounts;
        }
    }
}
