namespace WebApiDemo.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using WebApiDemo.Data;
    using WebApiDemo.Models;

    // REST /api/products
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext db;

        public ProductsController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            var products = db.Products.ToList();

            return products;
        }       

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = this.db.Products.Find(id);

            if (product == null)
            {
                return this.NotFound();
            }

            return product;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Post(Product product)
        {
            await this.db.AddAsync(product);
            await this.db.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = product.Id }, product);
        }

        [HttpPut]
        public async Task<ActionResult<Product>> Put(Product product)
        {
            this.db.Entry(product).State = EntityState.Modified;

            await this.db.SaveChangesAsync();

            return this.NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult<Product>> Delete(int id)
        {
            var product = this.db.Products.Find(id);

            if (product == null)
            {
                return this.NotFound();
            }

            this.db.Products.Remove(product);
            await this.db.SaveChangesAsync();

            return this.NoContent();
        }

        //достъпно от body-то https://localhost:port/api/products
        //bind-ва данните от изпратеното body
        //[HttpPost]
        //public Product TestPost(Product product)
        //{
        //    return product;
        //}

        //return xml values
        //Modify Accept header=application/xml
        //Add services.AddXmlSerializerFormatters()
        //Access by https://localhost:port/api/products/123 това е част от route value-то
        //with post method
        //[HttpPost("{id}")]
        //public string Post(int id)
        //{
        //    return id.ToString();
        //}
    }
}
