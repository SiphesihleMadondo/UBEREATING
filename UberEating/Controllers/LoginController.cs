using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UberEating.Models;

namespace UberEating.Controllers
{
    public class LoginController : ApiController
    {
        private UberEatingEntities4 db = new UberEatingEntities4();

        // GET: api/Login
        public IEnumerable<User_Table> Get()
        {
            return new User_Table[] {};
        }

        // GET: api/Login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Login
        public IHttpActionResult Post([FromBody]string email,string password)
        {
            var display = db.User_Table.Where(m => m.Email == email && m.Password == password).FirstOrDefault();
            if (display != null)
            {
                Console.WriteLine("CORRECT UserNAme and Password");
            }
            else
            {
                Console.WriteLine("INCORRECT UserNAme and Password");
            }
            return Ok(display);
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
