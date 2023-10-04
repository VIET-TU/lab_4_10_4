using lab4_10_4.Data;
using lab4_10_4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lab4_10_4.Controllers
{
    public class LearnerController : Controller
    {
        private readonly SchoolContext _db;

        public LearnerController(SchoolContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

                    IEnumerable<Enrollment> obj_enrollments = _db.Enrollments.Include(l => l.Learner).Include(c => c.Course).ToList();

                    return View(obj_enrollments);
        }


        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AllCrouses = _db.Courses.ToList();
            ViewBag.AllLearners = _db.Learners.ToList();
            return View();
        }

    }
}
