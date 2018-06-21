using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Poject2.Models.Persons
{
    public class Address
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        [StringLength(20)]
        public string section { get; set; }
        [StringLength(20)]
        public string Street { get; set; }     

    }
}