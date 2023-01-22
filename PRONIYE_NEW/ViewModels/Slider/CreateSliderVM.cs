using System.ComponentModel.DataAnnotations;

namespace PRONIYE_NEW.ViewModels
{
    public class CreateSliderVM
    {
        public string PrimaryTitle { get; set; }
        public string SecondaryTitle { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
        public int Order { get; set; }
    }
}
