using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplicationSample.Data;

namespace WebApplicationSample.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly MyDbContext _context;

        public EmployeeController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var employees = _context.Employees.ToList(); // Fetch data
            return View(employees); // Pass data to the view
        }
    }
}
