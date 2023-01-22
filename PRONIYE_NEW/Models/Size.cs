using PRONIYE_NEW.Models.Base;

namespace PRONIYE_NEW.Models
{
    public class Size : BaseData
    {
        public string Name { get; set; }
        public ICollection<ProductSize>? ProductSizes { get; set; }
    }
}
