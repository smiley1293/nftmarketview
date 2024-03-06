using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NFTMarketViewRepository;
using NFTMatketViewBusinessObject.Models;

namespace NFTMarketViewRazorPages.Pages.Accounts
{
    public class DetailsModel : PageModel
    {
        private readonly IAccountRepository _accountRepository;

        public DetailsModel(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

      public Account Account { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _accountRepository.GetAccounts() == null)
            {
                return NotFound();
            }

            var account = _accountRepository.GetAccount(id);
            if (account == null)
            {
                return NotFound();
            }
            else 
            {
                Account = account;
            }
            return Page();
        }
    }
}
