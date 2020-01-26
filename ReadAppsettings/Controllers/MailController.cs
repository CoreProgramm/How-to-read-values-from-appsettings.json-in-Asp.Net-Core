using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReadAppsettings.Models;

namespace ReadAppsettings.Controllers
{
    public class MailController : Controller
    {
        private readonly MailConfig _config;
        public MailController(MailConfig config)
        {
            _config = config;
        }
        public IActionResult Index()
        {
            string companyEmail = _config.mailFrom;
            string hostName = _config.host;
            string password = _config.password;
            int portNo = _config.portNo;
            return View();
        }
    }
}