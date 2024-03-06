using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NFTMarketViewRepository;

namespace NFTMarketViewRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IAccountRepository _accountRepository;

        public IndexModel(ILogger<IndexModel> logger, IAccountRepository accountRepository)
        {
            _logger = logger;
            this._accountRepository = accountRepository;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public string email { get; set; }

        [BindProperty]
        public string password { get; set; }

        public void OnPost()
        {
            string email = Request.Form["email"];
            string password = Request.Form["password"];
            bool isLogin = _accountRepository.Login(email, password);
            var account = _accountRepository.GetAccounts().Where(u => u.Email.Equals(email)).FirstOrDefault();
            var role = account.RoleId;
            if (isLogin && role ==1)
            {
                HttpContext.Session.SetInt32("RoleID", 1);
                Response.Redirect("/Accounts/Index");
            }else if(isLogin && role == 2)
            {
                HttpContext.Session.SetInt32("RoleID", 2);
                Response.Redirect("/NftPictures_Customer/Customer_Site");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Email or password is not correct");

            }
        }
    }
}