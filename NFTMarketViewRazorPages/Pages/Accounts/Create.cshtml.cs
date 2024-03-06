using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NFTMarketViewRepository;
using NFTMatketViewBusinessObject.Models;

namespace NFTMarketViewRazorPages.Pages.Accounts
{
    public class CreateModel : PageModel
    {
        private readonly IAccountRepository _accountRepository;

        public CreateModel(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Account Account { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _accountRepository.GetAccounts() == null || Account == null)
            {
                return Page();
            }

            _accountRepository.AddAccount(Account);
            

            return RedirectToPage("./Index");
        }
    }
}
