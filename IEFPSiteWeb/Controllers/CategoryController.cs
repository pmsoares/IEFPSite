using IEFPSiteWeb.Data;
using IEFPSiteWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace IEFPSiteWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }


        //GET
        public IActionResult Create()
        {
            return View();
        }
    }
}
