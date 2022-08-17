using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app.Models
{
    public class register
    {
        [Key]
        public string Pid { get; set; }

        
        public string pname { get; set; }

        public int time { get; set; }
    }
}