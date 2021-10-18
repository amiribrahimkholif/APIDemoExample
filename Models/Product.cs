using EntityFramework.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Data
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required ,MaxLength(255)]
        public string ProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        public ICollection<ProductSupplier> ProductSuppliers { get; set; }
    }
}
