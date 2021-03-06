﻿using System;
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
    public partial class Form1 : Form
    {
        private string phanquyen;
        private SqlDataReader dataReader = null;
        public Form1()
        {
            InitializeComponent();
            DataConfig.openConnection();
        }

        private void dangnhap_btn_submit_Click(object sender, EventArgs e)
        {
            if (!validateForm())
            {
                this.clearData();
                return;
            }

            if (checkAuth())
            {
                if(this.phanquyen == "canboquanly")
                {
                    Quanlynhanvien quanlynhanvien = new Quanlynhanvien();
                    quanlynhanvien.Show();
                    this.Hide();
                    return;
                }
                dataReader.Close();
                DataConfig.query = $"SELECT * FROM nhanvien WHERE email = N'{this.dangnhap_email.Text}'";
                // Tạo câu lệnh Command
                DataConfig.cmd = new SqlCommand(DataConfig.query, DataConfig.Conn);

                // Lấy dữ liệu đưa vào Datareader
                dataReader = DataConfig.cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if(((string)dataReader["email"]) == this.dangnhap_email.Text)
                    {
                        switch (((string)dataReader["chucdanh"]))
                        {
                            case "Quản lý sinh viên":
                                Quanlysinhvien quanlysinhvien = new Quanlysinhvien();
                                quanlysinhvien.Show();
                                this.Hide();
                                this.clearData();
                                break;
                            case "Quản lý hóa đơn điện nước":
                                Quanlyhoadon quanlyhoadon = new Quanlyhoadon();
                                quanlyhoadon.Show();
                                this.Hide();
                                this.clearData();
                                break;
                            case "Quản lý hợp đồng thuê":
                                Quanlyhopdong quanlyhopdong = new Quanlyhopdong();
                                quanlyhopdong.Show();
                                this.Hide();
                                this.clearData();
                                break;
                            case "Quản lý phòng":
                                Quanlyphong quanlyphong = new Quanlyphong();
                                quanlyphong.Show();
                                this.Hide();
                                this.clearData();
                                break;
                        }
                        return;
                    }
                    DataConfig.closeConnection();
                }
                MessageBox.Show("Thông tin nhập không đúng, vui lòng thử lại ! ", "Thông báo", MessageBoxButtons.OK);
                this.clearData();
                dataReader.Close();
                return;
            }
        }

        private bool checkAuth()
        {
            DataConfig.query = $"SELECT * FROM taikhoan WHERE email = N'{this.dangnhap_email.Text}'";
            // Tạo câu lệnh Command
            DataConfig.cmd = new SqlCommand(DataConfig.query, DataConfig.Conn);

            // Lấy dữ liệu đưa vào Datareader
            dataReader = DataConfig.cmd.ExecuteReader();

            // Lấy từng dòng dữ liệu ra từ DataReader , đem đi kiểm tra với Tên đăng nhập của người dùng, nếu trùng userr và pass thì return true;
            while (dataReader.Read())
            {
                if ((string)dataReader["email"] == this.dangnhap_email.Text && (string)dataReader["matkhau"] == this.dangnhap_password.Text)
                {
                    this.phanquyen = ((string)dataReader["phanquyen"]);
                    return true;
                }
            }
            MessageBox.Show("Thông tin nhập không đúng, vui lòng thử lại ! ", "Thông báo", MessageBoxButtons.OK);
            this.clearData();
            dataReader.Close();
            return false;
        }
        bool validateForm()
        {
            string username = this.dangnhap_email.Text;
            string userpass = this.dangnhap_password.Text;
            if(username == "" || userpass == "")
            {
                MessageBox.Show("Thông tin nhập không đúng, vui lòng thử lại ! ", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        void clearData()
        {
            this.dangnhap_password.Text = "";
            this.dangnhap_email.Text = "";
        }
    }
}
