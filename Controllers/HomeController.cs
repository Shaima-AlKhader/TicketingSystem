using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TicketingSystem.Models;

namespace TicketingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult LoginUser(Models.LoginModel loginModel)
        {
            DBEntities.TicketingSystemContext context = new DBEntities.TicketingSystemContext();
            var result = context.Users.Where(x => x.UserName == loginModel.UserName
            && x.Password ==loginModel.Password).FirstOrDefault();
            
            if(result != null)
            {
                if(result.Password == loginModel.Password)
                {
                    return RedirectToAction("GetAllIssues", "IssueDetails");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();

            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}