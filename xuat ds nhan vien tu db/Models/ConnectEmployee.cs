//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data.SqlClient;
//using System.Data;

//namespace bai1.Models
//{
//    public class ConnectEmployee
//    {
//        public string conStr = @"Data Source=DESKTOP-0MNS8CK\MSSQLSERVER01;Initial Catalog=QL_NhanSu;Integrated Security=True";

//        //public List<Employee> getData()
//        //{
//        //    List<Employee> listEmployee = new List<Employee>();
//        //    SqlConnection con = new SqlConnection(conStr);
//        //    string sql = "select *from tbl_Employee";
//        //    SqlCommand cmd = new SqlCommand(sql, con);
//        //    cmd.CommandType = CommandType.Text;
//        //    con.Open();
//        //    SqlDataReader rdr = cmd.ExecuteReader();
//        //    while (rdr.Read())
//        //    {
//        //        Employee emp = new Employee();
//        //        emp.ID = Convert.ToInt32(rdr.GetValue(0).ToString());
//        //        emp.Name = rdr.GetValue(1).ToString();
//        //        emp.Gender = rdr.GetValue(2).ToString();
//        //        emp.City = rdr.GetValue(3).ToString();
//        //        listEmployee.Add(emp);
//        //    }
//        //    return (listEmployee);
//        //}

//        public List<Employee> getData()
//        {
//            List<Employee> listEmployees = new List<Employee>();
//            SqlConnection con = new SqlConnection(conStr);// tao 1 doi tg connection
//            string sql = "Select *from tbl_Employee";
//            SqlCommand cmd = new SqlCommand(sql, con);// thuc hien cau lenh
//            cmd.CommandType = CommandType.Text; // kieu cua lenh truy van

//            con.Open();// ket noi dang mo
//            SqlDataReader rdr = cmd.ExecuteReader(); // thuc thi cau truy van dang select và trả về kieu dataReader
//            while (rdr.Read())
//            {
//                Employee emp = new Employee();
//                emp.ID = Convert.ToInt32(rdr.GetValue(0).ToString());
//                emp.Name = rdr.GetValue(1).ToString();
//                emp.Gender = rdr.GetValue(2).ToString();
//                emp.City = rdr.GetValue(3).ToString();

//                listEmployees.Add(emp);
//            }
//            return (listEmployees);
//        }

//        public int getSL()
//        {
//            SqlConnection con = new SqlConnection(conStr);
//            string sql = "select count(*) from tbl_Employee";
//            SqlCommand cmd = new SqlCommand(sql, con);
//            cmd.CommandType = CommandType.Text;
//            con.Open();
//            int sl = (int)cmd.ExecuteScalar();// thuc thi cau truy van dang select
//            con.Close();
//            return sl;
//        }
//    }
//}