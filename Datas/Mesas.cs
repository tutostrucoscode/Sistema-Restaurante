using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas
{
    public class Mesas
    {

        private static Mesas instance;

        public static Mesas Instance
        {
            get
            {
                if (instance == null) instance = new Mesas();
                return instance;
            }
        }

        public List<DataMesas> GetListTable()
        {
            DataTable data = MySQL.EjecutarConsultaConResultado("Select * from BANAN", null);
            List<DataMesas> TableList = new List<DataMesas>();

            for (int i = 0; i<data.Rows.Count; i++)
            {
                DataMesas table = new DataMesas(data.Rows[i]);
                TableList.Add(table);
            }
            return TableList;
        }

        public void UpdateStatusById(int maban)
        {
            string consulta = "Update BANAN set TRANGTHAI='Hay gente' "
                + "where MABAN=" + maban;
            MySQL.EjecutarConsultaV3(consulta);
        }

        public void ResetStatusById(int maban)
        {
            string consulta = $"Update BANAN set TRANGTHAI = 'Vacío' where MABAN = {maban}";
            MySQL.EjecutarConsultaV3(consulta, null);
        }

        public void SwitchTable(int maban1, int maban2)
        {
            string query = "USP_SwitchTable @maban1 , @maban2";
            MySQL.EjecutarConsultaV3(query, new object[] { maban1, maban2 });
        }


    }

    public class DataMesas
    {

        private int maban;
        private string tenban;
        private string trangthai;

        public DataMesas(DataRow data)
        {
            this.Maban = (int)data["MABAN"];
            this.Trangthai = (string)data["TRANGTHAI"];
            this.Tenban = (string)data["TENBAN"];

        }

        public DataMesas() { }

        public int Maban { get => maban; set => maban = value; }
        public string Tenban { get => tenban; set => tenban = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }

    }
}
