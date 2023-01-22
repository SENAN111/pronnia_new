using PRONIYE_NEW.Models.Base;

namespace PRONIYE_NEW.Models
{
    public class ProductInformation : BaseData
    {
        public string Shipping { get; set; }
        public string AboutReturnRequest { get; set; }
        public string Guarantee { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
