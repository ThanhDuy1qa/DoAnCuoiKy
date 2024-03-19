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
    public partial class UCSanPham : UserControl
    {
        private PictureBox hinhSanPham;
        private Label tenSanPham;
        private Label giaBan;
        private Label khuVuc;
        private Label thoiGianDang;

        // Properties to set the product information
        public string TenSanPham { get => tenSanPham.Text; set => tenSanPham.Text = value; }
        public double GiaBan { get => Convert.ToDouble(giaBan.Text); set => giaBan.Text = value.ToString(); }
        public DateTime UploadDate { get => Convert.ToDateTime(thoiGianDang.Text); set => thoiGianDang.Text = value.ToString(); }
        public string KhuVuc { get => lbKhuVuc.Text; set => lbKhuVuc.Text = value; }
        public Image Image { get => hinhSanPham.Image; set => hinhSanPham.Image = value; }

        public UCSanPham()
        {
            InitializeComponent();
        }

        private void UCSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
