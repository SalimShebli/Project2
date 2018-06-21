using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Poject2.Models
{
    public class Notifaciton
    {
        public int Id { set; get; }
        [StringLength(20)]
        public string Content { set; get; }
        public int id_sender { set; get; }
        //type
        public int idObject { get; set; }
        /* for type
        1 -accept appoint
        2- delete appoint
        3- update appoint 
        4- accept transfor
        5- 
        */
        public int type { get; set; }
        

    }
}