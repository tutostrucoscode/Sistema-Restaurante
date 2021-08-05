using Data;
using Datas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class fOrder : Form
    {

        private int Maban = 0;

        public fOrder(int maban, string tenban)
        {
            InitializeComponent();
            this.Maban = maban;
            txtNameTable.Text = tenban;
            LoadDanhMuc();
        }

        void LoadDanhMuc()
        {
            List<DataCategoriaComida> categories =
                 CategoriaComida.Instance.GetListFoodCategories();
            cbTenDanhMuc.DataSource = categories;
            cbTenDanhMuc.DisplayMember = "TenLoai";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<DataComida> listFood = Comida.Instance.GetFoodByCategoryID(id);
            if (listFood.Count == 0)
            {
                MessageBox.Show("Esta categoría no tiene platos");
                cbTenDanhMuc.SelectedIndex = 0;
                LoadFoodListByCategoryID(1);
            }
            else
            {
                cbTenThucAn.DataSource = listFood;
                cbTenThucAn.DisplayMember = "Tenthucan";
            }
        }

        private void cbTenDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maloai = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            DataCategoriaComida selected = cb.SelectedItem as DataCategoriaComida;
            maloai = selected.Maloai;

            LoadFoodListByCategoryID(maloai);

        }

        private void cbTenThucAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;
            DataComida food = cb.SelectedItem as DataComida;
            int gia = food.Gia;
            txtGia.Text = gia.ToString();

        }

        private void btnAddfood_Click(object sender, EventArgs e)
        {

            int mathucan = (cbTenThucAn.SelectedItem as DataComida).Mathucan;
            int mahoadon = Factura.Instance.GetIdBillByCheckStatusTable(Maban);
            Mesas.Instance.UpdateStatusById(Maban);


            int soluong = (int)nmSoluong.Value;
            if (soluong <= 0)
            {
                MessageBox.Show("La cantidad mínima de pedido es 1");
                return;
            }
            //Cuando la mesa no tiene factura hoá
            if (mahoadon == -1)
            {
                Factura.Instance.InsertBill(Maban);
                //  Crea una nueva factura para la mesa.
                mahoadon = Factura.Instance.GetMaxIDBill();
                Factura.Instance.UpdateDayOrder(mahoadon);
                if (FacturaInfo.Instance.InsertBillInfo
                    (mahoadon, mathucan, soluong) == true)
                {
                    MessageBox.Show("Más éxito");
                }


            }
            //Cuando la mesa tiene la cuenta
            else
            {
                if (FacturaInfo.Instance.InsertBillInfo(mahoadon, mathucan, soluong) == true)
                {

                    MessageBox.Show("Buena suerte");
                }
            }


        }

        private void fOrder_Load(object sender, EventArgs e)
        {
            MySQL.Initialize();

        }

    }
}
