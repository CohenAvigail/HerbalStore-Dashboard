using Microsoft.AspNetCore.Mvc;
using MyProject.Entites;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class OrdersController : ControllerBase
    {
        private static int cnt = 0;
        private static List<Order> orders;

        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return orders;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            var ord = orders.Find(x => x.Id == id);
            if (ord != null)
                return ord;
            throw new Exception("the id is not exist");
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] Order order)
        {
            orders.Add(new Order { Id = order.Id, Products = order.Products,Customer = order.Customer});
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order order)
        {
            var ord = orders.Find(x => x.Id == id);
            if(ord != null)
            {
                ord.Products = order.Products;
                ord.Customer = order.Customer;
            }
            else throw new Exception("the id is not exist");
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var ord = orders.Find(x => x.Id == id);
            if(ord != null)
                orders.Remove(ord);
            else throw new Exception("the id is not exist");
        }
    }
}
