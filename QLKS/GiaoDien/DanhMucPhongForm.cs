using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class DanhMucPhongForm : Form
    {
        public DanhMucPhongForm()
        {
            InitializeComponent();
        }
        private void DanhMucPhongForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "TenPhong";
            dataGridView1.Columns[1].DataPropertyName = "TenLoaiPhong";
            dataGridView1.Columns[2].DataPropertyName = "DonGia";
            dataGridView1.Columns[3].DataPropertyName = "GhiChu";
            DataTable dt = new DataTable();
            DanhMucPhong LD = new DanhMucPhong();
            LD.LoadDanhMucPhong(dt);
            dataGridView1.DataSource = dt;
            setRowNumber(dataGridView1);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }


    }
}
