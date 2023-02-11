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
    public class TRANGCHUBUS
    {
        private static TRANGCHUBUS Instance;
        public static TRANGCHUBUS GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new TRANGCHUBUS();
                }
                return Instance;
            }
        }
        private TRANGCHUBUS() { }
        public int GetTongSanPhamDaBan()
        {
            return TRANGCHUDAO.GetInstance.GetTongSanPhamDaBan();
        }
        public double GetTongDoanhThu()
        {
            return TRANGCHUDAO.GetInstance.GetTongDoanhThu();
        }
        public int GetTongKhachHang()
        {
            return TRANGCHUDAO.GetInstance.GetTongKhachHang();
        }
        public List<SanPhamDTO> GetTop10SPTheoSoLuongHomNay()
        {
            return TRANGCHUDAO.GetInstance.GetTop10SPTheoSoLuongHomNay();
        }
        public List<SanPhamDTO> GetTop10SPTheoSoLuongHomQua()
        {
            return TRANGCHUDAO.GetInstance.GetTop10SPTheoSoLuongHomQua();
        }
        public List<SanPhamDTO> GetTop10SPTheoSoLuong7NgayQua()
        {
            return TRANGCHUDAO.GetInstance.GetTop10SPTheoSoLuong7NgayQua();
        }
        public List<SanPhamDTO> GetTop10SPTheoSoLuongThangNay()
        {
            return TRANGCHUDAO.GetInstance.GetTop10SPTheoSoLuongThangNay();
        }
        public List<SanPhamDTO> GetTop10SPTheoSoLuongThangTruoc()
        {
            return TRANGCHUDAO.GetInstance.GetTop10SPTheoSoLuongThangTruoc();
        }
        public List<SanPhamDTO> GetTop10SPTheoDoanhThuHomNay()
        {
            return TRANGCHUDAO.GetInstance.GetTop10SPTheoDoanhThuHomNay();
        }
        public List<SanPhamDTO> GetTop10SPTheoDoanhThuHomQua()
        {
            return TRANGCHUDAO.GetInstance.GetTop10SPTheoDoanhThuHomQua();
        }
        public List<SanPhamDTO> GetTop10SPTheoDoanhThu7NgayQua()
        {
            return TRANGCHUDAO.GetInstance.GetTop10SPTheoDoanhThu7NgayQua();
        }
        public List<SanPhamDTO> GetTop10SPTheoDoanhThuThangNay()
        {
            return TRANGCHUDAO.GetInstance.GetTop10SPTheoDoanhThuThangNay();
        }
        public List<SanPhamDTO> GetTop10SPTheoDoanhThuThangTruoc()
        {
            return TRANGCHUDAO.GetInstance.GetTop10SPTheoDoanhThuThangTruoc();
        }
        public double GetDoanhThuHomNay()
        {
            return TRANGCHUDAO.GetInstance.GetDoanhThuHomNay();
        }
        public DOANHTHUDTO GetDoanhThuHomQua()
        {
            return TRANGCHUDAO.GetInstance.GetDoanhThuHomQua();
        }
        public List<DOANHTHUDTO> GetDoanhThu(int songay)
        {
            return TRANGCHUDAO.GetInstance.GetDoanhThu(songay);
        }
        public List<DOANHTHUDTO> GetDoanhThu7NgayQua()
        {
            return TRANGCHUDAO.GetInstance.GetDoanhThu7NgayQua();
        }
        public List<DOANHTHUDTO> GetDoanhThuThangNay()
        {
            return TRANGCHUDAO.GetInstance.GetDoanhThuThangNay();
        }
        public List<DOANHTHUDTO> GetDoanhThuThangTruoc()
        {
            return TRANGCHUDAO.GetInstance.GetDoanhThuThangTruoc();
        }
    }
}
