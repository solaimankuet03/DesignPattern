﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCUsingUnity.Models
{
    public class Course
    {
        public long CourseID { get; set; }
        public long InstitutionID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}