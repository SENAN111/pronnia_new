using PRONIYE_NEW.Models.Base;

namespace PRONIYE_NEW.Models
{
    public class ProductImage : BaseData
    {
        public string ImageUrl { get; set; }
        public bool? IsCover { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
