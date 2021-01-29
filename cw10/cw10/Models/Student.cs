﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw10.Models
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IndexNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public string RefreshToken { get; set; }

        public int IdEnrollment { get; set; }
    }
}
