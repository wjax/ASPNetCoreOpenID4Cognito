using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNetCoreOpenID4Cognito.Pages
{
    public class SignOutModel : PageModel
    {
        public async void OnGet()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme); // <-- no error if used alone but it doesn't remove cookies
            await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme); // <-- throws error

            //RedirectToAction("Index");

        }
    }
}
