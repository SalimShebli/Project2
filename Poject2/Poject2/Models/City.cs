using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Poject2.Models
{
    public class City
    {
        public int Id { set; get; }
        [StringLength(20)]
        public string Content { set; get; }
    }
}