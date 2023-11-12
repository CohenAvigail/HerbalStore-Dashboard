using Microsoft.AspNetCore.Mvc;
using MyProject.Entites;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private static int cnt = 0;
        private static List<Customer> customers;


        // GET: api/<CustomersController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customers;
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            var c = customers.Find(x => x.Id == id);
            if (c != null)
                return c;
            throw new Exception("the id is not exist");
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            customers.Add(new Customer { Id = ++cnt, Address = customer.Address,Name = customer.Name,PhoneNumber = customer.PhoneNumber }); 
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer customer)
        {
            var c = customers.Find(x => x.Id == id);
            if (c != null)
            {
                c.PhoneNumber = customer.PhoneNumber;
                c.Address = customer.Address;
                c.Name = customer.Name;
            }
            else throw new Exception("the id is not exist");
        }

        //// DELETE api/<CustomersController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    var c = customers.Find(x => x.Id == id);
        //    if (c != null)
        //        customers.Remove(c);
        //}
    }
}
