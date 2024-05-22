using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedicamentApp.Models;
using MedicamentApp.DataContext;

namespace MedicamentApp.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MedicamentAppContext _context;

        public EmployeesController(MedicamentAppContext context)
        {
            _context = context;
        }

        // GET: /Employees/Index
        [HttpGet]
        public IActionResult Index()
        {
            var employees = _context.Employees
                .Include(e => e.Role) // Загрузка связанных данных о ролях
                .ToList();
            return View(employees);
        }
    }
}
