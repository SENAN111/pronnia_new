using PRONIYE_NEW.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace PRONIYE_NEW.Models
{
    public class Product : BaseData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        [Range(0.0, Double.MaxValue)]
        public double CostPrice { get; set; }
        [Range(0.0, Double.MaxValue)]
        public double SellPrice { get; set; }
        [Range(0, 100)]
        public int Discount { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ProductColor>? ProductColors { get; set; }
        public ICollection<ProductSize>? ProductSizes { get; set; }
        public ICollection<ProductImage>? ProductImages { get; set; }
        public ProductInformation? ProductInformation { get; set; }
    }
}
