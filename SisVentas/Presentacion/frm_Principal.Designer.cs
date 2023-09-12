namespace SisVentas.Presentacion
{
    partial class frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_opciones = new System.Windows.Forms.Panel();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.pnl_barraestado = new System.Windows.Forms.Panel();
            this.pnl_contenido = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_opciones
            // 
            this.pnl_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(128)))), ((int)(((byte)(167)))));
            this.pnl_opciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_opciones.Location = new System.Drawing.Point(723, 0);
            this.pnl_opciones.Name = "pnl_opciones";
            this.pnl_opciones.Size = new System.Drawing.Size(194, 562);
            this.pnl_opciones.TabIndex = 0;
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(61)))), ((int)(((byte)(155)))));
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(723, 76);
            this.pnl_titulo.TabIndex = 1;
            // 
            // pnl_barraestado
            // 
            this.pnl_barraestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.pnl_barraestado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_barraestado.Location = new System.Drawing.Point(0, 481);
            this.pnl_barraestado.Name = "pnl_barraestado";
            this.pnl_barraestado.Size = new System.Drawing.Size(723, 81);
            this.pnl_barraestado.TabIndex = 2;
            // 
            // pnl_contenido
            // 
            this.pnl_contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnl_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contenido.Location = new System.Drawing.Point(0, 76);
            this.pnl_contenido.Name = "pnl_contenido";
            this.pnl_contenido.Size = new System.Drawing.Size(723, 405);
            this.pnl_contenido.TabIndex = 3;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 562);
            this.Controls.Add(this.pnl_contenido);
            this.Controls.Add(this.pnl_barraestado);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.pnl_opciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de ventas 1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_opciones;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Panel pnl_barraestado;
        private System.Windows.Forms.Panel pnl_contenido;
    }
}