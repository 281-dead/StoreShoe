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
   public  class NHANVIENBUS
    {
        private static NHANVIENBUS Instance;
        public static NHANVIENBUS GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new NHANVIENBUS();
                }
                return Instance;
            }
        }
        private NHANVIENBUS() { }
        public bool ThemNhanVien(NHANVIENDTO nvDTO)
        {
            return NHANVIENDAO.GetInstance.ThemNhanVien(nvDTO);
        }
        public DataTable GetDanhSachNhanVienTheoBoLoc(string TENNV, string MALOAI)
        {
            return NHANVIENDAO.GetInstance.GetDanhSachNhanVienTheoBoLoc(TENNV, MALOAI);
        }
        public DataTable GetDanhSachNhanVienTheoMa(int MaNV)
        {
            return NHANVIENDAO.GetInstance.GetDanhSachNhanVienTheoMa(MaNV);
        }
        public string GetTenNhanVien(int manv)
        {
            return NHANVIENDAO.GetInstance.GetTenNhanVien(manv);
        }
        public int GetMaNVMoi()
        {
            return NHANVIENDAO.GetInstance.GetMaNVMax() + 1;
        }
        public bool CheckMaNV(string MANV)
        {
            return NHANVIENDAO.GetInstance.CheckMaNV(MANV);
        }
        public byte[] GetHinhNhanVien(int manv)
        {
            return NHANVIENDAO.GetInstance.GetHinhNhanVien(manv);
        }
        public bool ThoiViecNhanVien(string MANV)
        {
            return NHANVIENDAO.GetInstance.ThoiViecNhanVien(MANV);
        }
        public bool SuaThongTinNhanVien(NHANVIENDTO nvDTO)
        {
            return NHANVIENDAO.GetInstance.SuaThongTinNhanVien(nvDTO);
        }
        public DataTable GetDanhSachNhanVienTimKiem(string tennv)
        {
            return NHANVIENDAO.GetInstance.GetDanhSachNhanVienTimKiem(tennv);
        }
        public DataTable GetDanhSachNhanVien()
        {
            return NHANVIENDAO.GetInstance.GetDanhSachNhanVien();

        }
    }
}
