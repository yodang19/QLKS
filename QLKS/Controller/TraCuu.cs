using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.Controller
{
    class TraCuu
    {
        public void TraCuuPhong(string tenphong, string tenloaiphong,string dongia, string tinhtrang,DataTable dt)
        {
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            conection.Open();
            SqlCommand command = new SqlCommand("TraCuuPhong", conection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@TenPhong", tenphong);
            command.Parameters.Add(p);
            p = new SqlParameter("@TenLoaiPhong", tenloaiphong);
            command.Parameters.Add(p);
            p = new SqlParameter("@DonGia", dongia);
            command.Parameters.Add(p);
            p = new SqlParameter("@TinhTrang", tinhtrang);
            command.Parameters.Add(p);

            command.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            conection.Close();
        }
    }
}
