using Microsoft.AspNetCore.Mvc;
using API.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public static List<Person> allPeople = new List<Person>() 
        { 
            new Person { id = 1, name = "Etty", password = "1111111111" ,fieldSearch = "Server" },
            new Person { id = 2, name = "Riki", password = "2222222222" ,fieldSearch = "Client"},
            new Person { id = 3, name = "Racheli", password = "3333333333" ,fieldSearch = "QA" }
        };
    // GET: api/<PersonController>
    [HttpGet("GetPersons")]
        public List<Person> Get()
        {
            return allPeople;
        }

        // Post api/<PersonController>/5
        [HttpPost("ConnectUser")]
        public Person ConnectUser(Person User)
        {
          int index = allPeople.FindIndex(p=>p.password == User.password&&p.name==User.name);
            if (index == -1)
                return null;
            return allPeople[index];
        }

        // POST api/<PersonController>
        [HttpPost("AddPerson")]
        public void Post([FromBody] Person newPerson)
        {
            allPeople.Add(newPerson);
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
