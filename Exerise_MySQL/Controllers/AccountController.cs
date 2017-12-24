using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exerise_MySQL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exerise_MySQL.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create(Account UserAccount )
        {
            return View("Index");
        }
    }
}
