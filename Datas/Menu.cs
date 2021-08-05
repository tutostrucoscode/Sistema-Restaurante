using Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datas
{
    public class Menu
    {

        private static Menu instance;
        private Menu() { }

        public static Menu Instance
        {
            get
            {
                if (instance == null) instance = new Menu();
                return instance;
            }
        }

        
        public List<DataMenu> GetListMenusById(int MaBan)
        {
            try
            {
                
               string consulta = "SELECT ta.TENTHUCAN AS 'Nombre de la comida', ct.SOLUONG AS 'Monto', ta.GIA AS 'Precio', ct.SOLUONG * ta.GIA AS 'En dinero' " +
                    "FROM THUCAN AS ta, CHITIETHOADON AS ct,HOADON AS hd " +
                    $"WHERE ta.MATHUCAN = ct.MATHUCAN AND ct.MAHOADON = hd.MAHOADON AND hd.MABAN = {MaBan} AND hd.TRANGTHAI = 'No pagado'";                
                List<DataMenu> menus = new List<DataMenu>();
                DataTable resultado = MySQL.EjecutarConsultaConResultadoV2(consulta);

                //DataTable resultado = MySQL.EjecutarConsultaConResultado(consulta2,null);
                foreach (DataRow fila in resultado.Rows)
                {

                    DataMenu menu = new DataMenu(fila);
                    menus.Add(menu);
                }
                return menus;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception");
                return null;
            }
        }
        

        //public List<DataMenu> GetListMenusById(int MaBan)
        //{
        //        string consulta = "SELECT ta.TENTHUCAN AS 'Nombre de la comida', ct.SOLUONG AS 'Monto', ta.GIA AS 'Precio', ct.SOLUONG * ta.GIA AS 'En dinero' " +
        //             "FROM THUCAN AS ta, CHITIETHOADON AS ct,HOADON AS hd " +
        //             $"WHERE ta.MATHUCAN = ct.MATHUCAN AND ct.MAHOADON = hd.MAHOADON AND hd.MABAN = {MaBan} AND hd.TRANGTHAI = 'No pagado'";
        //        List<DataMenu> menus = new List<DataMenu>();
        //        DataTable resultado = MySQL.EjecutarConsultaConResultadoV2(consulta);
        //        //DataTable resultado = MySQL.EjecutarConsultaConResultado(consulta2,null);
        //        foreach (DataRow fila in resultado.Rows)
        //        {
        //            DataMenu menu = new DataMenu(fila);
        //            menus.Add(menu);
        //        }
        //        return menus;
        //}

        public DataTable LoadBillByIdTable(int Maban)
        {
            try
            {
                string consulta = "SELECT ta.TENTHUCAN AS 'El nombre de la comida', sum(ct.SOLUONG) AS 'Monto', sum(ta.GIA) AS 'Precio', sum(ct.SOLUONG * ta.GIA) AS 'En dinero' " +
                "FROM THUCAN AS ta, CHITIETHOADON AS ct, HOADON AS hd " +
                $"WHERE ta.MATHUCAN = ct.MATHUCAN AND ct.MAHOADON = hd.MAHOADON AND hd.MABAN = {Maban} AND hd.TRANGTHAI = 'No pagado' " +
                "GROUP BY ta.TENTHUCAN";
                //DataTable data = MySQL.EjecutarConsultaConResultado(consulta, null);
                DataTable data = MySQL.EjecutarConsultaConResultadoV2(consulta);
                return data;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception");
                return null;
            }
                
        }


    }

    public class DataMenu
    {

        private string tenthucan;
        private int soluong;
        private int gia;
        private int thanhtien;


        public string Tenthucan { get => tenthucan; set => tenthucan = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }

        public DataMenu(DataRow row)
        {
            tenthucan = (string)row["Nombre de la comida"];
            soluong = (int)row["Monto"];
            gia = (int)row["Precio"];
            thanhtien = Convert.ToInt32(row["En dinero"]);
        }

    }

}
