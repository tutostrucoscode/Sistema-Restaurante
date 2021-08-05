using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Data;
using Datas;

namespace Restaurante
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void Alert(string msg, Form_Alert.enType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            if (checkBoxRecordar.Checked == true)
            {
                Properties.Settings.Default.UserName = txtuser.Text;
                Properties.Settings.Default.Password = txtpass.Text;
                Properties.Settings.Default.Save();
            }
            if(checkBoxRecordar.Checked == false)
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

            String username = txtuser.Text;
            String password = txtpass.Text;
            string consulta = "SELECT * FROM users WHERE username = ?usn";
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("?usn", username);
            DataTable resultado = MySQL.EjecutarConsultaConResultado(consulta, parametros);
            if (resultado != null || resultado.Rows.Count > 0)
            {
                foreach (DataRow fila in resultado.Rows)
                {
                    if (!Utilidades.BcryptPasswordVerify(password, Convert.ToString(fila["password"])))
                    {
                        this.Alert("Contraseña invalida", Form_Alert.enType.Error);
                        return;
                    }
                    Cache.SQLIDUsuario = int.Parse(fila["id"].ToString());
                    Cache.Nombre = fila["nombre"].ToString();
                    Cache.Apellido = fila["apellido"].ToString();
                    Cache.Usuario = fila["username"].ToString();
                    Cache.Email = fila["email"].ToString();
                    Cache.idcargo = int.Parse(fila["cargo_id"].ToString());
                    this.Hide();
                    Welcome welcome = new Welcome();
                    welcome.ShowDialog();
                    FormPrincipal mainmenu = new FormPrincipal();
                    mainmenu.Show();
                    mainmenu.FormClosed += Logout;
                    this.Alert("Ingreso valido", Form_Alert.enType.Succes);
                }
            }
            else
            {
                this.Alert("Error de login", Form_Alert.enType.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

            if(Properties.Settings.Default.UserName != string.Empty)
            {
                txtuser.Text = Properties.Settings.Default.UserName;
                txtpass.Text = Properties.Settings.Default.Password;
            }
            MySQL.Initialize();
        }
    
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "";
            txtuser.Text = "";
            this.Show();
            txtuser.Focus();
        }
    
    }
}
