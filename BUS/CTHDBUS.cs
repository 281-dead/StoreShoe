using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
namespace BUS
{
    public class CTHDBUS
    {
        private static CTHDBUS Instance;
        public static CTHDBUS GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new CTHDBUS();
                }
                return Instance;
            }
        }
        private CTHDBUS() { }
        public bool ThemCTHD(DataTable dt, int SOHD, decimal THANHTIEN)
        {
            return CTHDDAO.GetInstance.ThemCTHD(dt, SOHD, THANHTIEN);
        }
    }
}
