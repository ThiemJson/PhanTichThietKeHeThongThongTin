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
    public partial class Quanlyhoadon : Form
    {
        public Quanlyhoadon()
        {
            InitializeComponent();
            this.hoadon_time_ngaydongtien.Format = DateTimePickerFormat.Custom;
            this.hoadon_time_ngaydongtien.CustomFormat = "yyyy/MM/dd";
            DataConfig.openConnection();
            renderData();
        }

        void renderData()
        {
            this.hoadon_datagrid.DataSource = null;
            this.Hoadon_renderData();
        }

        bool Hoadon_validate()
        {
            if (this.hoadon_txt_chisodiencuoi.Text.ToString() == "" ||
                this.hoadon_txt_chisodiendau.Text.ToString() == "" ||
                this.hoadon_txt_chisonuoccuoi.Text.ToString() == "" ||
                this.hoadon_txt_chisonuocdau.Text.ToString() == "" ||
                this.hoadon_txt_manhanvien.Text.ToString() == "" ||
                this.hoadon_txt_maphong.Text.ToString() == "" ||
                this.hoadon_txt_sohoadon.Text.ToString() == ""
                )
            {
                return false;
            }
            return true;
        }

        void Hoadon_renderData()
        {
            DataConfig.query = "SELECT * FROM HOADON";
            DataConfig.adapter = new SqlDataAdapter(DataConfig.query, DataConfig.Conn);
            DataConfig.table = new DataTable();
            DataConfig.adapter.Fill(DataConfig.table);

            this.hoadon_datagrid.DataSource = DataConfig.table;
        }
        private void hoadon_btn_them_Click(object sender, EventArgs e)
        {
            if (this.Hoadon_validate())
            {
                string mahoadon = this.hoadon_txt_sohoadon.Text.ToString();
                string maphong = this.hoadon_txt_maphong.Text.ToString();
                string manhanvien = this.hoadon_txt_manhanvien.Text.ToString();
                string chisodiendau = this.hoadon_txt_chisodiendau.Text.ToString();
                string chisodiencuoi = this.hoadon_txt_chisodiencuoi.Text.ToString();
                string chisonuocdau = this.hoadon_txt_chisonuocdau.Text.ToString();
                string chisonuocuoi = this.hoadon_txt_chisonuoccuoi.Text.ToString();
                string ngaydongtien = this.hoadon_time_ngaydongtien.Value.ToShortDateString().ToString();

                DataConfig.query = $"INSERT INTO HOADON(soHD,maP,maNV,ngaydongtien,chisodiendau,chisodiencuoi,dongiadien,chisonuocdau,chisonuoccuoi,dongianuoc) VALUES(N'{mahoadon}',N'{maphong}',N'{manhanvien}',N'{ngaydongtien}',{Int32.Parse(chisodiendau)},{Int32.Parse(chisodiencuoi)},4,{Int32.Parse(chisonuocdau)},{Int32.Parse(chisonuocuoi)},25);";
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
            this.hoadon_txt_sohoadon.Text = "";
            this.hoadon_txt_maphong.Text = "";
            this.hoadon_txt_manhanvien.Text = "";
            this.hoadon_txt_chisodiencuoi.Text = "";
            this.hoadon_txt_chisodiendau.Text = "";
            this.hoadon_txt_chisonuocdau.Text = "";
            this.hoadon_txt_chisonuoccuoi.Text = "";
        }

        private void hoadon_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = hoadon_datagrid.Rows[e.RowIndex];

            this.hoadon_txt_sohoadon.Text = row.Cells[0].Value.ToString();
            this.hoadon_txt_maphong.Text = row.Cells[1].Value.ToString();
            this.hoadon_txt_manhanvien.Text = row.Cells[2].Value.ToString();

            this.hoadon_time_ngaydongtien.Text = row.Cells[3].Value.ToString();

            this.hoadon_txt_chisodiendau.Text = row.Cells[4].Value.ToString();
            this.hoadon_txt_chisodiencuoi.Text = row.Cells[5].Value.ToString();

            this.hoadon_txt_chisonuocdau.Text = row.Cells[7].Value.ToString();
            this.hoadon_txt_chisonuoccuoi.Text = row.Cells[8].Value.ToString();

            this.hoadon_txt_tongtien.Text = row.Cells[10].Value.ToString() + ".000 VNĐ";

        }
    }
}
