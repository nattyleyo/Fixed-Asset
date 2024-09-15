using Microsoft.AspNetCore.Mvc;
using FixedAsset.Data;
using FixedAsset.Models;

namespace FixedAsset.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Fetch a list of users from the database
            var users = _context.Users.ToList();

            // Pass the data to the view
            return View(users);
        }
    }
}
