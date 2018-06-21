using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Poject2.Models;
using AutoMapper; 

namespace Poject2.Controllers.api
{
    public class AppiontmentController : ApiController
    {
        ApplicationDbContext _context;
        public AppiontmentController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpGet]
        public IHttpActionResult getAppoint()
        {
            return Ok(_context.Appointment.ToList());
        }
        [HttpGet]
        public IHttpActionResult getAppoint(int id )
        {
            return Ok(_context.Appointment.ToList());
        }
        //api/appiontment/
        [HttpPost]
        public IHttpActionResult CreateAppoint(Appointment appoint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.Appointment.Add(appoint);
            _context.SaveChanges();
            return Ok(appoint);
        }
        [HttpPut]
        public IHttpActionResult UpdateAppoint(Appointment appoint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var appoin = _context.Appointment.FirstOrDefault(m => m.Id == appoint.Id);
            if (appoin == null)
            {
                return NotFound();
            }
            //maping
            appoin.Date = appoint.Date;
            appoin.StatesId= appoint.StatesId;
            appoin.States = appoint.States;
            //Mapper.Map(appoint, appoin);
            _context.SaveChanges();
            return Ok(appoint);
        }
        [HttpPost]
        public IHttpActionResult DeleteAppoint(Appointment appoint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var appoin = _context.Appointment.FirstOrDefault(m => m.Id == appoint.Id);
            if (appoin == null)
            {
                return NotFound();
            }
            _context.Appointment.Remove(appoint);
            _context.SaveChanges();
            return Ok(appoint);
        }
    }
}
