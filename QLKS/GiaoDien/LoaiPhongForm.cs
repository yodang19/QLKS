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
    public partial class LoaiPhongForm : Form
    {
        public LoaiPhongForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoaiPhong_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "MaLoaiPhong";
            dataGridView1.Columns[1].DataPropertyName = "TenLoaiPhong";
            dataGridView1.Columns[2].DataPropertyName = "DonGia";
            DataTable dt = new DataTable();
            LoaiPhong LD = new LoaiPhong();
            LD.LoadLoaiPhong(dt);
            dataGridView1.DataSource = dt;
            setRowNumber(dataGridView1);
            txtLoaiPhong.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["MaLoaiPhong"].Value);
            txtTenLoaiPhong.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["TenLoaiPhong"].Value);
            txtDonGia.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["DonGia"].Value);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.ColumnIndex >=0)
            {
                txtLoaiPhong.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["MaLoaiPhong"].Value);
                txtTenLoaiPhong.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["TenLoaiPhong"].Value);
                txtDonGia.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["DonGia"].Value);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoaiPhong LP = new LoaiPhong();
            DataTable dt = new DataTable();
            string s = txtDonGia.Text.ToString();
            Decimal x = 0;
            Decimal.TryParse(s, out x);
            try
            {
                LP.ThemLoaiPhong(txtLoaiPhong.Text.ToString(),txtTenLoaiPhong.Text.ToString(), x);
                LP.LoadLoaiPhong(dt);
                dataGridView1.DataSource = dt;
                setRowNumber(dataGridView1);
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoaiPhong LP = new LoaiPhong();
            DataTable dt = new DataTable();
            string s = txtDonGia.Text.ToString();
            Decimal x = 0;
            Decimal.TryParse(s, out x);
            try
            {
                LP.SuaLoaiPhong(txtLoaiPhong.Text.ToString(), txtTenLoaiPhong.Text.ToString(), x);
                LP.LoadLoaiPhong(dt);
                dataGridView1.DataSource = dt;
                setRowNumber(dataGridView1);
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Sủa không thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LoaiPhong LP = new LoaiPhong();
            DataTable dt = new DataTable();
            try
            {
                LP.XoaLoaiPhong(txtLoaiPhong.Text.ToString());
                LP.LoadLoaiPhong(dt);
                dataGridView1.DataSource = dt;
                setRowNumber(dataGridView1);
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Xóa không thành công");
            }
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
