﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bai1.Models
{
    public class Information
    {
        public string FullName { get; set; }
        public string IdStudent { get; set; }
        public string Email { get; set; }
        public string FileImage { get; set; }
        public string Note { get; set; }

        //public bool Check1 { get; set; }
        //public bool Check2 { get; set; }
        //public bool Check3 { get; set; }

        public string Check1 { get; set; }
        public string Check2 { get; set; }
        public string Check3 { get; set; }
        public string ChooseWorkTime { get; set; }
        public string SelectCourse { get; set; }
    }
}