using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestDBSqLite.DataAccess;
using TestDBSqLite.Models;

namespace TestDBSqLite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _dbContext;

        public HomeController(ILogger<HomeController> logger, DatabaseContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public ActionResult Index()
        {

            var result = _dbContext.Users.FirstOrDefault();
            //result.Where(x => x.LastName == "Test").Select(x => x.LastName = "44444");
            var sss = new UserModel()
            {
                Name = "TTUST",
                LastName = "LASttnf"
            };
            
            //_dbContext.AddRange(sss);
            //_dbContext.SaveChanges();

            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
