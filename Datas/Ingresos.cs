using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas
{
    public class Ingresos
    {
        private static Ingresos instance;
        public static Ingresos Instance
        {
            get { if (instance == null) instance = new Ingresos(); return Ingresos.instance; }
            private set { Ingresos.instance = value; }
        }

        private Ingresos() { }

        public int GetRevenueToDay()
        {
            string query = $"select SUM(TONGTIEN) from HOADON where NGAYTHANHTOAN='{DateTime.Now.ToShortDateString()}'";
            int revenue = MySQL.ExecuteScalar(query);
            return revenue;
        }

    }
}
