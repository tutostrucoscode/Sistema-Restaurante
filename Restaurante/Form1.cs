using Data;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        void LoadData()
        {
            grid.Rows.Clear();

            string consulta = "SELECT * FROM BANAN";
            DataTable resultado = MySQL.EjecutarConsultaConResultado(consulta, null);
            if (resultado != null || resultado.Rows.Count > 0)
            {
                foreach (DataRow fila in resultado.Rows)
                {
                    grid.Rows.Add(new object[]
                    {
                        fila["MABAN"].ToString(),
                        fila["TRANGTHAI"].ToString(),
                        fila["TENBAN"].ToString(),
                        0,
                        0,
                    });
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            try
            {
                grid.FirstDisplayedScrollingRowIndex = grid.Rows[e.Value - 1].Index;
            }
            catch (Exception)
            {

            }
        }

        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                bunifuVScrollBar1.Maximum = grid.RowCount;
            }
            catch (Exception)
            {

            }
        }

        private void grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
                bunifuVScrollBar1.Maximum = grid.RowCount;
            }
            catch (Exception)
            {

            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
