using NFTMatketViewBusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTMarketViewRepository
{
    public interface IAccountRepository
    {
        public Account GetAccount(string email);
        public List<Account> GetAccounts();
        public void AddAccount(Account account);
        public void DeleteAccount(string email);
        public void UpdateAccount(Account account);
        public bool Login(string email, string password);
    }
}

