using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoAnCuoiKy
{
    public partial class fGiaoDienChinh : Form
    {
        UCSanPham uCSanPham = new UCSanPham();
        SqlConnection conn = new SqlConnection();
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
        private void LoadSanPham()
        {
            // Clear existing controls in FlowLayoutPanel
            flpBangSanPham.Controls.Clear();

            // Connect to SQL Server and execute query
            
            string query = "SELECT TenSanPham, GiaBan, NgayDang, TinhTrang, Hinh FROM SanPhamBan";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                {
                    uCSanPham.TenSanPham = reader["TenSanPham"].ToString();
                    uCSanPham.GiaBan = Convert.ToDouble(reader["GiaBan"]);
                    uCSanPham.UploadDate = Convert.ToDateTime(reader["NgayDang"]);
                    uCSanPham.KhuVuc = reader["KhuVuc"].ToString();
                    uCSanPham.Image = (Image)reader["Hinh"];
                    // Add the user control to FlowLayoutPanel
                    flpBangSanPham.Controls.Add(uCSanPham);
                }
            }

        private void fGiaoDienChinh_Load(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            {
                string keyword = txtTim.Text.Trim();

                if (!string.IsNullOrEmpty(keyword))
                {
                    TimSanPham(keyword);
                }
                else
                {
                    LoadSanPham();
                }
            }
        }
        private void TimSanPham(string keyword)
        {
            flpBangSanPham.Controls.Clear();
            string query = "SELECT TenSanPham, GiaBan, NgayDang, TinhTrang, Hinh FROM SanPhamBan";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                {
                // Set properties of the user control with data from the database
                uCSanPham.TenSanPham = reader["TenSanPham"].ToString();
                uCSanPham.GiaBan = Convert.ToDouble(reader["GiaBan"]);
                uCSanPham.UploadDate = Convert.ToDateTime(reader["NgayDang"]);
                uCSanPham.KhuVuc = reader["KhuVuc"].ToString();
                uCSanPham.Image = (Image)reader["Hinh"];
                // Add the user control to FlowLayoutPanel
                flpBangSanPham.Controls.Add(uCSanPham);
                }
            }
        }
    }
}
