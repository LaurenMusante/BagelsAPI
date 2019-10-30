using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Bagels.Models;
using Microsoft.EntityFrameworkCore;

namespace Bagels.Controllers
{
    [Route("api/[controller]")] //Route: "api/toppings"
    [ApiController]
    public class ToppingsController : ControllerBase
    {
        private BagelsContext _db;

        public ToppingsController(BagelsContext db)
        {
            _db = db;
        }

        //GET api/toppings
        [HttpGet]
        public ActionResult<IEnumerable<Topping>> Get()
        {
            return _db.Toppings.ToList();
        }

        //GET api/toppings/{id}
        [HttpGet("{id}")]
        public ActionResult<Topping> Get(int id)
        {
            return _db.Toppings.FirstOrDefault(t => t.ToppingId == id);
        }

        //POST api/toppings
        [HttpPost]
        public void Post([FromBody] Topping topping)
        {
            _db.Toppings.Add(topping);
            _db.SaveChanges();
        }

        //PUT api/toppings/{id}
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Topping topping)
        {
            topping.ToppingId = id; 
            _db.Entry(topping).State = EntityState.Modified;
            _db.SaveChanges();
        }

        //DELETE api/toppings/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var toppingToDelete = _db.Toppings.FirstOrDefault(t => t.ToppingId == id);
            _db.Toppings.Remove(toppingToDelete);
            _db.SaveChanges();
        }
    }
}