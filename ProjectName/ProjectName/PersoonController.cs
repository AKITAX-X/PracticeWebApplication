using ClassLibrary1;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectName
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersoonController : ControllerBase
    {
        private PijplijnContext _db; //verbinding met database wordt hier gedaan.
        public PersoonController(PijplijnContext db) //wat gebeurd hier vragen/
        {
            _db = db;
        }


        // GET: api/<PersoonController>
        [HttpGet]
        public IEnumerable<string> Get()
        {

            DateTime Date1 = DateTime.Now;
            string Text = "Today is: ";
            string Time = "Wednesday 11/03/2021";

            return new string[] { Text, Time };
        }

        // GET api/<PersoonController>/5
        [HttpGet("iets")]
        public string ietsMethode(int id)
        {
            Person student1 = new Person();
            student1.Naam = "Ali";
            student1.Leeftijd = 24;
            student1.Studiejaar = 1;
            student1.Woonplaats = "Amsterdam";

            _db.Add(student1);
            _db.SaveChanges();

            return "iets"; //wat return ik hier? is het niet alleen save?

        }

        // GET api/<PersoonController>/5
        [HttpGet("iets/{denaam}")]
        public Person Naamopslaaninlink(string denaam)
        {
            Person student1 = new Person();
            student1.Naam = denaam;
            student1.Leeftijd = 24;
            student1.Studiejaar = 1;
            student1.Woonplaats = "Amsterdam";

            _db.Add(student1);
            _db.SaveChanges();

            return student1; //wat return ik hier? is het niet alleen save?

        }

        // GET api/<PersoonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersoonController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersoonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersoonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
