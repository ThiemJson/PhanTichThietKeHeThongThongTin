namespace PhanTichThietKeHeThongThongTin
{
    partial class Quanlyphong
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.phong_datagrid = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.phong_btn_sua = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.phong_txt_mota = new System.Windows.Forms.TextBox();
            this.phong_btn_xoa = new System.Windows.Forms.Button();
            this.phong_btn_them = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.phong_txt_soluongisnhvien = new System.Windows.Forms.TextBox();
            this.phong_txt_sogiuong = new System.Windows.Forms.TextBox();
            this.phong_txt_maphong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.phong_datagrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // phong_datagrid
            // 
            this.phong_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phong_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phong_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phong_datagrid.Location = new System.Drawing.Point(0, 142);
            this.phong_datagrid.Name = "phong_datagrid";
            this.phong_datagrid.Size = new System.Drawing.Size(724, 201);
            this.phong_datagrid.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.phong_btn_sua);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.phong_txt_mota);
            this.panel4.Controls.Add(this.phong_btn_xoa);
            this.panel4.Controls.Add(this.phong_btn_them);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.phong_txt_soluongisnhvien);
            this.panel4.Controls.Add(this.phong_txt_sogiuong);
            this.panel4.Controls.Add(this.phong_txt_maphong);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(724, 142);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // phong_btn_sua
            // 
            this.phong_btn_sua.Location = new System.Drawing.Point(500, 64);
            this.phong_btn_sua.Name = "phong_btn_sua";
            this.phong_btn_sua.Size = new System.Drawing.Size(75, 23);
            this.phong_btn_sua.TabIndex = 33;
            this.phong_btn_sua.Text = "Sửa";
            this.phong_btn_sua.UseVisualStyleBackColor = true;
            this.phong_btn_sua.Click += new System.EventHandler(this.phong_btn_sua_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Mô tả khác";
            // 
            // phong_txt_mota
            // 
            this.phong_txt_mota.Location = new System.Drawing.Point(390, 29);
            this.phong_txt_mota.Name = "phong_txt_mota";
            this.phong_txt_mota.Size = new System.Drawing.Size(293, 20);
            this.phong_txt_mota.TabIndex = 31;
            // 
            // phong_btn_xoa
            // 
            this.phong_btn_xoa.Location = new System.Drawing.Point(399, 64);
            this.phong_btn_xoa.Name = "phong_btn_xoa";
            this.phong_btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.phong_btn_xoa.TabIndex = 30;
            this.phong_btn_xoa.Text = "Xóa";
            this.phong_btn_xoa.UseVisualStyleBackColor = true;
            this.phong_btn_xoa.Click += new System.EventHandler(this.phong_btn_xoa_Click);
            // 
            // phong_btn_them
            // 
            this.phong_btn_them.Location = new System.Drawing.Point(296, 64);
            this.phong_btn_them.Name = "phong_btn_them";
            this.phong_btn_them.Size = new System.Drawing.Size(75, 23);
            this.phong_btn_them.TabIndex = 29;
            this.phong_btn_them.Text = "Thêm";
            this.phong_btn_them.UseVisualStyleBackColor = true;
            this.phong_btn_them.Click += new System.EventHandler(this.phong_btn_them_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Số lượng sinh viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Số giường";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Mã phòng";
            // 
            // phong_txt_soluongisnhvien
            // 
            this.phong_txt_soluongisnhvien.Enabled = false;
            this.phong_txt_soluongisnhvien.Location = new System.Drawing.Point(123, 88);
            this.phong_txt_soluongisnhvien.Name = "phong_txt_soluongisnhvien";
            this.phong_txt_soluongisnhvien.Size = new System.Drawing.Size(121, 20);
            this.phong_txt_soluongisnhvien.TabIndex = 22;
            this.phong_txt_soluongisnhvien.Text = "0";
            // 
            // phong_txt_sogiuong
            // 
            this.phong_txt_sogiuong.Location = new System.Drawing.Point(123, 62);
            this.phong_txt_sogiuong.Name = "phong_txt_sogiuong";
            this.phong_txt_sogiuong.Size = new System.Drawing.Size(121, 20);
            this.phong_txt_sogiuong.TabIndex = 21;
            // 
            // phong_txt_maphong
            // 
            this.phong_txt_maphong.Location = new System.Drawing.Point(123, 28);
            this.phong_txt_maphong.Name = "phong_txt_maphong";
            this.phong_txt_maphong.Size = new System.Drawing.Size(119, 20);
            this.phong_txt_maphong.TabIndex = 17;
            // 
            // Quanlyphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 343);
            this.Controls.Add(this.phong_datagrid);
            this.Controls.Add(this.panel4);
            this.Name = "Quanlyphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng ký túc xá";
            ((System.ComponentModel.ISupportInitialize)(this.phong_datagrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView phong_datagrid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox phong_txt_mota;
        private System.Windows.Forms.Button phong_btn_xoa;
        private System.Windows.Forms.Button phong_btn_them;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox phong_txt_soluongisnhvien;
        private System.Windows.Forms.TextBox phong_txt_sogiuong;
        private System.Windows.Forms.TextBox phong_txt_maphong;
        private System.Windows.Forms.Button phong_btn_sua;
    }
}