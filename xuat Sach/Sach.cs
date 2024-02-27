using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bai5.Models
{
    public class Sach
    {
        public string MaSach{get;set;}
        public string TenSach{get;set;}
        public string AnhBia{get;set;}
        public string Gia{get;set;}

       
        public Sach(string id, string name, string pri, string avatar)
        {
            MaSach = id;
            TenSach = name;
            Gia = pri;
            AnhBia = avatar;
        }
    }
}