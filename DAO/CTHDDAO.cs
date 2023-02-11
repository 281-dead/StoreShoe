using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
   public class CTHDDAO
    {
        private static CTHDDAO Instance;
        public static CTHDDAO GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new CTHDDAO();
                }
                return Instance;
            }
        }
        private CTHDDAO() { }

        #region Thêm Chi Tiết Hóa Đơn
        public bool ThemCTHD(DataTable dt, int SOHD, decimal THANHTIEN)
        {
            try
            {
                int rows = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string sql = "INSERT INTO CTHD VALUES('" + SOHD + "','" + dt.Rows[i][0].ToString() + "','" + dt.Rows[i][4].ToString() + "')";
                    rows = DataProvider.JustExcuteNoParameter(sql);
                }
                if (rows > 0)
                {
                    try
                    {
                        string sql = "UPDATE HOADON SET DATHANHTOAN=1, THANHTIEN=" + THANHTIEN + " WHERE SOHD='" + SOHD + "'";
                        int r = DataProvider.JustExcuteNoParameter(sql);
                        if (r > 0)
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

        #region Lấy MaCTHD Max
        public string GetMACTHDMax()
        {
            string sql = "SELECT MAX(MACTHD) FROM CTHD";
            DataTable dt = new DataTable();
            dt = DataProvider.GetTable(sql);
            return dt.Rows[0][0].ToString();
        }
        #endregion
    }
}

