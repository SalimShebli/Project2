using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poject2.Models.Persons
{
    public class Doctor
    {

        public int Id { get; set; }
        public int specializtion { get; set; }
        //
        public MapAddress AddressClinic { get; set; }
        public int AddressClinicId { get; set; }
        //
        public int personId { get; set; }
        public Person person { get; set; }
        //
        public string photo { set; get; }

        //public virtual List<transforPacient> ListTransforPacient { get; set; }
        //public virtual List<Appointment> ListAppiontment { get; set; }
        public virtual List<Event> ListEvent { get; set; }
        //list of Follows
        //public virtual List<Pacient> ListPacient { get; set; }
    }
}
