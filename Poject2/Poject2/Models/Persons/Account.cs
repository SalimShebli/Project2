using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Poject2.Models.Persons
{
    public class Account
    {
        public int Id { get; set; }
        //don't create two account with one email
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(30)]
        public string PassWord { get; set; }
        public DateTime updateAt { set; get; }
        public DateTime CreateAt { get; set; }
    }
}