using HandmadeApi.Models.StoreDatabase;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandmadeApi.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        //Image is nullable to be edited
        public string? Image { get; set; }
        public int Price { get; set; }
        public int? SaleValue { get; set; }
        public int Quantity { get; set; }
        //Min. time Elapsed to prepare this product in business days
        public int PreparationDays { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("Store")]
        public int StoreID { get; set; }
        public virtual Store Store { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }



    }
}
