using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string name {  get; set; }

        public string description { get; set; }

        [ForeignKey("category")]
        public int categoryId { get; set; }
        public Category category { get; set; }

        public decimal price { get; set; }

        public int quantity { get; set; }
    }
}
