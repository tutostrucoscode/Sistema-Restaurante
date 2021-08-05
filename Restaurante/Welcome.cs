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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            
        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            gunaCircleProgressBar1.Value += 1;
            count += 1;
            label3.Text = $"{count} %";
            if(gunaCircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            gunaCircleProgressBar1.Value = 0;
            gunaCircleProgressBar1.Minimum = 0;
            gunaCircleProgressBar1.Maximum = 100;
            timer1.Start();
        }

        private void gunaCircleProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
