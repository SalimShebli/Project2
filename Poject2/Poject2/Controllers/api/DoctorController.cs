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
    public class DoctorController : ApiController
    {

        ApplicationDbContext _context;
        public DoctorController()
        {
            _context = new ApplicationDbContext();

        }

        //api/Doctor
        [HttpGet]
        public IEnumerable<Doctor> getDoctor()
        {
            return _context.Doctor.ToList();
        }
        //api/Doctor/1
        [HttpGet]
        public IHttpActionResult getDoctor(int id)
        {
            /*if (id == 0)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var Pac = _context.Doctor.FirstOrDefault(m => m.Id == id);
            if (Pac == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return Pac;*/
            //Doctor Doc = new Doctor
            //{
            //    AddressId = 6,
            //    BirthDate = new DateTime(2000, 1, 1),
            //    //Email = "ammar@hotmail.com",
            //    Gender = true,
            //    fName = "saleh",
            //    lName="mohamd",
            //    PhoneNumber = 12345678,
            //    RatingId = 1,
            //    specializtion = 1,
            //    AddressClinicId=1
                
            //};
            //_context.Doctor.Add(Doc);
            //_context.SaveChanges();
            return Ok();

        }

        [HttpPost]
        public IHttpActionResult CreateDoctor(Doctor Doctor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.Doctor.Add(Doctor);
            _context.SaveChanges();
            return Ok(Doctor);
        }
        [HttpPut]
        public IHttpActionResult UpdateDoctor(Doctor Doctor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var Pac = _context.Doctor.FirstOrDefault(m => m.Id == Doctor.Id);
            if (Pac == null)
            {
                return NotFound();
            }
            //Pac.Address = Doctor.Address;
            //Pac.AddressId = Doctor.AddressId;
            //Pac.BirthDate = Doctor.BirthDate;
            ////Pac.Email = Doctor.Email;
            //Pac.Gender = Doctor.Gender;
            //Pac.ListAppiontment = Doctor.ListAppiontment;
            //Pac.ListBlock = Doctor.ListBlock;
            //Pac.ListNotifaction = Doctor.ListNotifaction;
            //Pac.ListPost = Doctor.ListPost;
            //Pac.fName = Doctor.fName;
            //Pac.lName = Doctor.lName;
            //Pac.PhoneNumber = Doctor.PhoneNumber;
            //Pac.Rating = Doctor.Rating;
            //Pac.RatingId = Doctor.RatingId;
            //Pac.ListEvent = Doctor.ListEvent;
            //Pac.ListTransforPacient = Doctor.ListTransforPacient;
            //Pac.specializtion = Doctor.specializtion;
            //Pac.AddressClinic = Doctor.AddressClinic;
            //Pac.AddressClinicId = Doctor.AddressClinicId;
            
            _context.SaveChanges();
            return Ok(Doctor);
        }
        [HttpDelete]
        public IHttpActionResult DeleteDoctor(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var Pac = _context.Doctor.FirstOrDefault(m => m.Id == id);
            if (Pac == null)
            {
                return NotFound();
            }
            _context.Doctor.Remove(Pac);
            _context.SaveChanges();
            return Ok();
        }

        
    }
}
