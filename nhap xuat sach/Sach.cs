using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bai5.Models
{
    public class Sach
    {
        public string ID { get; set; }
        public string tenSach { get; set; }
        public string AnhBia { get; set; }
        public int Gia { get; set; }
        public Sach(string id, string name, int pri, string avatar)
        {
            ID = id;
            tenSach = name;
            Gia = pri;
            AnhBia = avatar;
        }
    }
}