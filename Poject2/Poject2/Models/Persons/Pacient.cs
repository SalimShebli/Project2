using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poject2.Models.Persons
{
    public class Pacient
    {
        public int id { get; set; }
        //
        public Person person { get; set; }
        public int personId { get; set; }
        //
        public virtual List<Appointment> ListAppiontment { get; set; }
    }
}