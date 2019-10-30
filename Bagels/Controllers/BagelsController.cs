using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Bagels.Models;
using Microsoft.EntityFrameworkCore;

namespace Bagels.Controllers
{
    [Route("api/[controller]")] //Route: "api/bagels"
    [ApiController]
    public class BagelsController : ControllerBase
    {
        private BagelsContext _db;

        public BagelsController(BagelsContext db)
        {
            _db = db;
        }

        //GET api/bagels
        [HttpGet]
        public ActionResult<IEnumerable<Bagel>> Get(string flavor, string suggestedToppings)
        {
            var query = _db.Bagels.AsQueryable();

            if (flavor != null)
            {
                query = query.Where(b => b.Flavor.ToLower().Contains(flavor.ToLower()));
            }
            if (suggestedToppings != null)
            {
                query = query.Where(b=> b.SuggestedToppings.ToLower().Contains(suggestedToppings.ToLower()));
            }
            return query.ToList();
        }

        //GET api/bagels/{id}
        [HttpGet("{id}")]
        public ActionResult<Bagel> Get(int id)
        {
            return _db.Bagels.FirstOrDefault(t => t.BagelId == id);
        }

        //POST api/bagels
        [HttpPost]
        public void Post([FromBody] Bagel bagel)
        {
            _db.Bagels.Add(bagel);
            _db.SaveChanges();
        }

        //PUT api/bagels/{id}
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Bagel bagel)
        {
            bagel.BagelId = id; 
            _db.Entry(bagel).State = EntityState.Modified;
            _db.SaveChanges();
        }

        //DELETE api/bagels/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var bagelToDelete = _db.Bagels.FirstOrDefault(b => b.BagelId == id);
            _db.Bagels.Remove(bagelToDelete);
            _db.SaveChanges();
        }

    }
}