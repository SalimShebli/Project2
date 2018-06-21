using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Poject2.Models.Persons
{
    public class BlockPerson
    {
        public int Id { get; set; }
        public int BlockId { get; set; }
        public int PersonId { get; set; }
    }
}