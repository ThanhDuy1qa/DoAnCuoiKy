using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class fGiaoDienChinh : Form
    {
        public fGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void dangSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fDangSanPham f = new fDangSanPham();
            f.Show();
        }
    }
}
