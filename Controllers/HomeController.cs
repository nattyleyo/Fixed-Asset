using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FixedAsset.Data;
using FixedAsset.Models;
using System.Threading.Tasks;

namespace FixedAsset.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("TestDatabaseConnection")]
        public async Task<IActionResult> TestDatabaseConnection()
        {
            try
            {
                var newUser = new Users
                {
                    Username = "TestUser",
                    Password = "TestPassword"
                };

                // Add a new entity and save it to the database
                _context.Users.Add(newUser);
                await _context.SaveChangesAsync();

                return Content("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error occurred: {ex.Message}");
                return Content("An error occurred while inserting data.");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
