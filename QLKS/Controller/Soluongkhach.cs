using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.Controller
{
    class Soluongkhach
    {
        public void SuaSoLuongKhach(string sl)
        {
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            conection.Open();

            SqlCommand command = new SqlCommand("setKhachToiDa", conection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@KhachToiDa", sl);
            command.Parameters.Add(p);

            command.ExecuteNonQuery();
            conection.Close();
        }
        public int SoLuongKhach()
        {
            int soluongkhach;
            DataTable dt = new DataTable();
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = @"Data Source=DANGKHOA-PC;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            conection.Open();

            SqlCommand command = new SqlCommand("getKhachToiDa", conection);
            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            string s = dt.Rows[0][0].ToString();
            int.TryParse(s, out soluongkhach);
            conection.Close();
            return soluongkhach;
        }
    }
}
