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
    public partial class Quanlyhopdong : Form
    {
        public Quanlyhopdong()
        {
            InitializeComponent();
            DataConfig.openConnection();
            renderData();
        }

        void renderData()
        {
            this.hopdong_datagrid.DataSource = null;
            this.Hopdong_renderData();
        }

        void Hopdong_renderData()
        {
            DataConfig.query = "SELECT * FROM HOPDONG";
            DataConfig.adapter = new SqlDataAdapter(DataConfig.query, DataConfig.Conn);
            DataConfig.table = new DataTable();
            DataConfig.adapter.Fill(DataConfig.table);

            this.hopdong_datagrid.DataSource = DataConfig.table;
        }
        private void hopdong_btn_them_Click(object sender, EventArgs e)
        {
            if (Hopdong_validate())
            {
                string mahopdong = this.hopdong_txt_mahopdong.Text.ToString();
                string masinhvien = this.hopdong_txt_masinhvien.Text.ToString();
                string manhanvien = this.hopdong_txt_manhanvien.Text.ToString();

                string ngaybatdauthue = this.hopdong_time_ngaybatdauthue.Value.ToShortDateString().ToString();
                string ngayketthucthue = this.hopdong_time_ngayketthucthue.Value.ToShortDateString().ToString();
                string ngaylaphopdong = this.hopdong_time_ngaylaphopdong.Value.ToShortDateString().ToString();

                DataConfig.query = $"INSERT INTO HOPDONG(maHD, maSV,maNV,ngaybatdauthue,ngayketthucthue ,giaphong, ngaylaphopdong) VALUES(N'{mahopdong}',N'{masinhvien}',N'{manhanvien}',N'{ngaybatdauthue}',N'{ngayketthucthue}',10,N'{ngaylaphopdong}');";
                DataConfig.cmd = new SqlCommand(DataConfig.query, DataConfig.Conn);
                try
                {
                    DataConfig.cmd.ExecuteNonQuery();
                }
                catch
                {
                    //TODO
                }
            }
            this.clearData();
            this.renderData();
        }
        void clearData()
        {
            this.hopdong_txt_mahopdong.Text = "";
            this.hopdong_txt_masinhvien.Text = "";
            this.hopdong_txt_manhanvien.Text = "";
        }

        private void hopdong_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = hopdong_datagrid.Rows[e.RowIndex];

            this.hopdong_txt_mahopdong.Text = row.Cells[0].Value.ToString();
            this.hopdong_txt_masinhvien.Text = row.Cells[1].Value.ToString();
            this.hopdong_txt_manhanvien.Text = row.Cells[2].Value.ToString();

            this.hopdong_time_ngaybatdauthue.Text = row.Cells[3].Value.ToString();
            this.hopdong_time_ngaybatdauthue.Text = row.Cells[4].Value.ToString();

            this.hopdong_time_ngaylaphopdong.Text = row.Cells[6].Value.ToString();

            this.hopdong_txt_tongtien.Text = row.Cells[7].Value.ToString() + ".000 VNĐ";
        }

        bool Hopdong_validate()
        {
            if (this.hopdong_txt_mahopdong.Text.ToString() == "" ||
                this.hopdong_txt_manhanvien.Text.ToString() == "" ||
                this.hopdong_txt_masinhvien.Text.ToString() == "")
            {
                return false;
            }
            return true;
        }
    }
}
