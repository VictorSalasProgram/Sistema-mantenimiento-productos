namespace SisVentas.Presentacion
{
    partial class frm_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuarios));
            this.pnl_tareas = new System.Windows.Forms.Panel();
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.pnl_trabajo = new System.Windows.Forms.Panel();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_estado = new System.Windows.Forms.Button();
            this.btn_retornar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_login_us = new System.Windows.Forms.TextBox();
            this.txt_password_us = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre_us = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_rol_usuario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_listado = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.pnl_tareas.SuspendLayout();
            this.pnl_titulo.SuspendLayout();
            this.pnl_trabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_tareas
            // 
            this.pnl_tareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(128)))), ((int)(((byte)(167)))));
            this.pnl_tareas.Controls.Add(this.btn_retornar);
            this.pnl_tareas.Controls.Add(this.btn_estado);
            this.pnl_tareas.Controls.Add(this.btn_actualizar);
            this.pnl_tareas.Controls.Add(this.btn_nuevo);
            this.pnl_tareas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_tareas.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_tareas.Location = new System.Drawing.Point(592, 0);
            this.pnl_tareas.Name = "pnl_tareas";
            this.pnl_tareas.Size = new System.Drawing.Size(200, 706);
            this.pnl_tareas.TabIndex = 0;
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.pnl_titulo.Controls.Add(this.pictureBox1);
            this.pnl_titulo.Controls.Add(this.label1);
            this.pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(592, 70);
            this.pnl_titulo.TabIndex = 1;
            // 
            // pnl_trabajo
            // 
            this.pnl_trabajo.Controls.Add(this.btn_buscar);
            this.pnl_trabajo.Controls.Add(this.dgv_listado);
            this.pnl_trabajo.Controls.Add(this.label2);
            this.pnl_trabajo.Controls.Add(this.txt_buscar);
            this.pnl_trabajo.Controls.Add(this.btn_guardar);
            this.pnl_trabajo.Controls.Add(this.btn_cancelar);
            this.pnl_trabajo.Controls.Add(this.label11);
            this.pnl_trabajo.Controls.Add(this.label10);
            this.pnl_trabajo.Controls.Add(this.label9);
            this.pnl_trabajo.Controls.Add(this.label8);
            this.pnl_trabajo.Controls.Add(this.label6);
            this.pnl_trabajo.Controls.Add(this.cmb_rol_usuario);
            this.pnl_trabajo.Controls.Add(this.txt_nombre_us);
            this.pnl_trabajo.Controls.Add(this.label5);
            this.pnl_trabajo.Controls.Add(this.txt_password_us);
            this.pnl_trabajo.Controls.Add(this.label4);
            this.pnl_trabajo.Controls.Add(this.txt_login_us);
            this.pnl_trabajo.Controls.Add(this.label3);
            this.pnl_trabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_trabajo.Location = new System.Drawing.Point(0, 70);
            this.pnl_trabajo.Name = "pnl_trabajo";
            this.pnl_trabajo.Size = new System.Drawing.Size(592, 636);
            this.pnl_trabajo.TabIndex = 2;
            this.pnl_trabajo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_trabajo_Paint);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_nuevo.Location = new System.Drawing.Point(9, 85);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(181, 60);
            this.btn_nuevo.TabIndex = 0;
            this.btn_nuevo.Text = "Nuevo Usuario";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_actualizar.Location = new System.Drawing.Point(9, 160);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(181, 60);
            this.btn_actualizar.TabIndex = 1;
            this.btn_actualizar.Text = "Actualizar Usuario";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // btn_estado
            // 
            this.btn_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(36)))), ((int)(((byte)(81)))));
            this.btn_estado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_estado.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_estado.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_estado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_estado.Location = new System.Drawing.Point(9, 236);
            this.btn_estado.Name = "btn_estado";
            this.btn_estado.Size = new System.Drawing.Size(181, 60);
            this.btn_estado.TabIndex = 2;
            this.btn_estado.Text = "Estado de Usuario";
            this.btn_estado.UseVisualStyleBackColor = false;
            // 
            // btn_retornar
            // 
            this.btn_retornar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btn_retornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_retornar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retornar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retornar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_retornar.Location = new System.Drawing.Point(16, 634);
            this.btn_retornar.Name = "btn_retornar";
            this.btn_retornar.Size = new System.Drawing.Size(181, 60);
            this.btn_retornar.TabIndex = 3;
            this.btn_retornar.Text = "Retornar";
            this.btn_retornar.UseVisualStyleBackColor = false;
            this.btn_retornar.Click += new System.EventHandler(this.btn_retornar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(90, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login:";
            // 
            // txt_login_us
            // 
            this.txt_login_us.Enabled = false;
            this.txt_login_us.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login_us.Location = new System.Drawing.Point(36, 63);
            this.txt_login_us.MaxLength = 20;
            this.txt_login_us.Name = "txt_login_us";
            this.txt_login_us.Size = new System.Drawing.Size(165, 27);
            this.txt_login_us.TabIndex = 1;
            // 
            // txt_password_us
            // 
            this.txt_password_us.Enabled = false;
            this.txt_password_us.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password_us.Location = new System.Drawing.Point(222, 63);
            this.txt_password_us.MaxLength = 20;
            this.txt_password_us.Name = "txt_password_us";
            this.txt_password_us.PasswordChar = '*';
            this.txt_password_us.Size = new System.Drawing.Size(165, 27);
            this.txt_password_us.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // txt_nombre_us
            // 
            this.txt_nombre_us.Enabled = false;
            this.txt_nombre_us.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_us.Location = new System.Drawing.Point(36, 138);
            this.txt_nombre_us.MaxLength = 20;
            this.txt_nombre_us.Name = "txt_nombre_us";
            this.txt_nombre_us.Size = new System.Drawing.Size(351, 27);
            this.txt_nombre_us.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre:";
            // 
            // cmb_rol_usuario
            // 
            this.cmb_rol_usuario.Enabled = false;
            this.cmb_rol_usuario.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_rol_usuario.FormattingEnabled = true;
            this.cmb_rol_usuario.Location = new System.Drawing.Point(36, 209);
            this.cmb_rol_usuario.Name = "cmb_rol_usuario";
            this.cmb_rol_usuario.Size = new System.Drawing.Size(351, 30);
            this.cmb_rol_usuario.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rol de usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(12, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(207, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(12, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(12, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "*";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancelar.Location = new System.Drawing.Point(53, 258);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(125, 34);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.btn_guardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_guardar.Location = new System.Drawing.Point(240, 258);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(125, 34);
            this.btn_guardar.TabIndex = 14;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Visible = false;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(94, 312);
            this.txt_buscar.MaxLength = 20;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(293, 27);
            this.txt_buscar.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar:";
            // 
            // dgv_listado
            // 
            this.dgv_listado.AllowUserToAddRows = false;
            this.dgv_listado.AllowUserToDeleteRows = false;
            this.dgv_listado.AllowUserToOrderColumns = true;
            this.dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listado.Location = new System.Drawing.Point(27, 361);
            this.dgv_listado.Name = "dgv_listado";
            this.dgv_listado.ReadOnly = true;
            this.dgv_listado.RowHeadersWidth = 51;
            this.dgv_listado.RowTemplate.Height = 24;
            this.dgv_listado.Size = new System.Drawing.Size(539, 263);
            this.dgv_listado.TabIndex = 17;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_buscar.Location = new System.Drawing.Point(393, 311);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(92, 28);
            this.btn_buscar.TabIndex = 18;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 706);
            this.Controls.Add(this.pnl_trabajo);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.pnl_tareas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_usuarios_Load);
            this.pnl_tareas.ResumeLayout(false);
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
            this.pnl_trabajo.ResumeLayout(false);
            this.pnl_trabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_tareas;
        private System.Windows.Forms.Button btn_retornar;
        private System.Windows.Forms.Button btn_estado;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Panel pnl_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_trabajo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_rol_usuario;
        private System.Windows.Forms.TextBox txt_nombre_us;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_password_us;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_login_us;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_listado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_buscar;
    }
}