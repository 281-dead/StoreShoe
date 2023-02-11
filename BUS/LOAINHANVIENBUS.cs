using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;

namespace BUS
{
    public class LOAINHANVIENBUS
    {
        private static LOAINHANVIENBUS Instance;
        public static LOAINHANVIENBUS GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new LOAINHANVIENBUS();
                }
                return Instance;
            }
        }
        private LOAINHANVIENBUS() { }
        public DataTable GetDanhSachLoaiNhanVien()
        {
            return LOAINHANVIENDAO.GetInstance.GetDanhSachLoaiNhanVien();
        }
    }
}
