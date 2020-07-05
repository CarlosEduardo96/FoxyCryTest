namespace viruzinformaticoPrueba.exe
{
    partial class Foxicomputer
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foxicomputer));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.TextBox();
            this.Liberacion = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Usermsj = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.cronometro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 117);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(12, 215);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(167, 24);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Foxi@gmail.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(16, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa clave de liberacion";
            this.label2.Visible = false;
            // 
            // Clave
            // 
            this.Clave.BackColor = System.Drawing.Color.Red;
            this.Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave.ForeColor = System.Drawing.Color.White;
            this.Clave.Location = new System.Drawing.Point(19, 286);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(131, 24);
            this.Clave.TabIndex = 3;
            this.Clave.Visible = false;
            // 
            // Liberacion
            // 
            this.Liberacion.BackColor = System.Drawing.Color.Black;
            this.Liberacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Liberacion.Location = new System.Drawing.Point(56, 316);
            this.Liberacion.Name = "Liberacion";
            this.Liberacion.Size = new System.Drawing.Size(94, 29);
            this.Liberacion.TabIndex = 4;
            this.Liberacion.Text = "Liberar escritorio";
            this.Liberacion.UseVisualStyleBackColor = false;
            this.Liberacion.Visible = false;
            this.Liberacion.Click += new System.EventHandler(this.Liberacion_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Black;
            this.Salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Salir.Location = new System.Drawing.Point(92, 351);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(58, 29);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Visible = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Usermsj
            // 
            this.Usermsj.AutoSize = true;
            this.Usermsj.BackColor = System.Drawing.Color.Transparent;
            this.Usermsj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usermsj.ForeColor = System.Drawing.Color.Lime;
            this.Usermsj.Location = new System.Drawing.Point(13, 34);
            this.Usermsj.Name = "Usermsj";
            this.Usermsj.Size = new System.Drawing.Size(76, 20);
            this.Usermsj.TabIndex = 6;
            this.Usermsj.Text = "Usuario:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(426, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 54);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tiempo restante para la eliminacion \r\nde archivos cada  minuto que\r\npase sete bor" +
                "ran tus archivos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(-61, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "00:00";
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Interval = 1000;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // cronometro
            // 
            this.cronometro.AutoSize = true;
            this.cronometro.BackColor = System.Drawing.Color.Transparent;
            this.cronometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cronometro.ForeColor = System.Drawing.Color.Lime;
            this.cronometro.Location = new System.Drawing.Point(449, 173);
            this.cronometro.Name = "cronometro";
            this.cronometro.Size = new System.Drawing.Size(159, 20);
            this.cronometro.TabIndex = 9;
            this.cronometro.Text = "Tiempo restante: 0";
            // 
            // Foxicomputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::viruzinformaticoPrueba.exe.Properties.Resources.virus_informaticos;
            this.ClientSize = new System.Drawing.Size(696, 409);
            this.ControlBox = false;
            this.Controls.Add(this.cronometro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Usermsj);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Liberacion);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Name = "Foxicomputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foxi-Cry   v 0.1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Foxicomputer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Clave;
        private System.Windows.Forms.Button Liberacion;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Usermsj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Label cronometro;
    }
}

