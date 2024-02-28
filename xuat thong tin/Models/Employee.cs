using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xuatthongtin.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public Employee()
        {
            ID = 101;
            Name = "Ten nhan vien";
            Address = "Dia chi nha ";
            Salary = 2000;
        }
    }
}