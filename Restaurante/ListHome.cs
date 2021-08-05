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
    public partial class ListHome : Form
    {
        public ListHome()
        {
            InitializeComponent();
            LoadRevenueToDay();
            LoadCountBillToDay();
        }

        public void LoadRevenueToDay()
        {
            int RevenueToday = Ingresos.Instance.GetRevenueToDay();
            lblRevenueToday.Text = string.Format("{0:n0}", RevenueToday);

        }

        void LoadCountBillToDay()
        {
            lblCountOrder.Text = Factura.Instance.GetCountBillToDay().ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
