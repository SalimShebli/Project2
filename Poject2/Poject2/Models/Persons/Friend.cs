using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poject2.Models.Persons
{
    public class Friend
    {
        public int id { get; set; }
        public int PersonId { get; set; }
        public int PersonFriend { get; set; }
    }
}