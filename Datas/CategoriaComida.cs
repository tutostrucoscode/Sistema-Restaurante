using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas
{

    public class CategoriaComida
    {
        private CategoriaComida() { }
        private static CategoriaComida instance;
        public static CategoriaComida Instance
        {
            get
            {
                if (instance == null) instance = new CategoriaComida();
                return instance;
            }
        }

        public List<DataCategoriaComida> GetListFoodCategories()
        {
            string query = "Select * from LOAITHUCAN";
            DataTable data = MySQL.EjecutarConsultaConResultado(query,null);
            List<DataCategoriaComida> categories = new List<DataCategoriaComida>();
            foreach (DataRow i in data.Rows)
            {
                DataCategoriaComida category = new DataCategoriaComida(i);
                categories.Add(category);
            }
            return categories;
        }

        public DataTable LoadFoodCategory()
        {
            DataTable data = new DataTable();
            string query = "Select MALOAI as N'Mã loại',TENLOAI as N'Tên loại 'from LOAITHUCAN";
            data = MySQL.EjecutarConsultaConResultado(query);
            return data;
        }

        public int GetIdByNameFoodCategory(string tenloai)
        {
            int maloai = -1;
            DataTable data = new DataTable();
            string query = $"Select MALOAI From LOAITHUCAN where TENLOAI=N'{tenloai}'";
            data = MySQL.EjecutarConsultaConResultadoV2(query);
            try
            {
                maloai = (int)data.Rows[0][0];
                return maloai;
            }
            catch
            {
                return -1;
            }

        }

    }

    public class DataCategoriaComida
    {
        private int maloai;
        private string tenloai;

        public DataCategoriaComida(DataRow row)
        {
            maloai = (int)row["MALOAI"];
            tenloai = (string)row["TENLOAI"];

        }
        public int Maloai { get => maloai; set => maloai = value; }
        public string Tenloai { get => tenloai; set => tenloai = value; }

    }
}
