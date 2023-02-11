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
    public class PHIEUNHAPBUS
    {
        private static PHIEUNHAPBUS Instance;
        public static PHIEUNHAPBUS GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new PHIEUNHAPBUS();
                }
                return Instance;
            }
        }
        private PHIEUNHAPBUS() { }
        public bool ThemPhieuNhap(PHIEUNHAPDTO pnDTO)
        {
            return PHIEUNHAPDAO.GetInstance.ThemPhieuNhap(pnDTO);
        }
        public bool XoaPN(int MAPN)
        {
            return PHIEUNHAPDAO.GetInstance.XoaPN(MAPN);
        }
        public DataTable GetDanhSachPhieuNhap()
        {
            return PHIEUNHAPDAO.GetInstance.GetDanhSachPhieuNhap();
        }
        public bool XacNhan(int MaPhieu)
        {
            return PHIEUNHAPDAO.GetInstance.XacNhan(MaPhieu);
        }
        public bool CapNhatSoLuong(int MaPhieu)
        {
            return PHIEUNHAPDAO.GetInstance.CapNhatSoLuong(MaPhieu);
        }
        public int GetMAPNMax()
        {
            return PHIEUNHAPDAO.GetInstance.GetMAPNMax();
        }
    }
}
