using PRONIYE_NEW.Models.Base;
namespace PRONIYE_NEW.Models
{
    public class ProductSize : BaseData
    {
        public int ProductId { get; set; }
        public int SizeId { get; set; }
        public Size? Size { get; set; }
        public Product? Product { get; set; }
    }
}
