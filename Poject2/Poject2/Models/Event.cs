using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Poject2.Models.Persons;
using System.ComponentModel.DataAnnotations;

namespace Poject2.Models
{
    public class Event
    {
        public int Id { set; get; }
        public DateTime Date { get; set; }
        [StringLength(20)]
        public string Content { set; get; }
        public int DoctorId { get; set; }       

    }
}