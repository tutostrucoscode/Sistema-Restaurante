using Datas;
using MySqlConnector;
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
    public partial class ListFood : Form
    {
        public ListFood()
        {
            InitializeComponent();
            cbbSelect.SelectedIndex = 0;

        }

        private void cbbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSelect.SelectedIndex == 0)
            {
                this.dtgvFood.DataSource = CategoriaComida.Instance.LoadFoodCategory();
                dtgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgvFood.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
                for (int i = 0; i < dtgvFood.Rows.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        dtgvFood.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                        dtgvFood.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                    }
                    else
                    {
                        dtgvFood.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        dtgvFood.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                    }
                }

                txtTypeID.ReadOnly = true;
                txtFoodID.ReadOnly = true;
                txtFoodName.ReadOnly = true;
                txtPrice.ReadOnly = true;
                txtTypeName.ReadOnly = true;
            }
            else
            {
                this.dtgvFood.DataSource = Comida.Instance.LoadFood();
                dtgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                for (int i = 0; i < dtgvFood.Rows.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        dtgvFood.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                        dtgvFood.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                    }
                    else
                    {
                        dtgvFood.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        dtgvFood.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                    }
                }
                txtTypeID.ReadOnly = true;
                txtFoodID.ReadOnly = true;
                txtFoodName.ReadOnly = false;
                txtPrice.ReadOnly = false;
                txtTypeName.ReadOnly = false;


            }
        }
                
        void LoadFood()
        {
            this.dtgvFood.DataSource = Comida.Instance.LoadFood();
            dtgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvFood.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            for (int i = 0; i < dtgvFood.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dtgvFood.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                    dtgvFood.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                }
                else
                {
                    dtgvFood.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dtgvFood.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }

        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            fAddFood f = new fAddFood();
            f.ShowDialog();
            LoadFood();
        }

        private void dtgvFood_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (cbbSelect.SelectedIndex == 1 && e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvFood.Rows[e.RowIndex];
                txtFoodID.Text = row.Cells["Mã thức ăn"].Value.ToString();
                txtFoodName.Text = row.Cells["Tên thức ăn"].Value.ToString();
                txtPrice.Text = row.Cells["Giá"].Value.ToString();
                txtTypeID.Text = row.Cells["Mã loại"].Value.ToString();
                txtTypeName.Text = row.Cells["Tên loại"].Value.ToString();
            }

        }

        private void buttonUpdateFood_Click(object sender, EventArgs e)
        {
            if (txtFoodID.Text == "" || txtFoodName.Text == "" ||
                txtPrice.Text == "" || txtTypeID.Text == "")
            {
                MessageBox.Show("Por favor ingrese la información completa");
            }
            else
            {
                try
                {
                    int mathucan = Convert.ToInt32(txtFoodID.Text);
                    string tenthucan = txtFoodName.Text;
                    int gia = Convert.ToInt32(txtPrice.Text);
                    int maloai = Convert.ToInt32(txtTypeID.Text);
                    if (Comida.Instance.UpdateFood(mathucan, tenthucan, gia, maloai) == true)
                    {
                        MessageBox.Show("Actualización exitosa del plato");
                        dtgvFood.DataSource = Comida.Instance.LoadFood();
                    }
                    else
                    {
                        MessageBox.Show("El código del plato no existe");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Alguna información no es válida");
                }
                catch (MySqlException)
                {
                    MessageBox.Show("El código del plato no puede coincidir");
                }
            }
            LoadFood();

        }

        private void buttonDeleteFood_Click(object sender, EventArgs e)
        {
            if (txtFoodID.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else
            {
                try
                {
                    int mathucan = Convert.ToInt32(txtFoodID.Text);
                    if (Comida.Instance.DeleteFood(mathucan) == true)
                    {
                        MessageBox.Show("Xoá món ăn thành công");
                        dtgvFood.DataSource = Comida.Instance.LoadFood();
                        //Khi xóa xong các textbox trở thành rỗng
                        txtTypeID.Text = "";
                        txtTypeName.Text = "";
                        txtPrice.Text = "";
                        txtFoodID.Text = "";
                        txtFoodName.Text = "";
                        LoadFood();
                    }
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Không thể xoá món ăn này do mã món ăn đang tồn tại" +
                        " trong chi tiết hoá đơn");
                }

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string tenthucan = txtSearch.Text;
            DataTable data = Comida.Instance.SearchFoodByName(tenthucan);
            for (int i = 0; i < dtgvFood.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dtgvFood.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                    dtgvFood.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                }
                else
                {
                    dtgvFood.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dtgvFood.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Không có món ăn cần tìm kiếm");
            }
            else
            {
                dtgvFood.DataSource = data;
                for (int i = 0; i < dtgvFood.Rows.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        dtgvFood.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                        dtgvFood.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                    }
                    else
                    {
                        dtgvFood.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        dtgvFood.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                    }
                }
            }
            txtSearch.Text = "";
        }

        private void ListFood_Load(object sender, EventArgs e)
        {
            if (cbbSelect.SelectedIndex == 0)
            {
                this.dtgvFood.DataSource = CategoriaComida.Instance.LoadFoodCategory();
                dtgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgvFood.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
                for (int i = 0; i < dtgvFood.Rows.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        dtgvFood.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(179, 213, 242);
                        dtgvFood.Rows[i].DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 213, 242);
                    }
                    else
                    {
                        dtgvFood.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        dtgvFood.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
                    }
                }

                txtTypeID.ReadOnly = true;
                txtFoodID.ReadOnly = true;
                txtFoodName.ReadOnly = true;
                txtPrice.ReadOnly = true;
                txtTypeName.ReadOnly = true;
            }
        }


    }
}
