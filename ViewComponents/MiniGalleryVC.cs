using CafeRestaurant.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CafeRestaurant.ViewComponents
{
    public class MiniGalleryVC : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public MiniGalleryVC(ApplicationDbContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            var minigallery = _db.Galleries.ToList().Take(12);
            return View(minigallery);  
        }
    }
}
