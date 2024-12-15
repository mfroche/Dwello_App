using Dwello_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dwello_App.Controllers
{
    public class UserController : Controller
    {
        private readonly DwelloContext _db;
        public UserController(DwelloContext db)
        {
            _db = db;
        }

        public IActionResult LoggedInUserIndex()
        {
            List<User> users = _db.Users.ToList();
            return View(users);
        }

        public IActionResult UserIndex()
        {
            return View();
        }

        public IActionResult UserEdit(int? UserId)
        {
            
            if (UserId == null || UserId == 0)
            {
                return NotFound();
            }

            User userFromDb = _db.Users.Find(UserId);

            if (userFromDb == null)
            {
                return NotFound();
            }
            return View(userFromDb);
            
        }
    }
}
