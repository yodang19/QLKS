using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    class PhieuThuePhong
    {
        public int LapPhieuThuePhong(string maphong, string ngaybatdau,int soluongkhach)
        {
            int maphieuthuepphong;
            DataTable dt = new DataTable();
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            conection.Open();

            SqlCommand command = new SqlCommand("LapPhieuThuePhong", conection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MaPhong", maphong);
            command.Parameters.Add(p);
            p = new SqlParameter("@NgayBatDau", ngaybatdau);
            command.Parameters.Add(p);
            p = new SqlParameter("@SoLuongKhach", soluongkhach);
            command.Parameters.Add(p);

            //command.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            string s = dt.Rows[0][0].ToString();
            int.TryParse(s, out maphieuthuepphong);
            conection.Close();
            return maphieuthuepphong;
        }
        public int ThemKhachHang(string tenkhachhang, string maloaikhachhang, string CMND, string diachi)
        {
            int makhachhang;
            DataTable dt = new DataTable();
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            conection.Open();

            SqlCommand command = new SqlCommand("ThemKhachHang", conection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@TenKhachHang", tenkhachhang);
            command.Parameters.Add(p);
            p = new SqlParameter("@MaLoaiKhachHang", maloaikhachhang);
            command.Parameters.Add(p);
            p = new SqlParameter("@CMND", CMND);
            command.Parameters.Add(p);
            p = new SqlParameter("@DiaChi", diachi);
            command.Parameters.Add(p);

            //command.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            string s = dt.Rows[0][0].ToString();
            int.TryParse(s, out makhachhang);
            conection.Close();
            return makhachhang;
        }
        public void ThemChiTietPhieuThuePhong(string makhachhang, string maphieuthuephong)
        {
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            conection.Open();

            SqlCommand command = new SqlCommand("LapChiTietPhieuThuePhong", conection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MaKhachHang", makhachhang);
            command.Parameters.Add(p);
            p = new SqlParameter("@MaPhieuThuePhong", maphieuthuephong);
            command.Parameters.Add(p);

            command.ExecuteNonQuery();

            conection.Close();
        }
    }
}
