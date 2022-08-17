using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app.Models
{
    public class contact
    {
        
        public string cname { get; set; }

        [Key]
        public string cno { get; set; }

        public string query { get; set; }
    }
}