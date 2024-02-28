using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dieuHuong.Models
{
    public class KhoaModel
    {
        public string TenKhoa { get; set; }
        public int namThanhLap { get; set; }
        public string Message { get; set; }

        public KhoaModel()
        {
            TenKhoa = "Khoa Công nghệ TT";
            namThanhLap = 2003;
            Message = "Chào mừng các bạn";
        }
    }
}