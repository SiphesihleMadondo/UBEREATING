using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using UberEating.Models;

namespace UberEating.Controllers
{
    public class User_TableController : ApiController
    {
        private UberEatingEntities4 db = new UberEatingEntities4();

        //// GET: api/User_Table
        //public IQueryable<User_Table> GetUser_Table()
        //{
        //    return db.User_Table;
        //}

        // GET: api/User_Tables
        [ResponseType(typeof(User_Table))]
        public IHttpActionResult GetUser_Table(string Email, string Password)
        {
            var obj = db.User_Table.Where(a => a.Email.Equals(Email) && a.Password.Equals(Password)).FirstOrDefault();

            try
            {
                if (obj.Email == "" && obj.Password == "")
                {
                    return (null);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("{0} Exception caught.", ex);
            }
            

            return Ok(obj);
        }

        // PUT: api/User_Table/5

        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser_Table(int id, User_Table user_Table)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user_Table.UserId)
            {
                return BadRequest();
            }

            db.Entry(user_Table).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!User_TableExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/User_Table
        [ResponseType(typeof(User_Table))]
        public IHttpActionResult PostUser_Table(User_Table user_Table)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.User_Table.Add(user_Table);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = user_Table.UserId }, user_Table);
        }

        // DELETE: api/User_Table/5
        [ResponseType(typeof(User_Table))]
        public IHttpActionResult DeleteUser_Table(int id)
        {
            User_Table user_Table = db.User_Table.Find(id);
            if (user_Table == null)
            {
                return NotFound();
            }

            db.User_Table.Remove(user_Table);
            db.SaveChanges();

            return Ok(user_Table);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool User_TableExists(int id)
        {
            return db.User_Table.Count(e => e.UserId == id) > 0;
        }


    }
}