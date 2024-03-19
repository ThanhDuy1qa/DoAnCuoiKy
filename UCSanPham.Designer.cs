namespace DoAnCuoiKy
{
    partial class UCSanPham
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbTenSanPham = new System.Windows.Forms.Label();
            this.lbGiaBan = new System.Windows.Forms.Label();
            this.ptbAnhSanPham = new System.Windows.Forms.PictureBox();
            this.lbKhuVuc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbThoiGianDang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.AutoSize = true;
            this.lbTenSanPham.Location = new System.Drawing.Point(26, 133);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(0, 16);
            this.lbTenSanPham.TabIndex = 1;
            // 
            // lbGiaBan
            // 
            this.lbGiaBan.AutoSize = true;
            this.lbGiaBan.Location = new System.Drawing.Point(26, 160);
            this.lbGiaBan.Name = "lbGiaBan";
            this.lbGiaBan.Size = new System.Drawing.Size(0, 16);
            this.lbGiaBan.TabIndex = 4;
            // 
            // ptbAnhSanPham
            // 
            this.ptbAnhSanPham.Image = global::DoAnCuoiKy.Properties.Resources.z4934245855617_16130f0bf2eb31b0c797d45d87426190;
            this.ptbAnhSanPham.Location = new System.Drawing.Point(29, 3);
            this.ptbAnhSanPham.Name = "ptbAnhSanPham";
            this.ptbAnhSanPham.Size = new System.Drawing.Size(114, 112);
            this.ptbAnhSanPham.TabIndex = 0;
            this.ptbAnhSanPham.TabStop = false;
            // 
            // lbKhuVuc
            // 
            this.lbKhuVuc.AutoSize = true;
            this.lbKhuVuc.Location = new System.Drawing.Point(128, 186);
            this.lbKhuVuc.Name = "lbKhuVuc";
            this.lbKhuVuc.Size = new System.Drawing.Size(0, 16);
            this.lbKhuVuc.TabIndex = 6;
            // 
            // lbThoiGianDang
            // 
            this.lbThoiGianDang.AutoSize = true;
            this.lbThoiGianDang.Location = new System.Drawing.Point(26, 186);
            this.lbThoiGianDang.Name = "lbThoiGianDang";
            this.lbThoiGianDang.Size = new System.Drawing.Size(0, 16);
            this.lbThoiGianDang.TabIndex = 7;
            // 
            // UCSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbThoiGianDang);
            this.Controls.Add(this.lbKhuVuc);
            this.Controls.Add(this.lbGiaBan);
            this.Controls.Add(this.lbTenSanPham);
            this.Controls.Add(this.ptbAnhSanPham);
            this.Name = "UCSanPham";
            this.Size = new System.Drawing.Size(241, 230);
            this.Load += new System.EventHandler(this.UCSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAnhSanPham;
        private System.Windows.Forms.Label lbTenSanPham;
        private System.Windows.Forms.Label lbGiaBan;
        private System.Windows.Forms.Label lbKhuVuc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbThoiGianDang;
    }
}
