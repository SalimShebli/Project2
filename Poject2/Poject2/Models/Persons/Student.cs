using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poject2.Models.Persons
{
    public class Student
    {
        public int id { get; set; }
        public byte YearOfStated { get; set; }
        //
        public Person person { get; set; }
        public int personId { get; set; }
        public string photo { set; get; }

        //public Subject Subject { get; set; }
        //public virtual List<transforPacient> ListTransforPacient { get; set; }
        public virtual List<Subject> ListSubject { get; set; }
    }

}