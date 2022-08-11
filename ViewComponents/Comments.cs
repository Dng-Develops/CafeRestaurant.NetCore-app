using CafeRestaurant.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CafeRestaurant.ViewComponents
{
    public class Comments: ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public Comments(ApplicationDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var comments = _db.Blogs.Where(x => x.Approved).ToList();
            return View(comments);  
        }
    }
}
