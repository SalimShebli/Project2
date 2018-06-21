using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Poject2.Models.Persons
{
    public class Person
    {
        public int Id { get; set; }
       
        [StringLength(20)]
        public string fName { get; set; }
        [StringLength(20)]
        public string lName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        public int PhoneNumber { get; set; }
        //
        public int personTypeId { get; set; }
        public PersonType personType { get; set; }
        //
        public int AddressId { get; set; }
        public Address Address { get; set; }
        //
        public int RatingId { get; set; }
        public Rating Rating { get; set; }
        //
        public Account Account { get; set; }
        public int AccountId { get; set; }
        //
        public virtual List<Friend> ListFriend { get; set; }
        public virtual List<BlockPerson> ListBlock { get; set; }
        public virtual List<Notifaciton> ListNotifaction { get; set; }
        public virtual List<Post> ListPost { get; set; }
    }
}