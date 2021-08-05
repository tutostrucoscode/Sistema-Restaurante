using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datas
{
    public class Factura
    {

        private static Factura instance;

        public static Factura Instance
        {
            get { if (instance == null) instance = new Factura(); return Factura.instance; }
            private set { Factura.instance = value; }
        }

        private Factura() { }

        public int GetIdBillByCheckStatusTable(int maban)
        {
            DataTable data = MySQL.EjecutarConsultaConResultado(
                "SELECT * FROM HOADON " +
                $"WHERE MABAN = {maban} AND TRANGTHAI = 'No pagado'", null);

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Mahoadon;
            }

            return -1;
        }

        public DataRow GetInforBillByIdTable(int maban)
        {
            string consulta = "SELECT * FROM HOADON " +
                $"WHERE MABAN = {maban} AND TRANGTHAI = 'No pagado'";
            DataTable data = MySQL.EjecutarConsultaConResultado(consulta,null);
            if (data.Rows.Count > 0)
            {
                return data.Rows[0];
            }
            return null;
        }

        public bool InsertBill(int maban)
        {
            string query = $"insert into HOADON(MABAN) values ({maban})";
            long x = MySQL.EjecutarConsultaV2(query,null);
            if (x > 0) return true;
            return false;
        }

        public bool UpdateBill(int mahoadon, DateTime Fechadelpago, int dinero)
        {
            string query = $"Update HOADON set NGAYTHANHTOAN = {Fechadelpago:yyyy-MM-dd}, TONGTIEN = {dinero} where MAHOADON = {mahoadon}";
            long x = MySQL.EjecutarConsultaV3(query);
            MessageBox.Show($"[query]{query} || [X]{x}");
            if (x > 0) return true; //Actualización de factura exitosa
            return false; //Actualización que es mala*
        }
        
        public int GetMaxIDBill()
        {
            try
            {
                return (int)MySQL.ExecuteScalar("SELECT MAX(c_factura) FROM HOADON");
            }
            catch
            {
                return 1;
            }
        }

        public bool Checkout(int mahoadon)
        {
            string query = $"Update HOADON set TRANGTHAI = 'Pagado' where mahoadon = {mahoadon}";            
            long x = MySQL.EjecutarConsultaV3(query);
            MessageBox.Show($"[query]{query} || [X]{x}");
            if (x > 0) return true;//Pagado
            return false;

        }

        public DataTable SearchBillByIdTable(int maban)
        {
            DataTable data = new DataTable();
            string query = "Select MAHOADON as N'Mã hoá đơn', MABAN as N'Mã bàn',TRANGTHAI as N'Trạng thái', TONGTIEN as N'Tổng tiền' " +
                $"from HOADON where MABAN = {maban} and TRANGTHAI = N'Đã thanh toán'";
            data = MySQL.EjecutarConsultaConResultadoV2(query);
            return data;
        }

        public int GetCountBillToDay()
        {
            string query = $"select count(MAHOADON) from HOADON where NGAYGOIMON = '{DateTime.Now.ToShortDateString()}'";
            int count = MySQL.ExecuteScalar(query);
            return count;
        }

        public void UpdateDayOrder(int mahoadon)
        {
            string query = $"Update HOADON set NGAYGOIMON = {DateTime.Now.ToShortDateString()} where MAHOADON = {mahoadon}";
            MySQL.EjecutarConsultaV2(query, null);
        }

    }

    class Bill
    {
        int mahoadon;
        int maban;
        DateTime ngaycheckin;
        DateTime ngaycheckout;
        string trangthai;
        public Bill(DataRow row)
        {
            mahoadon = (int)row["MAHOADON"];
            maban = (int)row["MABAN"];
            trangthai = (string)row["TRANGTHAI"];
            try
            {
                ngaycheckin = (DateTime)row["NGAYCHECKIN"];
                ngaycheckout = (DateTime)row["NGAYCHECKOUT"];
            }
            catch
            {

            }


        }

        public int Mahoadon { get => mahoadon; set => mahoadon = value; }
        public int Maban { get => maban; set => maban = value; }
        public DateTime Ngaycheckin { get => ngaycheckin; set => ngaycheckin = value; }
        public DateTime Ngaycheckout { get => ngaycheckout; set => ngaycheckout = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }

}
