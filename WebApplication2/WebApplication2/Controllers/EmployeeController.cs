using Microsoft.AspNetCore.Mvc;
using WebApplication2.Contexts;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }

    }
}
