using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Poject2.Models.Persons;
using System.ComponentModel.DataAnnotations;

namespace Poject2.Models
{
    public class Subject
    {
        public int Id { set; get; }

        [StringLength(20)]
        public string Content { set; get; }
        public int StudentId { get; set; }
    
    }
}