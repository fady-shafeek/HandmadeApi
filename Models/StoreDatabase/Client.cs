using HandmadeApi.Models.StoreDatabase;

namespace HandmadeApi.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }



    }
}
