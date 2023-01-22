using PRONIYE_NEW.Models.Base;

namespace PRONIYE_NEW.Models
{
    public class Color : BaseData
    {
        public string Name { get; set; }
        public ICollection<ProductColor>? ProductColors { get; set; }
    }
}
