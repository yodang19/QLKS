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
    public partial class ThuePhongForm : Form
    {
        public ThuePhongForm()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            QLKS.Controller.Soluongkhach slk = new Controller.Soluongkhach();
            int dem = slk.SoLuongKhach();
            if(dataGridView1.Rows.Count>dem)
            {
                MessageBox.Show(String.Format("Một phòng chỉ được tối đa {0} người",dem.ToString()),dem.ToString());
            }
            else
            {
                try
                {
                    PhieuThuePhong PTP = new PhieuThuePhong();
                    int maPTP = PTP.LapPhieuThuePhong(txtPhong.Text.ToString(), txtNgayBatDau.Text.ToString(), dataGridView1.Rows.Count - 1);
                    List<int> dsmakhachhang = new List<int>();
                    int makhachhang;

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        makhachhang = PTP.ThemKhachHang(dataGridView1.Rows[i].Cells[0].Value.ToString(),
                            dataGridView1.Rows[i].Cells[1].Value.ToString(),
                            dataGridView1.Rows[i].Cells[2].Value.ToString(),
                            dataGridView1.Rows[i].Cells[3].Value.ToString());
                        dsmakhachhang.Add(makhachhang);
                    }

                    foreach (int item in dsmakhachhang)
                    {
                        PTP.ThemChiTietPhieuThuePhong(item.ToString(), maPTP.ToString());
                    }
                    MessageBox.Show("Lặp Phiếu Thuê Phòng Thành Công");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Lặp Phiếu Thuê Phòng Không Thành Công");
                    this.Close();
                }
            }
        }
    }
}
