using CafeRestaurant.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CafeRestaurant.ViewComponents
{
    public class AddressVC : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public AddressVC(ApplicationDbContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            var address = _db.Addresses.ToList();
            return View(address);   
        }
    }
}
