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
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.pnl_barraestado = new System.Windows.Forms.Panel();
            this.pnl_contenido = new System.Windows.Forms.Panel();
            this.btn_empresa = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.pnl_contenido.SuspendLayout();
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
            this.pnl_contenido.Controls.Add(this.button7);
            this.pnl_contenido.Controls.Add(this.button8);
            this.pnl_contenido.Controls.Add(this.button9);
            this.pnl_contenido.Controls.Add(this.button4);
            this.pnl_contenido.Controls.Add(this.button3);
            this.pnl_contenido.Controls.Add(this.button2);
            this.pnl_contenido.Controls.Add(this.button1);
            this.pnl_contenido.Controls.Add(this.btn_empresa);
            this.pnl_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_contenido.Location = new System.Drawing.Point(0, 76);
            this.pnl_contenido.Name = "pnl_contenido";
            this.pnl_contenido.Size = new System.Drawing.Size(723, 405);
            this.pnl_contenido.TabIndex = 3;
            // 
            // btn_empresa
            // 
            this.btn_empresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_empresa.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_empresa.ImageKey = "empresa1.png";
            this.btn_empresa.ImageList = this.imageList1;
            this.btn_empresa.Location = new System.Drawing.Point(41, 69);
            this.btn_empresa.Name = "btn_empresa";
            this.btn_empresa.Size = new System.Drawing.Size(110, 100);
            this.btn_empresa.TabIndex = 0;
            this.btn_empresa.Text = "Empresa";
            this.btn_empresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_empresa.UseVisualStyleBackColor = true;
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
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ImageKey = "reportes.png";
            this.button7.ImageList = this.imageList1;
            this.button7.Location = new System.Drawing.Point(549, 234);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 100);
            this.button7.TabIndex = 7;
            this.button7.Text = "Reportes";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ImageKey = "ventas.png";
            this.button8.ImageList = this.imageList1;
            this.button8.Location = new System.Drawing.Point(205, 234);
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
            this.button9.Location = new System.Drawing.Point(372, 234);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 100);
            this.button9.TabIndex = 5;
            this.button9.Text = "Compras";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button9.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button btn_empresa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}