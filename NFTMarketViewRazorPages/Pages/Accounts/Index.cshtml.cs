using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NFTMarketViewRazorPages.Filters;
using NFTMarketViewRepository;
using NFTMatketViewBusinessObject.Models;

namespace NFTMarketViewRazorPages.Pages.Accounts
{
    [Admin]
    public class IndexModel : PageModel
    {
        private readonly IAccountRepository _iAccountRepo;

        public IndexModel(IAccountRepository iAccountRepo)
        {
            _iAccountRepo = iAccountRepo;
        }

        public IList<Account> Account { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_iAccountRepo.GetAccounts() != null)
            {
                Account = _iAccountRepo.GetAccounts();
            }
        }
    }
}
