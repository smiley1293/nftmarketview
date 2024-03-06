using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NFTMarketViewRazorPages.Pages.Logout
{
    public class LogoutModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public LogoutModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public void OnPost()
        {
            _httpContextAccessor.HttpContext.Session.Remove("RoleID");
            Response.Redirect("/Index");
        }
    }
}
