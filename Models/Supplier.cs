using EntityFramework.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Data
{
    public class Supplier
    {
        public int Id { get; set; }
        [Required ,MaxLength(255)]
        public string Name { get; set; }

        [Required, MaxLength(255)]
        public string City { get; set; }
        public ICollection<ProductSupplier> ProductSuppliers { get; set; }
    }
}
