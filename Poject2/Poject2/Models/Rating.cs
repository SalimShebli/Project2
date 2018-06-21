using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Poject2.Models
{
    public class Rating
    {
        public int Id { set; get; }
        public int value { get; set; }
        [StringLength(20)]
        public string Content { set; get; }
    }
}