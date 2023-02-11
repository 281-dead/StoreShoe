using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace DAO
{
    public class TAIKHOANDAO
    {
        private static TAIKHOANDAO Instance;
        public static TAIKHOANDAO GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new TAIKHOANDAO();
                }
                return Instance;
            }
        }
        private TAIKHOANDAO() { }

        #region Kiểm Tra Đăng Nhập
        public bool KiemTraDangNhap(string manv, string mk)
        {
            try
            {
                string sqlmahoa = "declare @mk varchar(8000)  SET @mk = (SELECT MATKHAU FROM TAIKHOAN WHERE MANV=" + manv + ") select @mk";
                DataTable dt = new DataTable();
                dt = DataProvider.GetTable(sqlmahoa);
                string mkgiaima = dt.Rows[0][0].ToString();
                if (mk == mkgiaima)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region Đổi Mật Khẩu
        public bool DoiMatKhau(string MaNV, string MatKhauMoi)
        {
            try
            {
                string sql = "UPDATE TAIKHOAN SET MATKHAU =  '"+ MatKhauMoi + "'  WHERE MANV = @MANV";
                SqlConnection con = DataProvider.Openconnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MANV", MaNV);
                cmd.Connection = con;
                int rows = cmd.ExecuteNonQuery();
                DataProvider.Disconnect(con);
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi database: " + ex.Message);
                return false;
            }
        }
        #endregion

        #region Lấy Mã Quyền
        public int GetMaQuyen(int manv)
        {
            string sql = "SELECT * FROM PHANQUYEN WHERE MANV = '" + manv + "'";
            DataTable dt = new DataTable();
            dt = DataProvider.GetTable(sql);
            string maquyen = dt.Rows[0][1].ToString();
            return int.Parse(maquyen);
        }
        #endregion

        #region Lấy Tên Quyền
        public string GetTenQuyen(int maquyen)
        {
            string sql = "SELECT TENQUYEN FROM QUYEN WHERE MAQUYEN = '" + maquyen + "'";
            DataTable dt = new DataTable();
            dt = DataProvider.GetTable(sql);
            string tenquyen = dt.Rows[0][0].ToString();
            return tenquyen;
        }
        #endregion
    }
}
