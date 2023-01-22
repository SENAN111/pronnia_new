using PRONIYE_NEW;
using PRONIYE_NEW.Models;


namespace PRONIYE_NEW.ViewModels
{


    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Product> FeaturedProducts { get; set; }
        public IEnumerable<Product> LastestProducts { get; set; }
    }
}