using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    class LoaiPhong
    {
        public void LoadLoaiPhong(DataTable dt)
        {
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            conection.Open();
            SqlCommand command = new SqlCommand("LietKeLoaiPhong", conection);
            command.CommandType = CommandType.StoredProcedure;

            command.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            conection.Close();
        }
        public void ThemLoaiPhong(string maloaiphong,string tenloaiphong,Decimal dongia)
        {
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            conection.Open();

            SqlCommand command = new SqlCommand("ThemLoaiPhong", conection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@MaLoaiPhong", maloaiphong);
            command.Parameters.Add(p);
            p = new SqlParameter("@TenLoaiPhong", tenloaiphong);
            command.Parameters.Add(p);
            p = new SqlParameter("@DonGia", dongia);
            command.Parameters.Add(p);

            command.ExecuteNonQuery();
            conection.Close();
        }
        public void SuaLoaiPhong(string maloaiphong, string tenloaiphong,Decimal dongia)
        {
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            conection.Open();

            SqlCommand command = new SqlCommand("SuaLoaiPhong", conection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@MaLoaiPhong", maloaiphong);
            command.Parameters.Add(p);
            p = new SqlParameter("@TenLoaiPhong", tenloaiphong);
            command.Parameters.Add(p);
            p = new SqlParameter("@DonGia", dongia);
            command.Parameters.Add(p);

            command.ExecuteNonQuery();
            conection.Close();
        }

        public void XoaLoaiPhong(string maloaiphong)
        {
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            conection.Open();

            SqlCommand command = new SqlCommand("XoaLoaiPhong", conection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@MaLoaiPhong", maloaiphong);
            command.Parameters.Add(p);

            command.ExecuteNonQuery();
            conection.Close();
        }
    }
}
