using Data;
using Datas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class ListTable : Form
    {
        public ListTable()
        {
            InitializeComponent();
            LoadTable();
            LoadComboboxTenBan();
        }

        void LoadTable()
        {
            try
            {
                this.flowLayoutPanel1.Controls.Clear();
                List<DataMesas> tabeList = Mesas.Instance.GetListTable();
                foreach (DataMesas table in tabeList)
                {
                    Button btn = new Button() { Width = 100, Height = 100 };
                    btn.Text = table.Tenban + "\n" + table.Trangthai;
                    btn.Tag = table;

                    btn.Click += btn_Click;
                    btn.Leave += btn_Leave;
                    this.flowLayoutPanel1.Controls.Add(btn);

                    if (table.Trangthai == "Vacío")
                        btn.BackColor = Color.Lavender;
                    else
                    {
                        btn.BackColor = Color.Red;
                    }

                }
            }
            catch(Exception e)
            {
                MessageBox.Show($"[Exception]{e.ToString()}|[Message]{e.Message}|[Source]{e.Source}","Error");
            }
            
        }

        private void btn_Leave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DataMesas table = btn.Tag as DataMesas;
            if (table.Trangthai == "Vacío")
                btn.BackColor = Color.Lavender;
            else
            {
                btn.BackColor = Color.Red;
            }

        }

        private void btn_Click(object sender, EventArgs e)
        {

            int MABAN = ((DataMesas)(sender as Button).Tag).Maban;
            dtgvFoodbyId.Tag = (sender as Button).Tag;
            LoadBill(MABAN);
            Button btn = sender as Button;
            btn.BackColor = Color.LightYellow;
        }

        void LoadBill(int MABAN)
        {
            try
            {
                List<DataMenu> menus = Datas.Menu.Instance.GetListMenusById(MABAN);
                dtgvFoodbyId.DataSource = Datas.Menu.Instance.LoadBillByIdTable(MABAN);
                dtgvFoodbyId.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgvFoodbyId.RowHeadersVisible = false;
                for (int i = 0; i < dtgvFoodbyId.Rows.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        dtgvFoodbyId.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                        dtgvFoodbyId.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                    }
                    else
                    {
                        dtgvFoodbyId.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        dtgvFoodbyId.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                    }
                }
                int tongtien = 0;
                if (menus == null)
                {
                    MessageBox.Show($"[menus lanzo null]", "INFO");
                }
                else if(menus != null)
                {
                    foreach (var i in menus)
                    {
                        tongtien += i.Thanhtien;
                    }
                }                
                txtTongTien.Text = tongtien.ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show($"[Exception]{e}|[Message]{e.Message}|[Source]{e.Source}", "Error");
            }
        }

        private void buttonPayMonney_Click(object sender, EventArgs e)
        {
            DataMesas table = (dtgvFoodbyId.Tag as DataMesas);
            if (table == null)
            {
                MessageBox.Show("Seleccione una mesa para pagar");
            }
            else
            {
                int mahoadon = Factura.Instance.GetIdBillByCheckStatusTable(table.Maban);
                if (mahoadon == -1)
                {
                    MessageBox.Show("Esta mesa no tiene platos");
                }
                if (mahoadon != -1)
                {

                    this.Hide();
                    fInvoice f = new fInvoice(table.Maban);
                    f.ShowDialog();

                    LoadTable();
                    LoadBill(table.Maban);
                    this.Show();


                }
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (dtgvFoodbyId.Tag != null)
            {
                int maban = (dtgvFoodbyId.Tag as DataMesas).Maban;
                string tenban = (dtgvFoodbyId.Tag as DataMesas).Tenban;

                fOrder f = new fOrder(maban, tenban);
                f.ShowDialog();
                LoadTable();
                LoadBill(maban);
                this.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una tabla antes de realizar el pedido.");
            }


        }

        void LoadComboboxTenBan()
        {
            cbbSwichTable.DataSource = Mesas.Instance.GetListTable();
            cbbSwichTable.DisplayMember = "TENBAN";
            cbbMergeTable.DataSource = Mesas.Instance.GetListTable();
            cbbMergeTable.DisplayMember = "TENBAN";
        }

        private void btn_SwitchTable(object sender, EventArgs e)
        {
            DataMesas table1 = dtgvFoodbyId.Tag as DataMesas;
            DataMesas table2 = (cbbSwichTable.SelectedItem as DataMesas);
            if (table1 != null)
            {
                if (table1.Trangthai == "Libre")
                {
                    MessageBox.Show("Esta tabla está actualmente vacía");
                }
                else if (table1.Maban != table2.Maban)
                {
                    DialogResult dialogResult = MessageBox.Show($"Quieres cambiar de la mesa {table1.Maban} a la mesa {table2.Maban}"
                    , "Notificación", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Mesas.Instance.SwitchTable(table1.Maban, table2.Maban);
                        LoadTable();
                    }
                }

                else
                {
                    MessageBox.Show("Estás en la mesa actual");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Aún no has seleccionado una mesa");
            }
        }

        private void dtgvFoodbyId_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListTable_Load(object sender, EventArgs e)
        {
            MySQL.Initialize();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
