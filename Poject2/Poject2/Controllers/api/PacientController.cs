using Poject2.Models;
using Poject2.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Poject2.Controllers.api
{
    public class PacientController : ApiController
    {
        ApplicationDbContext _context;
        public PacientController()
        {
            _context = new ApplicationDbContext();

        }
        //api/pacient
        [HttpGet]
        public IEnumerable<Pacient> getPacient()
        {
            return _context.Pacient.ToList();
        }
        //api/pacient/1
        [HttpGet]
        public IHttpActionResult getPacient(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            //var Pac = _context.Pacient.FirstOrDefault(m => m.Id == id);
            //if(Pac==null)
            //{
            //    return NotFound();
            //}
            return Ok();
        }
        [HttpPost]
        public IHttpActionResult CreatePacient(Pacient pacient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.Pacient.Add(pacient);
            _context.SaveChanges();
            return Ok(pacient);
        }
        [HttpPut]
        public IHttpActionResult UpdatePacient(Pacient pacient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            //var Pac = _context.Pacient.FirstOrDefault(m => m.Id == pacient.Id);
            //if (Pac == null)
            //{
            //    return NotFound();
            //}
            //Pac.Address = pacient.Address;
            //Pac.AddressId = pacient.AddressId;
            //Pac.BirthDate = pacient.BirthDate;
            ////Pac.Email = pacient.Email;
            //Pac.Gender = pacient.Gender;
            //Pac.ListAppointment = pacient.ListAppointment;
            //Pac.ListBlock = pacient.ListBlock;
            //Pac.ListNotifaction = pacient.ListNotifaction;
            //Pac.ListPost = pacient.ListPost;
            //Pac.fName = pacient.fName;
            //Pac.lName = pacient.lName;
            //Pac.PhoneNumber = pacient.PhoneNumber;
            //Pac.Rating = pacient.Rating;
            //Pac.RatingId = pacient.RatingId;

            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult DeletePacient(int id)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest();
            //}
            //var Pac = _context.Pacient.FirstOrDefault(m => m.Id == id);
            //if (Pac == null)
            //{
            //    return NotFound();
            //}
            //_context.Pacient.Remove(Pac);
            //_context.SaveChanges();
            return Ok();
        }
        }
}
