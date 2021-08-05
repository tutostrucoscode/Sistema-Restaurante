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
    public partial class fAddFood : Form
    {
        public fAddFood()
        {
            InitializeComponent();
            txtFoodID.Text = (Comida.Instance.GetMaxIdFood() + 1).ToString();
            LoadFoodCategory();

        }

        void LoadFoodCategory()
        {
            List<DataCategoriaComida> categories = CategoriaComida.Instance.GetListFoodCategories();
            cbbFoodCategory.DataSource = categories;
            cbbFoodCategory.DisplayMember = "Tenloai";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text == "" ||
                txtPrice.Text == "" || txtTypeID.Text == "")
            {
                MessageBox.Show("Por favor ingrese la información completa");
                return;
            }
            try
            {

                string tenthucan = txtFoodName.Text;
                int gia = Convert.ToInt32(txtPrice.Text);
                int maloai = Convert.ToInt32(txtTypeID.Text);
                if (Comida.Instance.InsertFood(tenthucan, gia, maloai) == true)
                {
                    MessageBox.Show("Platos más exitosos");
                    txtFoodID.Text = (Convert.ToInt32(txtFoodID.Text) + 1).ToString();
                    txtFoodName.Text = "";
                    txtPrice.Text = "";
                    txtTypeID.Text = "";
                    cbbFoodCategory.Text = "";

                }
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627: //Este código de error muestra una violación de la clave principal
                        MessageBox.Show("El código del plato ya existe o el nombre del plato está duplicado");
                        break;
                    case 547:
                        MessageBox.Show("El código de tipo no existe");
                        break;
                    default:
                        throw;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("El código de tipo no existe");
            }
            //Al agregar, los cuadros de texto se vacían y aumentan el código de alimentación en 1
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null) return;

            DataCategoriaComida category = cb.SelectedItem as DataCategoriaComida;
            string tenloai = category.Tenloai;
            int maloai = CategoriaComida.Instance.GetIdByNameFoodCategory(tenloai);
            txtTypeID.Text = maloai.ToString();
        }

    }
}
