using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace studentsMark.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HiTechCompaniesController : Controller
    {
        public readonly ICompaniesServies _companiesServies;
        public HiTechCompaniesController(ICompaniesServies DC)
        {
            _companiesServies = DC;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_companiesServies.GetCompanies());
        }
        // GET api/<ValuesController>/5
        [HttpGet("{name}")]
        public ActionResult<Companies> Get(string name)
        {
            var x = _companiesServies.GetCompanies().Find(x => x.Name == name);
            if (x == null)
            {
                return NotFound();
            }

            return x;
        }

    
        [HttpPost]
        public void Post([FromBody] Companies value)
        {
            _companiesServies.GetCompanies().Add(value);
        }
        // PUT api/<ValuesController>/5
        [HttpPut("{name}/status")]
        public ActionResult<Companies> Put(string name, string stasus)
        {
            var eve = _companiesServies.GetCompanies().Find(e => e.Name == name);
            if (eve == null)
                return NotFound();
            eve.Status = stasus;
            return eve;

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            var eve = _companiesServies.GetCompanies().Find(e => e.Name == name);
            _companiesServies.GetCompanies().Remove(eve);

        }
    }
    
}
