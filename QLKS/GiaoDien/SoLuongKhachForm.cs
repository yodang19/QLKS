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
    public partial class SoLuongKhachForm : Form
    {
        public SoLuongKhachForm()
        {
            InitializeComponent();
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            try
            {
                QLKS.Controller.Soluongkhach slk = new Controller.Soluongkhach();
                slk.SuaSoLuongKhach(txtSLK.Text.ToString());
                MessageBox.Show("Điều chỉnh số lượng khác tối đa thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Điều chỉnh số lượng khác tối đa không thành công");
                this.Close();
            }
        }

        private void SoLuongKhachForm_Load(object sender, EventArgs e)
        {
            QLKS.Controller.Soluongkhach slk = new Controller.Soluongkhach();
            int dem = slk.SoLuongKhach();
            label1.Text +=" " + dem.ToString();
        }
    }
}
