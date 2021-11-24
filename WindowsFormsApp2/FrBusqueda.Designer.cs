namespace WindowsFormsApp2
{
    partial class FrBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrBusqueda));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbLibroConsulta = new System.Windows.Forms.TextBox();
            this.tbAutorConsulta = new System.Windows.Forms.TextBox();
            this.tbLibroResultado = new System.Windows.Forms.TextBox();
            this.tbAutorResultado = new System.Windows.Forms.TextBox();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbEncabezado = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbCantAgg = new System.Windows.Forms.TextBox();
            this.tbUbiAgg = new System.Windows.Forms.TextBox();
            this.tbAutorAgg = new System.Windows.Forms.TextBox();
            this.tbLibroAgg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LIBRO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AUTOR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "LIBRO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "AUTOR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "UBICACIÓN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "CANTIDAD";
            // 
            // tbLibroConsulta
            // 
            this.tbLibroConsulta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbLibroConsulta.Location = new System.Drawing.Point(87, 87);
            this.tbLibroConsulta.Name = "tbLibroConsulta";
            this.tbLibroConsulta.Size = new System.Drawing.Size(346, 20);
            this.tbLibroConsulta.TabIndex = 8;
            // 
            // tbAutorConsulta
            // 
            this.tbAutorConsulta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbAutorConsulta.Location = new System.Drawing.Point(87, 122);
            this.tbAutorConsulta.Name = "tbAutorConsulta";
            this.tbAutorConsulta.Size = new System.Drawing.Size(346, 20);
            this.tbAutorConsulta.TabIndex = 9;
            // 
            // tbLibroResultado
            // 
            this.tbLibroResultado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbLibroResultado.Location = new System.Drawing.Point(99, 31);
            this.tbLibroResultado.Name = "tbLibroResultado";
            this.tbLibroResultado.Size = new System.Drawing.Size(429, 20);
            this.tbLibroResultado.TabIndex = 10;
            // 
            // tbAutorResultado
            // 
            this.tbAutorResultado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbAutorResultado.Location = new System.Drawing.Point(99, 84);
            this.tbAutorResultado.Name = "tbAutorResultado";
            this.tbAutorResultado.Size = new System.Drawing.Size(429, 20);
            this.tbAutorResultado.TabIndex = 11;
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbUbicacion.Location = new System.Drawing.Point(99, 140);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(429, 20);
            this.tbUbicacion.TabIndex = 12;
            // 
            // tbCantidad
            // 
            this.tbCantidad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbCantidad.Location = new System.Drawing.Point(99, 190);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(429, 20);
            this.tbCantidad.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarAutor);
            this.groupBox1.Controls.Add(this.btnBuscarLibro);
            this.groupBox1.Controls.Add(this.tbAutorConsulta);
            this.groupBox1.Controls.Add(this.tbLibroConsulta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(137, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 270);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCantidad);
            this.groupBox2.Controls.Add(this.tbUbicacion);
            this.groupBox2.Controls.Add(this.tbAutorResultado);
            this.groupBox2.Controls.Add(this.tbLibroResultado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(689, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 270);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados de la busqueda";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarLibro.Image")));
            this.btnBuscarLibro.Location = new System.Drawing.Point(461, 85);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLibro.TabIndex = 10;
            this.btnBuscarLibro.Text = "BUSCAR";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAutor.Image")));
            this.btnBuscarAutor.Location = new System.Drawing.Point(461, 120);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(75, 24);
            this.btnBuscarAutor.TabIndex = 11;
            this.btnBuscarAutor.Text = "BUSCAR";
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(527, 613);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 33);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "CERRAR SESIÓN";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbEncabezado
            // 
            this.gbEncabezado.Controls.Add(this.pictureBox2);
            this.gbEncabezado.Controls.Add(this.pictureBox1);
            this.gbEncabezado.Location = new System.Drawing.Point(137, 114);
            this.gbEncabezado.Name = "gbEncabezado";
            this.gbEncabezado.Size = new System.Drawing.Size(1119, 179);
            this.gbEncabezado.TabIndex = 22;
            this.gbEncabezado.TabStop = false;
            this.gbEncabezado.Text = " ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(258, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(791, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbCantAgg);
            this.groupBox3.Controls.Add(this.tbUbiAgg);
            this.groupBox3.Controls.Add(this.tbAutorAgg);
            this.groupBox3.Controls.Add(this.tbLibroAgg);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(137, 679);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 270);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregar libro";
            // 
            // tbCantAgg
            // 
            this.tbCantAgg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbCantAgg.Location = new System.Drawing.Point(99, 190);
            this.tbCantAgg.Name = "tbCantAgg";
            this.tbCantAgg.Size = new System.Drawing.Size(429, 20);
            this.tbCantAgg.TabIndex = 13;
            // 
            // tbUbiAgg
            // 
            this.tbUbiAgg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbUbiAgg.Location = new System.Drawing.Point(99, 140);
            this.tbUbiAgg.Name = "tbUbiAgg";
            this.tbUbiAgg.Size = new System.Drawing.Size(429, 20);
            this.tbUbiAgg.TabIndex = 12;
            // 
            // tbAutorAgg
            // 
            this.tbAutorAgg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbAutorAgg.Location = new System.Drawing.Point(99, 84);
            this.tbAutorAgg.Name = "tbAutorAgg";
            this.tbAutorAgg.Size = new System.Drawing.Size(429, 20);
            this.tbAutorAgg.TabIndex = 11;
            // 
            // tbLibroAgg
            // 
            this.tbLibroAgg.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbLibroAgg.Location = new System.Drawing.Point(99, 31);
            this.tbLibroAgg.Name = "tbLibroAgg";
            this.tbLibroAgg.Size = new System.Drawing.Size(429, 20);
            this.tbLibroAgg.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "CANTIDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "UBICACIÓN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "AUTOR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "LIBRO";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(827, 802);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 33);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(711, 613);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(115, 33);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1366, 974);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbEncabezado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrBusqueda";
            this.Text = "FrBusqueda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbEncabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbLibroConsulta;
        private System.Windows.Forms.TextBox tbAutorConsulta;
        private System.Windows.Forms.TextBox tbLibroResultado;
        private System.Windows.Forms.TextBox tbAutorResultado;
        private System.Windows.Forms.TextBox tbUbicacion;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbEncabezado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbCantAgg;
        private System.Windows.Forms.TextBox tbUbiAgg;
        private System.Windows.Forms.TextBox tbAutorAgg;
        private System.Windows.Forms.TextBox tbLibroAgg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}