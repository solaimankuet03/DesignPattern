﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCUsingUnity.Models
{
    public class Institution
    {
        public long InstitutionID { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
    }
}