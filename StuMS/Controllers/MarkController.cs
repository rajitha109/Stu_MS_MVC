using Microsoft.AspNetCore.Mvc;
using StuMS.Models;
using Microsoft.EntityFrameworkCore;

namespace StuMS.Controllers
{
    public class MarkController : Controller
    {


        private readonly ApplicationDbContext _db;

        public MarkController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var displaydata = _db.Marks.ToList();
            return View(displaydata);
            
        }



    }
}
