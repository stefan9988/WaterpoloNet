using Microsoft.AspNetCore.Mvc;
using WaterpoloAppNet.Data;
using WaterpoloAppNet.Models;

namespace WaterpoloAppNet.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            
            
            return View();
        }

        public IActionResult Login(User user)
        {
            IEnumerable<User> objUserList = _db.Users.ToList();
            Boolean flag=false;
            foreach (User u in objUserList)
            {
                if(u.Userame==user.Userame && u.Password == user.Password)
                {
                    flag=true;  
                }
                else {
                    flag=false;
                }
            }
            if (flag) {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Privacy", "Home");
            }
            
        }
    }
}
