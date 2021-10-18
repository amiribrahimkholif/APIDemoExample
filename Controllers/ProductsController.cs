using EntityFramework.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EntityFramework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public ProductsController(ApplicationDBContext context )
        {
            _context = context;
        }

        // GET
        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        // GET By Id
        [HttpGet("{id}")]
        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        // POST 
        [HttpPost]
        public void Add([FromBody] Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        // Update 
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] Product prod)
        {
            var product = _context.Products.Find(id);

            product.ProductName = prod.ProductName;
            product.Price = prod.Price;
            _context.SaveChanges();
        }

        // DELETE 
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}
