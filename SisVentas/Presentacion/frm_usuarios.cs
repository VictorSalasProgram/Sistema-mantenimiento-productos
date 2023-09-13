using SisVentas.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentas.Presentacion
{
    public partial class frm_usuarios : Form
    {
        public frm_usuarios()
        {
            InitializeComponent();
        }
        #region "MIS VARIABLES"
        int nCodigo_us = 0;
        int nEstado_guarda = 0;
        #endregion
        #region "MIS METODOS"
        private void Limpia_texto()
        {
            txt_login_us.Text = "";
            txt_password_us.Text = "";
            txt_nombre_us.Text = "";
            cmb_rol_usuario.Text = "";
        }
        private void Estado_texto(bool lEstado)
        {
            txt_login_us.Enabled = lEstado;
            txt_password_us.Enabled = lEstado;
            txt_nombre_us.Enabled=lEstado;
            cmb_rol_usuario.Enabled = lEstado;
        }
        private void Estado_botones_procesos(bool lEstado)
        {
            btn_cancelar.Visible= lEstado;
            btn_guardar.Visible = lEstado;

        }
        private void Estado_botones_principales(bool lEstado)
        {
            btn_nuevo.Enabled = lEstado;
            btn_actualizar.Enabled = lEstado;
            btn_estado.Enabled = lEstado;   
            btn_retornar.Enabled = lEstado;

        }
        private void Formato()
        {
            dgv_listado.Columns[0].Width = 100;
            dgv_listado.Columns[0].HeaderText = "CODIGO_US";
            dgv_listado.Columns[1].Width = 100;
            dgv_listado.Columns[1].HeaderText = "LOGIN";
            dgv_listado.Columns[2].Width = 120;
            dgv_listado.Columns[2].HeaderText = "NOMBRE";
            dgv_listado.Columns[3].Width = 130;
            dgv_listado.Columns[3].HeaderText = "ROL DE USUARIO";
            dgv_listado.Columns[4].Width = 100;
            dgv_listado.Columns[4].HeaderText = "ACTIVO";
            dgv_listado.Columns[5].Visible = false;

        }
        private void Listado_us(string cTexto)
        {
            D_usuarios Datos = new D_usuarios();
            dgv_listado.DataSource = Datos.Listado_us(cTexto);
            this.Formato();

        }
        private void Listado_ru()
        {
            try 
            {
                D_usuarios Datos = new D_usuarios();
                cmb_rol_usuario.DataSource = Datos.Listado_ru();
                cmb_rol_usuario.ValueMember = "codigo_ru";
                cmb_rol_usuario.DisplayMember = "descripcion_ru";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        #endregion

        private void btn_retornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnl_trabajo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            nEstado_guarda = 1; // Nuevo Registro
            this.Limpia_texto();
            this.Estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estado_botones_principales(false);
            this.txt_login_us.Focus();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            nEstado_guarda = 0;
            this.Limpia_texto();
            this.Estado_botones_procesos(false);
            this.Estado_botones_principales(true);
            this.Estado_texto(false);

        }

        private void frm_usuarios_Load(object sender, EventArgs e)
        {
            this.Listado_us("%");
            this.Listado_ru();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_us(txt_buscar.Text);   
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmb_rol_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_us_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_us_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_login_us_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
