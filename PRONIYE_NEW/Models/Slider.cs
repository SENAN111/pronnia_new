using PRONIYE_NEW.Models.Base;

namespace PRONIYE_NEW.Models
{
    public class Slider:BaseData
    {
        public string PrimaryTitle { get; set; }
        public string SecondaryTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }
    }
}
