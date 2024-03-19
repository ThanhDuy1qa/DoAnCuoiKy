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

namespace DoAnCuoiKy
{
    public partial class fDangSanPham : Form
    SqlConnection conn = new SqlConnection();
    {
        public fDangSanPham()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string SQL = string.Format("INSERT INTO SanPhamBan(ID_SanPham, TenSanPham, GiaMua, GiaBan, NgayMua, NgayDang, MoTa, TinhTrang, ThuongHieu, PhuKien, NhomHang, SoLuong, ID_NguoiDang, Hinh) VALUES ('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}', '{10}', '{11}', '{12}', '{13}')", txtIDSanPham.Text, txtGiaMua.Text, dtpNgayMua, dtpNgayDang, txtGiaBan.Text, txtMoTa.Text, txtTinhTrang.Text, txtThuongHieu.Text, txtPhuKien.Text, cbbNhomHang.Text, mudSoLuong.Value, lblShowIDNguoiDang.Text, ptbSanPham);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Them thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        private void btnThemHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                // Kiểm tra xem tệp đã chọn có phải là một hình ảnh hay không
                try
                {
                    // Tạo một đối tượng hình ảnh từ đường dẫn đã chọn
                    Image image = Image.FromFile(imagePath);

                    // Hiển thị hình ảnh trong một PictureBox
                    pbHinh.Image = image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở tệp hình ảnh: " + ex.Message);
                }
            }
        }

    }
}
