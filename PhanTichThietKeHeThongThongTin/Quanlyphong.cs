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
    public partial class Quanlyphong : Form
    {
        public Quanlyphong()
        {
            InitializeComponent();
            DataConfig.openConnection();
            renderData();
        }

        void renderData()
        {
            this.phong_datagrid.DataSource = null;
            this.Phong_renderData();
        }
        void Phong_renderData()
        {
            DataConfig.query = "SELECT * FROM phong";
            DataConfig.adapter = new SqlDataAdapter(DataConfig.query, DataConfig.Conn);
            DataConfig.table = new DataTable();
            DataConfig.adapter.Fill(DataConfig.table);

            this.phong_datagrid.DataSource = DataConfig.table;
        }

        bool Phong_validate()
        {
            if (this.phong_txt_sogiuong.Text.ToString() == "" || this.phong_txt_maphong.Text.ToString() == "")
            {
                return false;
            }
            return true;
        }
        private void phong_btn_them_Click(object sender, EventArgs e)
        {
            if (this.Phong_validate())
            {
                string maPhong = this.phong_txt_maphong.Text.ToString();
                string sogiuong = this.phong_txt_sogiuong.Text.ToString();
                string mota = this.phong_txt_mota.Text.ToString();


                DataConfig.query = $"INSERT INTO PHONG(maP,sogiuong,soluongSV,motakhac) VALUES(,N'{maPhong}',{Int32.Parse(sogiuong)},0, N'{mota}');";
                DataConfig.cmd = new SqlCommand(DataConfig.query, DataConfig.Conn);
                MessageBox.Show(DataConfig.query, "Thongbao");
                DataConfig.cmd.ExecuteNonQuery();
            }
            this.clearData();
            this.renderData();
        }

        void clearData()
        {
            this.phong_txt_maphong.Text = "";
            this.phong_txt_sogiuong.Text = "";
            this.phong_txt_mota.Text = "";
        }

        private void phong_btn_them_Click_1(object sender, EventArgs e)
        {
            string maphong = this.phong_txt_maphong.Text;
            string sogiuong = this.phong_txt_sogiuong.Text;
            string sosinhvien = this.phong_txt_soluongisnhvien.Text;
            string motakhac = this.phong_txt_mota.Text;

            DataConfig.query = $"INSERT INTO PHONG VALUES(N'{maphong}', {sogiuong},{sosinhvien},N'{motakhac}');";
            //MessageBox.Show(DataConfig.query, "Thông báo", MessageBoxButtons.OK);
            DataConfig.cmd = new SqlCommand(DataConfig.query, DataConfig.Conn);

            DataConfig.cmd.ExecuteNonQuery();
            this.clearData();
            this.renderData();
            MessageBox.Show("Thêm thông tin phòng thành công !", "Thông báo", MessageBoxButtons.OK);
        }

        private void phong_btn_xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thông tin phòng thành công !", "Thông báo", MessageBoxButtons.OK);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phong_btn_sua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thay đổi thông tin phòng thành công !", "Thông báo", MessageBoxButtons.OK);
        }
    }
    }
