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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDanhMucPhong_Click(object sender, EventArgs e)
        {
            DanhMucPhongForm DMPForm = new DanhMucPhongForm();
            DMPForm.ShowDialog();
        }

        private void btnPhieuThuePhong_Click(object sender, EventArgs e)
        {
            ThuePhongForm TPForm = new ThuePhongForm();
            TPForm.ShowDialog();
        }

        private void btnTraCuuPhong_Click(object sender, EventArgs e)
        {
            TraCuuForm TCForm = new TraCuuForm();
            TCForm.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonForm HDForm = new HoaDonForm();
            HDForm.ShowDialog();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoForm BCForm = new BaoCaoForm();
            BCForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].DataPropertyName = "TenPhong";
            dataGridView1.Columns[1].DataPropertyName = "TenLoaiPhong";
            dataGridView1.Columns[2].DataPropertyName = "DonGia";
            dataGridView1.Columns[3].DataPropertyName = "TinhTrang";
            DataTable dt = new DataTable();
            DanhMucPhong LD = new DanhMucPhong();
            LD.LoadDanhSachPhong(dt);
            dataGridView1.DataSource = dt;
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiPhongForm LPForm = new LoaiPhongForm();
            LPForm.ShowDialog();
        }

        private void sốLượngKhách1PhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoLuongKhachForm slk = new SoLuongKhachForm();
            slk.ShowDialog();
        }
    }
}
