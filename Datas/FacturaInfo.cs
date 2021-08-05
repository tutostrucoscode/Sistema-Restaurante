using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas
{
    public class FacturaInfo
    {

        private static FacturaInfo instance;

        public static FacturaInfo Instance
        {
            get { if (instance == null) instance = new FacturaInfo(); return FacturaInfo.instance; }
            private set { FacturaInfo.instance = value; }
        }

        private FacturaInfo() { }

        public bool InsertBillInfo(int mahoadon, int mathucan, int soluong)
        {

            string query = "Insert into CHITIETHOADON(MAHOADON,MATHUCAN,SOLUONG)" +
                " values("+ mahoadon + "," + mathucan + "," + soluong + ")";
            long x = MySQL.EjecutarConsultaV2(query,null);
            if (x > 0) return true;
            return false;
        }
    }
}
