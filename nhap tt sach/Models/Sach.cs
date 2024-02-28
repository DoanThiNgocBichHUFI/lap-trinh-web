using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nhap_tt_Sach.Models
{
    public class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public double Gia { get; set; }
        public string AnhBia { get; set; }
        public Sach()
        {
           
        }
        public Sach(string maSach, string tenSach, double gia, string anhBia)
        {
            MaSach = maSach;
            TenSach = tenSach;
            Gia = gia;
            AnhBia = anhBia;
        }
    }
}