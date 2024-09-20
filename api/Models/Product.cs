using Microsoft.AspNetCore.Mvc;

namespace api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string name {  get; set; }

        public string description { get; set; }

        public int? categoryId { get; set; }

        public decimal price { get; set; }

        public int quantity { get; set; }
    }
}
