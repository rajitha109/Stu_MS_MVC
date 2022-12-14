using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StuMS.Models;

namespace StuMS.Controllers
{

    public class StuController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StuController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var displaydata = _db.Student.ToList();
            return View(displaydata);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewStuModel nec)
        {
            if (ModelState.IsValid)
            {
                _db.Add(nec);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();


        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");

            }

            var getempdetails = await _db.Student.FindAsync(id);
            return View(getempdetails);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(NewStuModel nc)
        {
            if (ModelState.IsValid)
            {
                _db.Update(nc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nc);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");

            }

            var getempdetails = await _db.Student.FindAsync(id);
            return View(getempdetails);

        }

        







    }
}
