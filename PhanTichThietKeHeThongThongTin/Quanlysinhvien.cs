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

namespace PhanTichThietKeHeThongThongTin
{
    public partial class Quanlysinhvien : Form
    {
        public Quanlysinhvien()
        {
            InitializeComponent();

            this.sinhvien_time_ngaysinh.Format = DateTimePickerFormat.Custom;
            this.sinhvien_time_ngaysinh.CustomFormat = "yyyy/MM/dd";
            DataConfig.openConnection();
            renderData();
        }

        void renderData()
        {
            this.sinhvien_datagrid.DataSource = null;
            this.Sinhvien_renderData();
        }

        void clearData()
        {
            this.sinhvien_txt_masinhvien.Text = "";
            this.sinhvien_txt_hoten.Text = "";
            this.sinhvien_txt_sodienthoai.Text = "";
            this.sinhvien_txt_diachi.Text = "";
        }

        void Sinhvien_renderData()
        {
            DataConfig.query = "SELECT * FROM sinhvien";
            DataConfig.adapter = new SqlDataAdapter(DataConfig.query, DataConfig.Conn);
            DataConfig.table = new DataTable();
            DataConfig.adapter.Fill(DataConfig.table);

            this.sinhvien_datagrid.DataSource = DataConfig.table;
        }

        private void sinhvien_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = sinhvien_datagrid.Rows[e.RowIndex];
            this.sinhvien_txt_masinhvien.Text = row.Cells[0].Value.ToString();
            this.sinhvien_txt_hoten.Text = row.Cells[3].Value.ToString();
            this.sinhvien_time_ngaysinh.Text = row.Cells[4].Value.ToString();
            this.sinhvien_txt_diachi.Text = row.Cells[5].Value.ToString();
            _ = (row.Cells[6].Value.ToString() == "Nam") ? this.sinhvien_rad_nam.Checked = true : this.sinhvien_rad_nu.Checked = true;
            this.sinhvien_txt_sodienthoai.Text = row.Cells[7].Value.ToString();
        }

        private void sinhvien_btn_them_Click(object sender, EventArgs e)
        {
            //if (this.Sinhvien_validate())
            //{
            //    string maSV = this.sinhvien_txt_masinhvien.Text.ToString();
            //    string hoten = this.sinhvien_txt_hoten.Text.ToString();

            //    string dienthoai = this.sinhvien_txt_sodienthoai.Text.ToString();
            //    string ngaysinh = this.sinhvien_time_ngaysinh.Value.ToShortDateString().ToString();
            //    string gioitinh = (this.sinhvien_rad_nam.Checked == true) ? "Nam" : "Nữ";
            //    string diachi = this.sinhvien_txt_diachi.Text.ToString();

            //    DataConfig.query = $"INSERT INTO SINHVIEN VALUES(N'{maSV}', N'{hoten}',N'{ngaysinh}',N'{dienthoai}'),N'{diachi}', N'{gioitinh}';";
            //    DataConfig.cmd = new SqlCommand(DataConfig.query, DataConfig.Conn);

            //    DataConfig.cmd.ExecuteNonQuery();
            //    //MessageBox.Show(this.sinhvien_time_ngaysinh.Value.ToShortDateString().ToString(), "Nogthing");
            //}
            //this.clearData();
            //this.renderData();
            MessageBox.Show("Thêm thông tin sinh viên thành công !", "Thông báo", MessageBoxButtons.OK);
        }
        bool Sinhvien_validate()
        {
            if (this.sinhvien_txt_diachi.Text.ToString() == "" ||
                this.sinhvien_txt_masinhvien.Text.ToString() == "" ||
                this.sinhvien_txt_sodienthoai.Text.ToString() == "" ||
                this.sinhvien_txt_hoten.Text.ToString() == "")
            {
                return false;
            }
            return true;
        }

        private void sinhvien_btn_xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thông tin sinh viên thành công !", "Thông báo", MessageBoxButtons.OK);
        }

        private void sinhvien_btn_sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thay đổi thông tin sinh viên thành công !", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
