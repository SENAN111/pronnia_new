using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRONIYE_NEW.DAL;
using PRONIYE_NEW.Models;
using PRONIYE_NEW.Utilies.Extentions;


namespace PRONIYE_NEW.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductController:Controller
    {
        readonly AppDbContext _context;
        readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            return View(_context.Products.Include(p => p.ProductColors).ThenInclude(pc => pc.Color).Include(p => p.ProductSizes).ThenInclude(pc => pc.Size).Include(p => p.ProductImages));
        }
        public IActionResult Create()
        {
            ViewBag.Colors = new SelectList(_context.Colors, "Id", "Name");
            ViewBag.Sizes = new SelectList(_context.Sizes, nameof(Size.Id), nameof(Size.Name));
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateProductVM cp)
        {
            var coverImg = cp.CoverImage;
            var hoverImage = cp.HoverImage;
            var otherImage = cp.OtherImages;
            if(coverImg?.CheckType("image/")==false)
            {
                ModelState.AddModelError("CoverImage", "Fayl deyil");
            }
            if (coverImg?.CheckSize(300) == false)
            {
                ModelState.AddModelError("CoverImage", "Olcu duz deyil");
            }
            if (!ModelState.IsValid)
            {
                ViewBag.Colors = new SelectList(_context.Colors, "Id", "Name");
                ViewBag.Sizes = new SelectList(_context.Sizes, nameof(Size.Id), nameof(Size.Name));
                return View();
            }
            return View();
        }
    }
}
