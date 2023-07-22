using Microsoft.AspNetCore.Mvc;

using DMAWS_STUDENTAPI.Models;

namespace DMAWS_STUDENTAPI.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly DataContext _context;
        public ProjectsController(DataContext context) {  _context = context; }
        public IActionResult Index()
        {
            List<Project> projects =  _context.Projects.ToList<Project>();
            return View(projects);
        }
        [HttpPost]
        public IActionResult Create(Project project)
        {
            if (ModelState.IsValid)
            {
                _context.Projects.Add(project);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(project);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var category = _context.Projects.Find(Id);
            if (category == null)
                return NotFound();
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Project project)
        {
            if (ModelState.IsValid)
            {
                _context.Projects.Update(project);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(project);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var project = _context.Projects.Find(Id);
            if (project == null)
            {
                return NotFound();
            }
            _context.Projects.Remove(project);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}