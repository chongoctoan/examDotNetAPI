using Microsoft.AspNetCore.Mvc;
using DMAWS_STUDENTAPI.Models;

namespace DMAWS_STUDENTAPI.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly DataContext _context;
        public EmployeesController(DataContext context) { _context = context; }
        public IActionResult Index()
        {
            List<Employee> employees = _context.Employees.ToList<Employee>();
            return View(employees);
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var employee = _context.Employees.Find(Id);
            if (employee == null)
                return NotFound();
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Update(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var employee = _context.Employees.Find(Id);
            if (employee == null)
            {
                return NotFound();
            }
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}