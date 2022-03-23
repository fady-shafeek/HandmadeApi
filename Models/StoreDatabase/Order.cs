using System.ComponentModel.DataAnnotations.Schema;

namespace HandmadeApi.Models.StoreDatabase
{
    public class Order
    {
        public int ID { get; set; }
        [ForeignKey("Client")]
        public int ClientID { get; set; }
        public DateTime OrderDateTime { get; set; }
        public string? Address { get; set; }
        public string? Note { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public virtual Client Client { get; set; }



    }
}
