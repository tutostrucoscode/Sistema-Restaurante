using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas
{

    public class Comida
    {
        private Comida() { }

        private static Comida instance;

        public static Comida Instance
        {
            get
            {
                if (instance == null) instance = new Comida();
                return instance;
            }
        }

        public DataTable LoadFood()
        {
            DataTable data = new DataTable();
            string query = "select MATHUCAN as N'Mã thức ăn',TENTHUCAN as N'Tên thức ăn'," +
                "GIA as N'Giá',THUCAN.MALOAI as N'Mã loại',TENLOAI as N'Tên loại' " +
                "from THUCAN,LOAITHUCAN where THUCAN.MALOAI = LOAITHUCAN.MALOAI";
            data = MySQL.EjecutarConsultaConResultado(query);
            return data;
        }

        public bool InsertFood(string tenthucan, int gia, int maloai)
        {
            string query = $"Insert into THUCAN(TENTHUCAN,GIA,MALOAI) values (N'{tenthucan}',{gia},{maloai})";
            int x = MySQL.EjecutarConsultaV3(query);
            if (x > 0) return true;
            return false;
        }

        public bool UpdateFood(int mathucan, string tenthucan, int gia, int maloai)
        {
            string query = $"Update THUCAN set TENTHUCAN = '{tenthucan}',GIA = {gia} ,MALOAI = {maloai} where MATHUCAN = '{mathucan}' ";
            long x = MySQL.EjecutarConsulta(query);
            if (x > 0) return true;
            return false;
        }

        public bool DeleteFood(int mathucan)
        {
            string query = $"Delete from THUCAN where mathucan = {mathucan}";
            long x = MySQL.EjecutarConsultaV2(query,null);
            if (x > 0) return true;
            return false;
        }
        
        public DataTable SearchFoodByName(string tenthucan)
        {
            string query = "Select MATHUCAN as N'Mã thức ăn',TENTHUCAN as N'Tên thức ăn', GIA as N'Giá',THUCAN.MALOAI as N'Mã loại',TENLOAI as N'Tên loại' " +
                "from THUCAN,LOAITHUCAN " +
                $"where TENTHUCAN like N'%{tenthucan}%' and THUCAN.MALOAI=LOAITHUCAN.MALOAI";
            DataTable data = new DataTable();
            data = MySQL.EjecutarConsultaConResultadoV2(query);
            return data;

        }

        public List<DataComida> GetFoodByCategoryID(int maloai)
        {
            List<DataComida> list = new List<DataComida>();

            string query = $"select * from THUCAN where MALOAI = {maloai}";

            DataTable data = MySQL.EjecutarConsultaConResultado(query,null);

            foreach (DataRow item in data.Rows)
            {
                DataComida food = new DataComida(item);
                list.Add(food);
            }

            return list;
        }

        public int GetMaxIdFood()
        {
            string query = "select max(MATHUCAN) from THUCAN";
            //Devuelve el valor máximo de qué alimento
            int x = MySQL.ExecuteScalar(query);
            return x;

        }

    }

    public class DataComida
    {

        private int mathucan;
        private int gia;
        private string tenthucan;
        private int maloai;
        public DataComida(DataRow row)
        {
            mathucan = (int)row["MATHUCAN"];
            gia = (int)row["GIA"];
            tenthucan = (string)row["TENTHUCAN"];
            maloai = (int)row["MALOAI"];
        }
        public int Mathucan { get => mathucan; set => mathucan = value; }
        public int Gia { get => gia; set => gia = value; }
        public string Tenthucan { get => tenthucan; set => tenthucan = value; }
        public int Maloai { get => maloai; set => maloai = value; }
    }
}
