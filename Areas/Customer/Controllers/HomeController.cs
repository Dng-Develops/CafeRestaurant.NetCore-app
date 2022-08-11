using CafeRestaurant.Data;
using CafeRestaurant.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CafeRestaurant.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IToastNotification _toast;
        private readonly IWebHostEnvironment _he;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db, IToastNotification toast, IWebHostEnvironment he)
        {
            _logger = logger;
            _db = db;
            _toast = toast;
            _he = he;
        }

        public IActionResult Index()
        {
            List<Menu> menu = _db.Menus.Where(x => x.Private).ToList();
            return View(menu);
        }

        public IActionResult Menu()
        {
            var menu = _db.Menus.ToList();
            return View(menu);
        }

        public IActionResult CategoryDetails(int? id)
        {
            var menu = _db.Menus.Where(x => x.CategoryId==id).ToList(); 
            ViewBag.CategoryId = id;
            return View(menu);
        }


        // GET: Admin/Reservation/Create
        public IActionResult Reservation()
        {
            return View();
        }

        // POST: Admin/Reservation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reservation([Bind("Id,Name,Email,Phone,People,Time,Date")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                _db.Add(reservation);
                await _db.SaveChangesAsync();
                _toast.AddSuccessToastMessage("You have successfully booked a table our staff will contatct you soon.. Please call us for any changes in your reservation.");
                return RedirectToAction(nameof(Index));
            }
            return View(reservation);
        }

        public IActionResult Gallery()
        {
            var gallery = _db.Galleries.ToList();
            return View(gallery);
        }

        public IActionResult About()
        {
            var about = _db.Abouts.ToList();
            return View(about);
        }

        // ORIGINALLY GET: Admin/Blog/Create
        public IActionResult Blog()
        {
            return View();
        }

        // ORIGINALLY  POST: Admin/Blog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Blog(Blog blog)
        {
            if (ModelState.IsValid)
            {
                blog.Date = DateTime.Now;
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    var fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(_he.WebRootPath, @"Site\blog");
                    var ext = Path.GetExtension(files[0].FileName);
                    if (blog.Image != null)
                    {
                        var imagePath = Path.Combine(_he.WebRootPath, blog.Image.TrimStart('\\'));
                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }
                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName + ext), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }
                    blog.Image = @"\Site\blog\" + fileName + ext;
                }
                _db.Add(blog);
                await _db.SaveChangesAsync();
                _toast.AddSuccessToastMessage("Your comment is succesfully delivered after revision it will be posted");
                return RedirectToAction(nameof(Blog));
            }
            return View(blog);
        }


        // GET: Admin/Contact/Create
        public IActionResult Contact()
        {
            return View();
        }

        // POST: Admin/Contact/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contact([Bind("Id,Name,Email,Phone,Message,Date")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.Date = DateTime.Now;
                _db.Add(contact);
                await _db.SaveChangesAsync();
                _toast.AddSuccessToastMessage("Your message sucessfully delivered. Thank you for reaching us we will respond during working hours");
                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
