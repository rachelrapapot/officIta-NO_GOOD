using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace studentsMark.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : Controller
    {

        public readonly ITeacherServies _ITeacherServies;
        public TeacherController(ITeacherServies DC)
        {
            _ITeacherServies = DC;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return _ITeacherServies.GetTeacher();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{name}")]
        public ActionResult< Teacher> Get(string name)
        {
            var eve = _ITeacherServies.GetTeacher().Find(e => e.Name==name);
            if (eve == null)
                return NotFound();
            return eve;
            
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Teacher t)
        {
            _ITeacherServies.GetTeacher().Add(new Teacher(t.Name, t.Proffesional, t.hours));
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{name}")]
        public ActionResult<Teacher> Put(string name, int hours)
        {
            var eve = _ITeacherServies.GetTeacher().Find(e => e.Name ==name);
            if (eve == null)
                return NotFound();
            eve.hours= hours;
            return eve;

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            var eve = _ITeacherServies.GetTeacher().Find(e => e.Name == name);
            _ITeacherServies.GetTeacher().Remove(eve);

        }
    }
}
