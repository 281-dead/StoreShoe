using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class TAIKHOANBUS
    {
        private static TAIKHOANBUS Instance;
        public static TAIKHOANBUS GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new TAIKHOANBUS();
                }
                return Instance;
            }
        }
        private TAIKHOANBUS() { }
        public bool CheckLogin(string manv, string mk)
        {
            if (TAIKHOANDAO.GetInstance.KiemTraDangNhap(manv.Trim().ToString(), mk.Trim().ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int GetMaQuyen(int manv)
        {
            return TAIKHOANDAO.GetInstance.GetMaQuyen(manv);
        }
        public string GetTenQuyen(int maquyen)
        {
            return TAIKHOANDAO.GetInstance.GetTenQuyen(maquyen);
        }
        public bool DoiMatKhau(string MaNV, string MatKhauMoi)
        {
            return TAIKHOANDAO.GetInstance.DoiMatKhau(MaNV, MatKhauMoi);
        }
    }
}
