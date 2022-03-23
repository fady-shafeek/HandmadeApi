namespace HandmadeApi.Models
{
    public class Store
    {

        public int ID { get; set; }
        public string VendorName { get; set; }
        public string Phone { get; set; }
        public string StoreName { get; set; }
        public string? StoreImg { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Product> Products { get; set; }


    }
}
