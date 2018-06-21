using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Poject2.Models.Persons;
using System.ComponentModel.DataAnnotations;

namespace Poject2.Models
{
    public class transforPacient
    {
        public int Id { get; set; }
        public Pacient pacient { get; set; }
        public int PacientId { get; set; }
        public DateTime Date { get; set; }

        [StringLength(20)]
        public string Reason { get; set; }

        //revicer Doctor 
        public int DocRecId { get; set; }
        public int DocsendId { get; set; }

    }
}