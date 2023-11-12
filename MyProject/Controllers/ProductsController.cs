using Microsoft.AspNetCore.Mvc;
using MyProject.Entites;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static int cnt = 0;
        private static List<Product> products;// = new List<Product> { new Product { Id = ++cnt, Name = "default", Price = 300 } };
        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            var p = products.Find(x => x.Id == id);
            if (p != null)
                return p;
            throw new Exception("the id is not exist");

        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] Product p)
        {
            products.Add(new Product { Id = ++cnt, Name = p.Name, Price = p.Price});
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product product)
        {
            var p = products.Find(x => x.Id == id);
            if(p != null)
            {
                p.Name = product.Name;
                p.Price = product.Price;
            }
            else throw new Exception("the id is not exist");
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var p = products.Find(x => x.Id == id);
            if (p != null)
                products.Remove(p);
            else throw new Exception("the id is not exist");
        }
    }
}
