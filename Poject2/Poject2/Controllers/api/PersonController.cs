using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Poject2.Models;
using Poject2.Models.Persons;
namespace Poject2.Controllers.api
{
    public class PersonController : ApiController
    {
        ApplicationDbContext _context;
        public PersonController()
        {
            _context = new ApplicationDbContext();
        }
        //api/person

        [HttpPost]
        public IHttpActionResult Create(Pacient pacient)
        {
            if(pacient==null)
            {
                return BadRequest();
            }
            
            _context.Pacient.Add(pacient);
            _context.SaveChanges();

            return Ok(pacient);
        }

        
        /*public Pacient test()
        {
            /*var person = new Person();
            var city = new City()
            {
                Content = "homs"
            };
            _context.City.Add(city);
            _context.SaveChanges();
            var address= new Address { 
                CityId=city.Id,
                section="kafarsosa",
                Street="213"
            };
            _context.Address.Add(address);
            _context.SaveChanges();
            person.Address = address;
            person.AddressId = address.Id;
            person.BirthDate = new DateTime(2000,1,1);
            person.Name = "omar2";
            person.Email = "ammar2@hotmail.com";
            person.Gender = true;
            person.PhoneNumber = 76543222;
            person.RatingId = 1;
            person.Rating = _context.Rating.First(m => m.Id == person.RatingId);
            _context.Person.Add(person);
            _context.SaveChanges();
            var pacient = new Pacient(person,null);
            _context.Pacient.Add(pacient);
            _context.SaveChanges();*/

        //var per=_context.Pacient.FirstOrDefault(m=>m.Id==11);
            //per.Rating = _context.Rating.First(m => m.Id == per.RatingId);
            //per.Address = _context.Address.First(m => m.Id == per.AddressId);
          //  return per;
        //}
    
    }
}
