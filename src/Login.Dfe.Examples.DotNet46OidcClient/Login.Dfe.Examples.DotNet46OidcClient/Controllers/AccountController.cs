using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Login.Dfe.Examples.DotNet46OidcClient.Controllers
{
    public class AccountController : Controller
    {
        [Authorize]
        public ActionResult WhoAmI()
        {
            return View(User as ClaimsPrincipal);
        }
    }
}