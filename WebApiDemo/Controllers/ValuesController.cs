using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;   // Importing Person Model

namespace WebApiDemo.Controllers
{
    /// <summary>
    /// This is the People Controler where all user information is stored
    /// </summary>
    public class ValuesController : ApiController
    {
        List<Person> people = new List<Person>();

        /// <summary>
        /// People Constructor
        /// </summary>
        public ValuesController()
        {
            people.Add(new Person { FirstName = "Rishabh", LastName = "Tiwari", id = 1 });
            people.Add(new Person { FirstName = "Rishav", LastName = "Raj", id = 2 });
            people.Add(new Person { FirstName = "Sheshank", LastName = "Moghe", id = 3 });
            people.Add(new Person { FirstName = "Mayank", LastName = "Bisht", id = 4 });
        }

        /// <summary>
        /// Get First Name URl
        /// </summary>
        /// <param name="userId">Unique User Id</param>
        /// <param name="age"> User Age</param>
        /// <returns> A list of user first name</returns>
        // Get firstName of all the people
        //[Route("api/values/getfirstname")]
        [Route("api/values/getfirstname/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> getFirstName(int userId, int age)
        {
            List<string> fName = new List<string>();

            foreach(var p in people)
            {
                fName.Add(p.FirstName);
            }

            return fName;
        }

        // GET api/values
        public List<Person> Get()
        {

            return people;
        }

        // GET api/values/5
        public Person Get(int id)
        {
            return people.Where( (x) => x.id == id ).FirstOrDefault();
        }

        // POST api/values
        public void Post(Person val) 
        {
            people.Add(val);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
