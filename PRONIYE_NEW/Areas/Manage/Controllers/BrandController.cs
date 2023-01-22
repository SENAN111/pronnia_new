using Microsoft.AspNetCore.Mvc;
using PRONIYE_NEW.DAL;
using PRONIYE_NEW.Models;
using PRONIYE_NEW;
using PRONIYE_NEW.ViewModels;

namespace PRONIYE_NEW.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class BrandController : Controller
    {
            readonly AppDbContext _context;
            readonly IWebHostEnvironment _env;
            public BrandController(AppDbContext context, IWebHostEnvironment env)
            {
                _context = context;
                _env = env;
            }
            public IActionResult Index()
            {
                return View(_context.Brands.ToList());
            }
            public IActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public IActionResult Create(CreateBrandVM brandVm)
            {
                if (!ModelState.IsValid) return View();
                IFormFile file = brandVm.ImageFile;
                if (!file.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Image", "Duzgun sekil yukle");
                    return View();
                }
                if (!(brandVm.ImageFile.Length / 1024 / 1024 < 2))
                {
                    ModelState.AddModelError("Image", "Sekilin hecmi 2mb-dan cox olmaz");
                    return View();
                }
                string fileName = Guid.NewGuid() + file.FileName;
                using (var stream = new FileStream(Path.Combine(_env.WebRootPath, "assets", "images", "brand", fileName), FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Brand brand = new Brand { ImageUrl = fileName };
                _context.Brands.Add(brand);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            public IActionResult Update(int? id)
            {
                if (id == null || id == 0) return BadRequest();
                Brand brand = _context.Brands.Find(id);
                if (brand is null) return NotFound();
                return View(brand);
            }
            [HttpPost]
            public IActionResult Update(int? id, Brand brand)
            {
                if (id == null || id == 0 || id != brand.Id || brand is null) return BadRequest();
                if (!ModelState.IsValid) return View();
                Brand exist = _context.Brands.Find(brand.Id);
                exist.ImageUrl = brand.ImageUrl;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
        public IActionResult Delete(int? id)
            {
                if (id is null) return BadRequest();

                Brand brand = _context.Brands.Find(id);
                if (brand is null) return NotFound();
                _context.Brands.Remove(brand);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
    }
}
