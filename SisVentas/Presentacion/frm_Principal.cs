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
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        #region "MIS VARIABLES"
        internal int nCodigo_us { get; set; }
        internal string cLogin_us { get; set; }
        internal string cNombre_us { get;set; }
        internal string cDescripcion_ru { get; set; }
        internal int nCodigo_ru {get; set; }



        #endregion
        #region "ESTILO CONTROL DE TITULO"
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hand, int wMsg, int wParam, int iParam);


        #endregion

        private void frm_Principal_Load(object sender, EventArgs e)
        {
            lbl_nombre_us.Text = "Usuario: "+ cNombre_us;
            lbl_descripcion_ru.Text = "Rol usuario: " + cDescripcion_ru;
        }

        private void pnl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbl_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pcb_logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnl_opciones_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Deseas cerrar sesion del sistema?",
                                        "Aviso del sistema",
                                        MessageBoxButtons.OKCancel,
                                        MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            if (nCodigo_ru == 1) // Solo lo admin
            {
                frm_usuarios oFrm_us = new frm_usuarios();
                oFrm_us.ShowDialog();
            }
            else
            {
                MessageBox.Show("El usuario no posee permisos para esta opcion",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
           

        }
    }
}
