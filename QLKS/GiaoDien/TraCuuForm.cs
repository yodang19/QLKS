using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS.GiaoDien
{
    public partial class TraCuuForm : Form
    {
        public TraCuuForm()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns[0].DataPropertyName = "TenPhong";
                dataGridView1.Columns[1].DataPropertyName = "TenLoaiPhong";
                dataGridView1.Columns[2].DataPropertyName = "DonGia";
                dataGridView1.Columns[3].DataPropertyName = "TinhTrang";
                DataTable dt = new DataTable();
                QLKS.Controller.TraCuu TC = new Controller.TraCuu();
                string tp, lp, dg, tt;
                tp = checknull(txtTenPhong.Text.ToString());
                lp = checknull(txtLoaiPhong.Text.ToString());
                dg = checknull(txtDonGia.Text.ToString());
                tt = checknull(txtTinhTrang.Text.ToString());
                TC.TraCuuPhong(tp, lp, dg, tt, dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {
                dataGridView1.DataSource = null;
            }
        }
        private string checknull(string s)
        {
            if (s == "")
                return null;
            return s;
        }
    }
}
