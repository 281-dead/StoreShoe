using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAO
{
    public class HOADONDAO
    {
        private static HOADONDAO Instance;
        public static HOADONDAO GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new HOADONDAO();
                }
                return Instance;
            }
        }
        private HOADONDAO() { }

        #region Thêm Hóa Đơn
        public bool ThemHoaDon(HOADONDTO hdDTO)
        {
            try
            {
                string sql = "INSERT INTO HOADON VALUES('" + hdDTO.NgayLap + "','" + hdDTO.MaKH + "','" + hdDTO.MaNV + "','" + hdDTO.ThanhTien + "','" + hdDTO.DaThanhToan + "','" + hdDTO.TienKhachHangTra + "','" + hdDTO.TienThua + "')";
                int rows = DataProvider.JustExcuteNoParameter(sql);
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

        #region Lấy SoHD Max
        public int GetSOHDMax()
        {
            try
            {
                string sql = "SELECT MAX(SOHD) FROM HOADON";
                DataTable dt = new DataTable();
                dt = DataProvider.GetTable(sql);
                return int.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {
                return 1;
            }
        }
        #endregion

        #region Cập Nhật Tiền Khách Hàng Trong Hóa Đơn
        public bool CapNhatSoLuongTienKhachHang(int SOHD, decimal TienKhachHangTra, decimal TienThua)
        {
            try
            {
                string sql = "UPDATE HOADON SET TIENKHACHHANGTRA = @TIENKHACHHANGTRA,TIENTHUA = @TIENTHUA WHERE SOHD = @SOHD";
                SqlConnection con = DataProvider.Openconnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@SOHD", SOHD);
                cmd.Parameters.AddWithValue("@TIENKHACHHANGTRA", TienKhachHangTra);
                cmd.Parameters.AddWithValue("@TIENTHUA", TienThua);
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

        #region In Hóa Đơn
        public DataSet InHoaDon(int SOHD)
        {
            try
            {
                string sql = "SELECT * FROM V_HoaDon WHERE SOHD=" + SOHD + "";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sql, DataProvider.Openconnect());
                da.Fill(ds, "V_HoaDon");        
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    double TongTien = Convert.ToDouble(ds.Tables[0].Rows[i]["TONGHOADON"]);              
                }
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }   
        #endregion

        #region Xóa Hóa Đơn
        public bool XoaHD(int SOHD)
        {
            try
            {
                string sql = "DELETE HOADON WHERE SOHD='" + SOHD + "'";
                int rows = DataProvider.JustExcuteNoParameter(sql);
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

    }
}

