﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICMWPFUI.Library.Models
{
    public class LoggedinUserModel : ILoggedinUserModel
    {
        public string Token { get; set; }
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddresse { get; set; }

        //changed from this
        //public DateTime CreatedDate { get; set; } = DateTime.Now;
        //to prefered string
        public string CreatedDate { get; set; } = DateTime.Now.ToString("MM/dd/yyyy");
    }
}
