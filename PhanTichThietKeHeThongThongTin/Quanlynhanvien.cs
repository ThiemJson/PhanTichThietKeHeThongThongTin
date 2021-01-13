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
    public partial class Quanlynhanvien : Form
    {
        public Quanlynhanvien()
        {
            InitializeComponent();
            DataConfig.openConnection();
            renderData();
        }

        void renderData()
        {
            this.nhanvien_datagrid.DataSource = null;
            this.Nhanvien_renderData();
        }

        bool Nhanvienquanly_validate()
        {
            if (this.nhanvien_txt_chucdanh.Text.ToString() == "" ||
                this.nhanvien_txt_email.Text.ToString() == "" ||
                this.nhanvien_txt_tennhanvien.Text.ToString() == "" ||
                this.nhanvien_txt_dienthoai.Text.ToString() == "" ||
                this.nhanvien_txt_manhanvien.Text.ToString() == "" ||
                this.nhanvien_txt_diachi.Text.ToString() == ""
                )
            {
                return false;
            };
            return true;
        }
        private void nhanvien_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = nhanvien_datagrid.Rows[e.RowIndex];

            this.nhanvien_txt_manhanvien.Text = row.Cells[0].Value.ToString();
            this.nhanvien_txt_tennhanvien.Text = row.Cells[1].Value.ToString();
            this.nhanvien_txt_email.Text = row.Cells[2].Value.ToString();

            this.nhanvien_txt_diachi.Text = row.Cells[3].Value.ToString();
            this.nhanvien_txt_dienthoai.Text = row.Cells[4].Value.ToString();


            this.nhanvien_txt_chucdanh.Text = row.Cells[6].Value.ToString();
            if (row.Cells[5].Value.ToString() == "Nam") { this.nhanvien_rad_nam.Checked = true; this.nhanvien_rad_nu.Checked = false; } else { this.nhanvien_rad_nam.Checked = false; this.nhanvien_rad_nu.Checked = true; };
        }
        void Nhanvien_renderData()
        {
            DataConfig.query = "SELECT * FROM nhanvien";
            DataConfig.adapter = new SqlDataAdapter(DataConfig.query, DataConfig.Conn);
            DataConfig.table = new DataTable();
            DataConfig.adapter.Fill(DataConfig.table);

            this.nhanvien_datagrid.DataSource = DataConfig.table;
        }
        private void nhanvien_btn_them_Click(object sender, EventArgs e)
        {

            string manhanvien = this.nhanvien_txt_manhanvien.Text.ToString();
            string tennhanvien = this.nhanvien_txt_tennhanvien.Text.ToString();
            string email = this.nhanvien_txt_email.Text.ToString();
            string diachi = this.nhanvien_txt_diachi.Text.ToString();
            string dienthoai = this.nhanvien_txt_dienthoai.Text.ToString();
            string gioitinh = (this.nhanvien_rad_nam.Checked == true) ? "Nam" : "Nữ";
            string chucdanh = this.nhanvien_txt_chucdanh.Text.ToString();

            DataConfig.query = $"INSERT INTO NHANVIENQUANLY VALUES(N'{manhanvien}',N'{tennhanvien}',N'{email}',N'{diachi}',{dienthoai}, N'{gioitinh}',N'{chucdanh}');";
            DataConfig.cmd = new SqlCommand(DataConfig.query, DataConfig.Conn);

            DataConfig.cmd.ExecuteNonQuery();
            this.clearData();
            this.renderData();
        }

        void clearData()
        {
            this.nhanvien_txt_manhanvien.Text = "";
            this.nhanvien_txt_tennhanvien.Text = "";
            this.nhanvien_txt_email.Text = "";
            this.nhanvien_txt_diachi.Text = "";
            this.nhanvien_txt_dienthoai.Text = "";
            this.nhanvien_txt_chucdanh.Text = "";
        }

        private void nhanvien_btn_them_Click_1(object sender, EventArgs e)
        {
            string manhanvien = this.nhanvien_txt_manhanvien.Text.ToString();
            string tennhanvien = this.nhanvien_txt_tennhanvien.Text.ToString();
            string email = this.nhanvien_txt_email.Text.ToString();
            string diachi = this.nhanvien_txt_diachi.Text.ToString();
            string dienthoai = this.nhanvien_txt_dienthoai.Text.ToString();
            string gioitinh = (this.nhanvien_rad_nam.Checked == true) ? "Nam" : "Nữ";
            string chucdanh = this.nhanvien_txt_chucdanh.Text.ToString();

            DataConfig.query = $"INSERT INTO NHANVIEN VALUES(N'{manhanvien}',N'{tennhanvien}',N'{email}',N'{diachi}',{dienthoai}, N'{gioitinh}',N'{chucdanh}');";
            DataConfig.cmd = new SqlCommand(DataConfig.query, DataConfig.Conn);

            DataConfig.cmd.ExecuteNonQuery();
            this.clearData();
            this.renderData();
            MessageBox.Show("Thêm thông tin nhân viên thành công !", "Thông báo", MessageBoxButtons.OK);
        }

        private void nhanvien_btn_xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thông tin nhân viên thành công !", "Thông báo", MessageBoxButtons.OK);
        }

        private void nhanvien_btn_sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thay dổi thông tin nhân viên thành công !", "Thông báo", MessageBoxButtons.OK);
        }

        private void thongke_btn_thongketinhtrangphong_Click(object sender, EventArgs e)
        {
            DataConfig.query = "SELECT * FROM phong";
            DataConfig.adapter = new SqlDataAdapter(DataConfig.query, DataConfig.Conn);
            DataConfig.table = new DataTable();
            DataConfig.adapter.Fill(DataConfig.table);

            this.thongke_datagrid.DataSource = DataConfig.table;
        }

        private void thongke_btn_thongkesoluonghopdong_Click(object sender, EventArgs e)
        {
            string ngaybatdau = this.thongke_time_ngaybatdau.Value.ToShortDateString().ToString();
            string ngayketthuc = this.thongke_time_ngayketthuc.Value.ToShortDateString().ToString();

            DataConfig.query = $"SELECT * FROM HOPDONG WHERE ngaylaphopdong > N'{ngaybatdau}' and ngaylaphopdong < N'{ngayketthuc}'";
            DataConfig.adapter = new SqlDataAdapter(DataConfig.query, DataConfig.Conn);
            DataConfig.table = new DataTable();
            DataConfig.adapter.Fill(DataConfig.table);

            this.thongke_datagrid.DataSource = DataConfig.table;
        }

        private void thongke_btn_baocaodoanhthu_Click(object sender, EventArgs e)
        {
            string ngaybatdau = this.thongke_time_ngaybatdau.Value.ToShortDateString().ToString();
            string ngayketthuc = this.thongke_time_ngayketthuc.Value.ToShortDateString().ToString();
            DataConfig.query = $"SELECT SUM(tienphaidong) as TongSoTienThu  FROM HOPDONG WHERE ngaylaphopdong > N'{ngaybatdau}' and ngaylaphopdong < N'{ngayketthuc}'";

            DataConfig.adapter = new SqlDataAdapter(DataConfig.query, DataConfig.Conn);
            DataConfig.table = new DataTable();
            DataConfig.adapter.Fill(DataConfig.table);

            this.thongke_datagrid.DataSource = DataConfig.table;
        }

        private void thongke_btn_baocaodoanhthuhoadon_Click(object sender, EventArgs e)
        {
            string ngaybatdau = this.thongke_time_ngaybatdau.Value.ToShortDateString().ToString();
            string ngayketthuc = this.thongke_time_ngayketthuc.Value.ToShortDateString().ToString();
            DataConfig.query = $"SELECT SUM(tongchiphidiennuoc) as TongSoTienThu  FROM HOADON WHERE ngaydongtien > N'{ngaybatdau}' and ngaydongtien < N'{ngayketthuc}'";

            DataConfig.adapter = new SqlDataAdapter(DataConfig.query, DataConfig.Conn);
            DataConfig.table = new DataTable();
            DataConfig.adapter.Fill(DataConfig.table);

            this.thongke_datagrid.DataSource = DataConfig.table;
        }
    }
}
