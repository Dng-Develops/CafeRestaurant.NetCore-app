using CafeRestaurant.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CafeRestaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var users = _db.ApplicationUsers.ToList();
            var role = _db.Roles.ToList();
            var userRole = _db.UserRoles.ToList();
            foreach(var item in users)
            {
                var roleId = userRole.FirstOrDefault(x => x.UserId == item.Id).RoleId;
                item.Role = role.FirstOrDefault(y => y.Id == roleId).Name;
            }
            return View(users);
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _db.ApplicationUsers
                .FirstOrDefaultAsync(m => m.Id == id.ToString());
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Admin/Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            int count = _db.ApplicationUsers.ToList().Count();
            if (count > 0)
            { 
            var user = await _db.ApplicationUsers.FindAsync(id);
            _db.ApplicationUsers.Remove(user);
            await _db.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
            
        }

    }
}
