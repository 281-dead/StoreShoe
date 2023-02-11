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
    public class NCCBUS
    {
        private static NCCBUS Instance;
        public static NCCBUS GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new NCCBUS();
                }
                return Instance;
            }
        }
        private NCCBUS() { }
        public DataTable GetDanhSachNCC()
        {
            return NCCDAO.GetInstance.GetDanhSachNCC();
        }
        public bool ThemNCC(NHACUNGCAPDTO nccDTO)
        {
            return NCCDAO.GetInstance.ThemNCC(nccDTO);
        }
        public bool ThemNCCFull(NHACUNGCAPDTO nccDTO)
        {
            return NCCDAO.GetInstance.ThemNCCFull(nccDTO);
        }
        public string GetTenNCC(int MANCC)
        {
            return NCCDAO.GetInstance.GetTenNCC(MANCC);
        }
        public bool XoaNCC(string MANCC)
        {
            return NCCDAO.GetInstance.NgungHopTacNCC(MANCC);
        }
        public bool CapNhatNCC(NHACUNGCAPDTO nccDTO)
        {
            return NCCDAO.GetInstance.CapNhatNCC(nccDTO);
        }
        public bool CheckMaNCC(string MANCC)
        {
            return NCCDAO.GetInstance.CheckMaNCC(MANCC);
        }
    }
}
