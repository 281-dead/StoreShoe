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
    public class LOAISANPHAMBUS
    {
        private static LOAISANPHAMBUS Instance;
        public static LOAISANPHAMBUS GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new LOAISANPHAMBUS();
                }
                return Instance;
            }
        }
        private LOAISANPHAMBUS() { }
        public DataTable GetDanhSachLoaiSanPham()
        {
            return LOAISANPHAMDAO.GetInstance.GetDanhSachLoaiSanPham();
        }
        public bool ThemLoaiSanPham(LOAISANPHAMDTO lspDTO)
        {
            return LOAISANPHAMDAO.GetInstance.ThemLoaiSanPham(lspDTO);
        }
        public bool NgungKinhDoanh(string MALOAISP)
        {
            return LOAISANPHAMDAO.GetInstance.NgungKinhDoanh(MALOAISP);
        }
        public bool CapNhatLoaiSanPham(LOAISANPHAMDTO lspDTO)
        {
            return LOAISANPHAMDAO.GetInstance.CapNhatLoaiSanPham(lspDTO);
        }
        public bool CheckMaLoaiSP(string MALOAISP)
        {
            return LOAISANPHAMDAO.GetInstance.CheckMaLoaiSP(MALOAISP);
        }
    }
}
