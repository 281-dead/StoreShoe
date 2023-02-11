using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class HOADONBUS
    {
        private static HOADONBUS Instance;
        public static HOADONBUS GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new HOADONBUS();
                }
                return Instance;
            }
        }
        private HOADONBUS() { }
        public bool ThemHoaDon(HOADONDTO hdDTO)
        {
            return HOADONDAO.GetInstance.ThemHoaDon(hdDTO);
        }
        public int GetSOHDMAX()
        {
            return HOADONDAO.GetInstance.GetSOHDMax();
        }
        public bool XoaHD(int SOHD)
        {
            return HOADONDAO.GetInstance.XoaHD(SOHD);
        }
        public DataSet InHoaDon(int SOHD)
        {
            return HOADONDAO.GetInstance.InHoaDon(SOHD);
        }
        public bool CapNhatSoLuongTienKhachHang(int SOHD, decimal TienKhachHangTra, decimal TienThua)
        {
            return HOADONDAO.GetInstance.CapNhatSoLuongTienKhachHang(SOHD, TienKhachHangTra, TienThua);
        }
    }
}
