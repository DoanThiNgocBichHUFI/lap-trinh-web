// buoi 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tuan2_bai3.Models
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Saraly {get; set;}
        public string Hinh {get; set;}

        public NhanVien(){
            ID= 101;
            Name= "Mr.Trung";
            Address= "140 Le Trong Tan";
            Saraly= 2000;
            Hinh = "Cuoi3.JPG";
        }
    }
}

