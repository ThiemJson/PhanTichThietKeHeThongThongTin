using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanTichThietKeHeThongThongTin
{
    class DataConfig
    {
        public static string CHUOIKETNOI_Main = "Data Source=HOME-PC;Initial Catalog=QuanLyKyTucXaDaiHocThuyLoiPTTKHTTT;User ID=sa;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static string CHUOIKETNOI_Config = "Data Source=HOME-PC;Initial Catalog=QuanLyKyTucXaDaiHocThuyLoiPTTKHTTT; Integated Security = True ";
        public static SqlConnection Conn = null;
        //Kết nối Cơ sở dữ liệu: 
        public static SqlCommand cmd = null;
        //private SqlDataReader data = null;
        public static SqlDataAdapter adapter = null;
        public static DataTable table = null;
        public static string query = null;

        public static void openConnection()
        {
            DataConfig.Conn = new SqlConnection(DataConfig.CHUOIKETNOI_Main);
            DataConfig.Conn.Open();
        }

        public static void closeConnection()
        {
            if (DataConfig.Conn != null)
            {
                DataConfig.Conn.Close();
            }
        }
    }
}
