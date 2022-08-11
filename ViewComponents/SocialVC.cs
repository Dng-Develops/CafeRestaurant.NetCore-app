using CafeRestaurant.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CafeRestaurant.ViewComponents
{
    public class SocialVC : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public SocialVC(ApplicationDbContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            var social = _db.Addresses.ToList();
            return View(social);
        }
    }
}

