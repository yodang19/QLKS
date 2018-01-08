using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    class DanhMucPhong
    {
        public void LoadDanhMucPhong(DataTable dt)
        {
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            conection.Open();
            SqlCommand command = new SqlCommand("LietKeDanhMucPhong", conection);
            command.CommandType = CommandType.StoredProcedure;

            command.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            conection.Close();
        }
        public void LoadDanhSachPhong(DataTable dt)
        {
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            conection.Open();
            SqlCommand command = new SqlCommand("DanhMucPhong", conection);
            command.CommandType = CommandType.StoredProcedure;

            command.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            conection.Close();
        }
    }

}
