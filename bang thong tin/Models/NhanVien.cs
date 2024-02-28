using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bang_thong_tin.Models
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string tenNV { get; set; }
        public string GT { get; set; }
        public string Hinh { get; set; }
        public NhanVien()
        {
            ID = 101;
            tenNV = "Ten nhan vien";
            GT = "Nu";
            Hinh = "download.jpg";
        }
    }
}