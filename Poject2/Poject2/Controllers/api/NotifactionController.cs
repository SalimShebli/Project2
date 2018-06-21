using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Poject2.Models;
namespace Poject2.Controllers.api
{
    public class NotifactionController : ApiController
    {
        ApplicationDbContext _context;
        public NotifactionController()
        {
            _context = new ApplicationDbContext();

        }
        //api/Notifaction
        [HttpPost]
        public IHttpActionResult CreateNotifaction(Notifaciton notifac)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.Notifaction.Add(notifac);
            _context.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult DeleteNotifaction(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var not = _context.Notifaction.FirstOrDefault(m => m.Id == id);
            if (not == null)
            {
                return NotFound();
            }
            _context.Notifaction.Remove(not);
            _context.SaveChanges();
            return Ok();
        }

    }
}
