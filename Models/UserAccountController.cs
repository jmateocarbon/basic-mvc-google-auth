using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Google_Auth.Models
{
    public class UserAccountController : Controller
    {
        // GET: UserAccount
        public class AccountDetails
        {
            public int Name { get; set; }
            public string Email { get; set; }
            public string ImageUrl { get; set; }
        }
    }
}