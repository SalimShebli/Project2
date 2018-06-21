using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Poject2.Models
{
    public class Post
    {
        public int Id { set; get; }
        public DateTime   Date { get; set; }
        [StringLength(20)]
        public string Content { set; get; }
        public int PersonId { get; set; }

    }
}