using NFTMatketViewBusinessObject.Models;

namespace NFTMarketViewDAO
{
    public class AccountDAO
    {
        private static AccountDAO instance = null;
        private readonly NFTWebManagementContext dbContext = null;

        public AccountDAO()
        {
            if (dbContext == null)
            {
                dbContext = new NFTWebManagementContext();
            }
        }

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
        }

        //dinh danh account
        public Account GetAccount(string email)
        {
            return dbContext.Accounts.FirstOrDefault(m => m.Email.Equals(email));
        }


        //Lay account
        public List<Account> GetAccounts()
        {
            return dbContext.Accounts.ToList();
        }

        //them
        public void AddAccount(Account account)
        {
            Account user = GetAccount(account.Email);
            if(user == null)
            {
                dbContext.Add(account);
                dbContext.SaveChanges();
            }
        }

        //xoa
        public void DeleteAccount(string email)
        {
            Account user = GetAccount(email);
            if(user != null)
            {
                dbContext.Remove(user);
                dbContext.SaveChanges();
            }
        }
        
        //Update
        public void UpdateAccount(Account account)
        {
            Account user = GetAccount(account.Email);
            if(user != null)
            {
                dbContext.Entry(user).CurrentValues.SetValues(account);
                dbContext.SaveChanges();
            }
        }

        //Login
        public bool Login (string email, string password)
        {
            var user = dbContext.Accounts.FirstOrDefault(u => u.Email.Equals(email) && u.Password.Equals(password));
            if (user != null)
            {
                return true;
            }return false;
        }

    }
}