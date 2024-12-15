using Dwello_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dwello_App.Controllers
{
    public class HostController : Controller
    {
        private readonly DwelloContext _db;
        public HostController(DwelloContext db)
        {
            _db = db;
        }

        public IActionResult HostIndex()
        {
            return View();
        }
        public IActionResult LoggedInHostIndex()
        {
            return View();
        }

        public IActionResult Index(int? id)
        {
            if (id== null || id== 0)
            {
                return NotFound();
            }

            Models.Host? host = _db.Hosts.Include(host => host.Users).FirstOrDefault(host => host.UserId == id);

            if (host == null)
            {   
                return NotFound();
            }


            return View(host);
        }
    }
}
