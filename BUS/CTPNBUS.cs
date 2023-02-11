using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class CTPNBUS
    {
        private static CTPNBUS Instance;
        public static CTPNBUS GetInstance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new CTPNBUS();
                }
                return Instance;
            }
        }
        private CTPNBUS() { }
        public bool ThemCTPN(DataTable dt, int MAPN)
        {
            return CTPNDAO.GetInstance.ThemCTPN(dt, MAPN);
        }
    }
}
