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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.pnl_opciones = new System.Windows.Forms.Panel();
            this.btn_cerrar_sesion = new System.Windows.Forms.Button();
            this.btn_usuarios = new System.Windows.Forms.Button();
            this.btn_empresas = new System.Windows.Forms.Button();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.pcb_logo = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_barraestado = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_descripcion_ru = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nombre_us = new System.Windows.Forms.Label();
            this.pnl_contenido = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnl_opciones.SuspendLayout();
            this.pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).BeginInit();
            this.pnl_barraestado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_contenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_opciones
            // 
            this.pnl_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(128)))), ((int)(((byte)(167)))));
            this.pnl_opciones.Controls.Add(this.btn_cerrar_sesion);
            this.pnl_opciones.Controls.Add(this.btn_usuarios);
            this.pnl_opciones.Controls.Add(this.btn_empresas);
            this.pnl_opciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_opciones.Location = new System.Drawing.Point(723, 0);
            this.pnl_opciones.Name = "pnl_opciones";
            this.pnl_opciones.Size = new System.Drawing.Size(194, 562);
            this.pnl_opciones.TabIndex = 0;
            this.pnl_opciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_opciones_MouseDown);
            // 
            // btn_cerrar_sesion
            // 
            this.btn_cerrar_sesion.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar_sesion.Location = new System.Drawing.Point(10, 481);
            this.btn_cerrar_sesion.Name = "btn_cerrar_sesion";
            this.btn_cerrar_sesion.Size = new System.Drawing.Size(174, 62);
            this.btn_cerrar_sesion.TabIndex = 10;
            this.btn_cerrar_sesion.Text = "Cerrar Sesion";
            this.btn_cerrar_sesion.UseVisualStyleBackColor = true;
            this.btn_cerrar_sesion.Click += new System.EventHandler(this.btn_cerrar_sesion_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuarios.Location = new System.Drawing.Point(10, 79);
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Size = new System.Drawing.Size(174, 62);
            this.btn_usuarios.TabIndex = 9;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            // 
            // btn_empresas
            // 
            this.btn_empresas.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empresas.Location = new System.Drawing.Point(10, 9);
            this.btn_empresas.Name = "btn_empresas";
            this.btn_empresas.Size = new System.Drawing.Size(174, 62);
            this.btn_empresas.TabIndex = 8;
            this.btn_empresas.Text = "Empresa";
            this.btn_empresas.UseVisualStyleBackColor = true;
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(61)))), ((int)(((byte)(155)))));
            this.pnl_titulo.Controls.Add(this.pcb_logo);
            this.pnl_titulo.Controls.Add(this.lbl_titulo);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(723, 76);
            this.pnl_titulo.TabIndex = 1;
            this.pnl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseDown);
            // 
            // pcb_logo
            // 
            this.pcb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pcb_logo.Image")));
            this.pcb_logo.Location = new System.Drawing.Point(24, 9);
            this.pcb_logo.Name = "pcb_logo";
            this.pcb_logo.Size = new System.Drawing.Size(55, 55);
            this.pcb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_logo.TabIndex = 2;
            this.pcb_logo.TabStop = false;
            this.pcb_logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcb_logo_MouseDown);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_titulo.Location = new System.Drawing.Point(96, 23);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(270, 33);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Sistema de ventas";
            this.lbl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_titulo_MouseDown);
            // 
            // pnl_barraestado
            // 
            this.pnl_barraestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.pnl_barraestado.Controls.Add(this.pictureBox2);
            this.pnl_barraestado.Controls.Add(this.lbl_descripcion_ru);
            this.pnl_barraestado.Controls.Add(this.pictureBox1);
            this.pnl_barraestado.Controls.Add(this.lbl_nombre_us);
            this.pnl_barraestado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_barraestado.Location = new System.Drawing.Point(0, 481);
            this.pnl_barraestado.Name = "pnl_barraestado";
            this.pnl_barraestado.Size = new System.Drawing.Size(723, 81);
            this.pnl_barraestado.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_descripcion_ru
            // 
            this.lbl_descripcion_ru.AutoSize = true;
            this.lbl_descripcion_ru.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion_ru.Location = new System.Drawing.Point(37, 42);
            this.lbl_descripcion_ru.Name = "lbl_descripcion_ru";
            this.lbl_descripcion_ru.Size = new System.Drawing.Size(144, 20);
            this.lbl_descripcion_ru.TabIndex = 2;
            this.lbl_descripcion_ru.Text = "Rol de usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_nombre_us
            // 
            this.lbl_nombre_us.AutoSize = true;
            this.lbl_nombre_us.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_us.Location = new System.Drawing.Point(37, 10);
            this.lbl_nombre_us.Name = "lbl_nombre_us";
            this.lbl_nombre_us.Size = new System.Drawing.Size(81, 20);
            this.lbl_nombre_us.TabIndex = 0;
            this.lbl_nombre_us.Text = "Usuario:";
            // 
            // pnl_contenido
            // 
            this.pnl_contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnl_contenido.Controls.Add(this.button7);
            this.pnl_contenido.Controls.Add(this.button8);
            this.pnl_contenido.Controls.Add(this.button9);
            this.pnl_contenido.Controls.Add(this.button4);
            this.pnl_contenido.Controls.Add(this.button3);
            this.pnl_contenido.Controls.Add(this.button2);
            this.pnl_contenido.Controls.Add(this.button1);
            this.pnl_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contenido.Location = new System.Drawing.Point(0, 76);
            this.pnl_contenido.Name = "pnl_contenido";
            this.pnl_contenido.Size = new System.Drawing.Size(723, 405);
            this.pnl_contenido.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ImageKey = "reportes.png";
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(372, 234);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 100);
            this.button7.TabIndex = 7;
            this.button7.Text = "Reportes";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empresa1.png");
            this.imageList1.Images.SetKeyName(1, "clientes.png");
            this.imageList1.Images.SetKeyName(2, "familias.png");
            this.imageList1.Images.SetKeyName(3, "produtos.png");
            this.imageList1.Images.SetKeyName(4, "proveedores.png");
            this.imageList1.Images.SetKeyName(5, "reportes.png");
            this.imageList1.Images.SetKeyName(6, "ventas.png");
            this.imageList1.Images.SetKeyName(7, "compras.png");
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ImageKey = "ventas.png";
            this.button8.ImageList = this.imageList1;
            this.button8.Location = new System.Drawing.Point(41, 69);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 100);
            this.button8.TabIndex = 6;
            this.button8.Text = "Ventas";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ImageKey = "compras.png";
            this.button9.ImageList = this.imageList1;
            this.button9.Location = new System.Drawing.Point(205, 234);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 100);
            this.button9.TabIndex = 5;
            this.button9.Text = "Compras";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageKey = "clientes.png";
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(41, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 100);
            this.button4.TabIndex = 4;
            this.button4.Text = "Clientes";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageKey = "proveedores.png";
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(549, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 100);
            this.button3.TabIndex = 3;
            this.button3.Text = "Proveedores";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageKey = "familias.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(372, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "Familias Productos";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageKey = "produtos.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(205, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Productos";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.pnl_opciones.ResumeLayout(false);
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_logo)).EndInit();
            this.pnl_barraestado.ResumeLayout(false);
            this.pnl_barraestado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_contenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_opciones;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.Panel pnl_barraestado;
        private System.Windows.Forms.Panel pnl_contenido;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lbl_nombre_us;
        private System.Windows.Forms.PictureBox pcb_logo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_descripcion_ru;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cerrar_sesion;
        private System.Windows.Forms.Button btn_usuarios;
        private System.Windows.Forms.Button btn_empresas;
    }
}