using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;

namespace BUS
{
    public class KHACHHANGBUS
    {
        private static KHACHHANGBUS Instance;
        public static KHACHHANGBUS GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new KHACHHANGBUS();
                }
                return Instance;
            }
        }
        private KHACHHANGBUS() { }
        public string GetTenKhachHang(string SDT)
        {
            return KHACHHANGDAO.GetInstance.GetTenKhachHang(SDT);
        }
        public string GetTenMaKH(string SDT)
        {
            return KHACHHANGDAO.GetInstance.GetTenMaKH(SDT);
        }
        public int GetMaKHMax()
        {
            return KHACHHANGDAO.GetInstance.GetMaKHMax() + 1;
        }
        public bool CheckMaKH(string MAKH)
        {
            return KHACHHANGDAO.GetInstance.CheckMaKH(MAKH);
        }
        public DataTable GetDanhSachKhachHang()
        {
            return KHACHHANGDAO.GetInstance.GetDanhSachKhachHang();

        }
        public bool ThemKhachHang(DTO.KHACHHANGDTO khDTO)
        {
            return KHACHHANGDAO.GetInstance.ThemKhachHang(khDTO);
        }
        public bool XoaKhachHang(string MAKH)
        {
            return KHACHHANGDAO.GetInstance.XoaKhachHang(MAKH);
        }
        public bool SuaThongTinKhachHang(DTO.KHACHHANGDTO khDTO)
        {
            return KHACHHANGDAO.GetInstance.SuaThongTinKhachHang(khDTO);
        }
        public DataTable GetDanhSachKhachHangTimKiem(string tenkh)
        {
            return KHACHHANGDAO.GetInstance.GetDanhSachKhachHangTimKiem(tenkh);
        }
        public bool CapNhatDoanhSoKhachHang(int MAKH, decimal DOANHSO)
        {
            return KHACHHANGDAO.GetInstance.CapNhatDoanhSoKhachHang(MAKH, DOANHSO);
        }

    }
}
