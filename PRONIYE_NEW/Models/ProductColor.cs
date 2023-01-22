
using PRONIYE_NEW.Models.Base;

namespace PRONIYE_NEW.Models
{
    public class ProductColor : BaseData
    {
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public Color? Color { get; set; }
        public Product? Product { get; set; }
    }
}
