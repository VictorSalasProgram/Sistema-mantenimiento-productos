using SisVentas.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentas.Presentacion
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btn_iniciar, "Iniciar sesion ahora");
            this.toolTip1.SetToolTip(this.btn_salir, "Salir del sistema");

            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        #region "ESTILO CONTROL DE TITULO"
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hand, int wMsg, int wParam, int iParam);


        #endregion

        private void pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            DataTable TablaLogin = new DataTable();
            D_usuarios Datos = new D_usuarios();
            TablaLogin = Datos.Login_us(txt_login.Text,txt_password.Text);
            if (TablaLogin.Rows.Count>0)
            {
                MessageBox.Show("Session iniciada correctamente");

            }
            else
            {
                MessageBox.Show("Login o password incorrectos");
            }
        }
    }
}
