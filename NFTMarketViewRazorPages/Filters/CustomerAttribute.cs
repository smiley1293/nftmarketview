
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace NFTMarketViewRazorPages.Filters;

public class CustomerAttribute : ActionFilterAttribute
{
    public override void OnResultExecuting(ResultExecutingContext context)
    {
        if (context.HttpContext.Session.GetInt32("RoleID") != 2)
        {
            context.Result = new UnauthorizedResult();
        }
        else
            base.OnResultExecuting(context);
           
    }
}