using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace studentsMark.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentMarkController : Controller
    {

        public readonly IStudentServies _IStudentServies;
        public studentMarkController(IStudentServies DC)
        {
            _IStudentServies = DC;
        }

        // GET: api/<colonderController>
        [HttpGet]
        public IEnumerable<students> Get()
        {
            return _IStudentServies.GetStudent();
        }

        // GET api/<colonderController>/5
        [HttpGet("{name}")]
        public students Get(string name)
        {
            var eve = _IStudentServies.GetStudent().Find(e => e.Name == name);
            return eve ;
        }

        // POST api/<colonderController>
        [HttpPost]
        public void Post([FromBody] students s)
        {
            _IStudentServies.GetStudent().Add(new students(s.Name, s.Mark_c, s.Mark_HTML, s.Mark_Java, s.Mark_Pyton, s.f_number));
            return;

        }

        // PUT api/<colonderController>/5
        [HttpPut("{name}")]
        public students Put(string name, [FromBody] students s)
        {

            var Student1 = _IStudentServies.GetStudent().Find(e => e.Name == name);
            Student1.Mark_c = s.Mark_c;
            Student1.Mark_HTML =  s.Mark_HTML;
            Student1.Mark_Java = s.Mark_Java;
            Student1.Mark_Pyton = s.Mark_Pyton;
            return Student1;
        }

        // DELETE api/<colonderController>/5
        [HttpDelete("{name}")]
        public void Delete(string name)
        {

            var eve = _IStudentServies.GetStudent().Find(e => e.Name == name);
            _IStudentServies.GetStudent().Remove(eve);

        }
    }
}
