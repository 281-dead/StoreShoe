using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
   public class SANPHAMBUS
    {
        private static SANPHAMBUS Instance;
        public static SANPHAMBUS GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new SANPHAMBUS();
                }
                return Instance;
            }
        }
        private SANPHAMBUS() { }
        public int GetTongSanPhamDaBan()
        {
            return SANPHAMDAO.GetInstance.GetTongSanPhamDaBan();
        }
        public int GetMaSPMoi()
        {
            return SANPHAMDAO.GetInstance.GetMaSPMax() + 1;
        }
        public string GetTenSP(int MASP)
        {
            return SANPHAMDAO.GetInstance.GetTenSP(MASP);
        }
        public DataTable GetDanhSachSanPhamTheoNCC(int MANCC)
        {
            return SANPHAMDAO.GetInstance.GetDanhSachSanPhamTheoNCC(MANCC);
        }
        public bool CheckMaSP(string MASP)
        {
            return SANPHAMDAO.GetInstance.CheckMaSP(MASP);
        }
        public bool NgungKinhDoanhSanPham(string MASP)
        {
            return SANPHAMDAO.GetInstance.NgungKinhDoanhSanPham(MASP);
        }
        public bool ThemSanPham(SanPhamDTO spDTO)
        {
            return SANPHAMDAO.GetInstance.ThemSanPham(spDTO);
        }
        public bool SuaSanPham(SanPhamDTO spDTO)
        {
            return SANPHAMDAO.GetInstance.SuaSanPham(spDTO);
        }
        public DataTable GetDanhSachSanPhamTheoBoLoc(string TENSP, string MALOAISP, string MANCC)
        {
            return SANPHAMDAO.GetInstance.GetDanhSachSanPhamTheoBoLoc(TENSP, MALOAISP, MANCC);
        }
        public bool CapNhatSoLuong(int MaSP, int SoLuong)
        {
            return SANPHAMDAO.GetInstance.CapNhatSoLuong(MaSP, SoLuong);
        }
        public bool CapNhatSoLuongKhiBanHang(int MaSP, int SoLuong)
        {
            return SANPHAMDAO.GetInstance.CapNhatSoLuongKhiBanHang(MaSP, SoLuong);
        }
        public DataTable GetDanhSachSanPham()
        {
            return SANPHAMDAO.GetInstance.GetDanhSachSanPham();
        }
        public double GetTongDoanhThu()
        {
            return SANPHAMDAO.GetInstance.GetTongDoanhThu();
        }
        public int GetTongKhachHang()
        {
            return SANPHAMDAO.GetInstance.GetTongKhachHang();
        }
        public List<SanPhamDTO> GetTop10SP(int top)
        {
            return SANPHAMDAO.GetInstance.GetTop10SP(top);
        }
        public double GetDoanhThuHomNay()
        {
            return SANPHAMDAO.GetInstance.GetDoanhThuHomNay();
        }
    }
}
