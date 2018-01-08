using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.Controller
{
    class HoaDon
    {
        public int LapHoaDon(string makhachhang, string macoquan, int trigia,string ngaylaphoadon)
        {
            int mahoadon;
            DataTable dt = new DataTable();
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            conection.Open();

            SqlCommand command = new SqlCommand("LapPhieuThuePhong", conection);
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@MaKhachHang", makhachhang);
            command.Parameters.Add(p);
            p = new SqlParameter("@MaCoQuan", macoquan);
            command.Parameters.Add(p);
            p = new SqlParameter("@TriGia", trigia);
            command.Parameters.Add(p);
            p = new SqlParameter("@NgayLapHoaDon", ngaylaphoadon);
            command.Parameters.Add(p);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            string s = dt.Rows[0][0].ToString();
            int.TryParse(s, out mahoadon);
            conection.Close();
            return mahoadon;
        }
        //public int ThemKhachHang(string tenkhachhang, string maloaikhachhang, string CMND, string diachi)
        //{
        //    int makhachhang;
        //    DataTable dt = new DataTable();
        //    SqlConnection conection = new SqlConnection();
        //    conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        //    conection.Open();

        //    SqlCommand command = new SqlCommand("ThemKhachHang", conection);
        //    command.CommandType = CommandType.StoredProcedure;
        //    SqlParameter p = new SqlParameter("@TenKhachHang", tenkhachhang);
        //    command.Parameters.Add(p);
        //    p = new SqlParameter("@MaLoaiKhachHang", maloaikhachhang);
        //    command.Parameters.Add(p);
        //    p = new SqlParameter("@CMND", CMND);
        //    command.Parameters.Add(p);
        //    p = new SqlParameter("@DiaChi", diachi);
        //    command.Parameters.Add(p);

        //    //command.ExecuteNonQuery();

        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    adapter.SelectCommand = command;
        //    adapter.Fill(dt);
        //    string s = dt.Rows[0][0].ToString();
        //    int.TryParse(s, out makhachhang);
        //    conection.Close();
        //    return makhachhang;
        //}
        //public void ThemChiTietPhieuThuePhong(string makhachhang, string maphieuthuephong)
        //{
        //    SqlConnection conection = new SqlConnection();
        //    conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        //    conection.Open();

        //    SqlCommand command = new SqlCommand("LapChiTietPhieuThuePhong", conection);
        //    command.CommandType = CommandType.StoredProcedure;
        //    SqlParameter p = new SqlParameter("@MaKhachHang", makhachhang);
        //    command.Parameters.Add(p);
        //    p = new SqlParameter("@MaPhieuThuePhong", maphieuthuephong);
        //    command.Parameters.Add(p);

        //    command.ExecuteNonQuery();

        //    conection.Close();
        //}
    }
}
