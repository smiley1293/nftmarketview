using NFTMarketViewDAO;
using NFTMatketViewBusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFTMarketViewService
{
    public class AccountService : IAccountService
    {
        public void AddAccount(Account account) => AccountDAO.Instance.AddAccount(account);

        public void DeleteAccount(string email) => AccountDAO.Instance.DeleteAccount(email);    
        

        public Account GetAccount(string email) => AccountDAO.Instance.GetAccount(email);
        

        public List<Account> GetAccounts() => AccountDAO.Instance.GetAccounts();

        public void UpdateAccount(Account account) => AccountDAO.Instance.UpdateAccount(account);
        public bool Login(string email, string password) => AccountDAO.Instance.Login(email, password);

    }
}
