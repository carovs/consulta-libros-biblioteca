namespace WindowsFormsApp2
{
    partial class FrmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistro));
            this.tbContrasena1 = new System.Windows.Forms.TextBox();
            this.tbContrasena2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.tbContrasenai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbRegistrarse = new System.Windows.Forms.GroupBox();
            this.gbIngresar = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbEncabezado = new System.Windows.Forms.GroupBox();
            this.gbRegistrarse.SuspendLayout();
            this.gbIngresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbContrasena1
            // 
            this.tbContrasena1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbContrasena1.Location = new System.Drawing.Point(258, 113);
            this.tbContrasena1.Name = "tbContrasena1";
            this.tbContrasena1.Size = new System.Drawing.Size(242, 20);
            this.tbContrasena1.TabIndex = 2;
            // 
            // tbContrasena2
            // 
            this.tbContrasena2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbContrasena2.Location = new System.Drawing.Point(258, 139);
            this.tbContrasena2.Name = "tbContrasena2";
            this.tbContrasena2.Size = new System.Drawing.Size(242, 20);
            this.tbContrasena2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE COMPLETO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CEDULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CONTRASEÑA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // tbnombre
            // 
            this.tbnombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbnombre.Location = new System.Drawing.Point(258, 60);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(242, 20);
            this.tbnombre.TabIndex = 8;
            // 
            // tbCedula
            // 
            this.tbCedula.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbCedula.Location = new System.Drawing.Point(258, 86);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(242, 20);
            this.tbCedula.TabIndex = 9;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRegistrarse.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarse.Image")));
            this.btnRegistrarse.Location = new System.Drawing.Point(258, 298);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(115, 23);
            this.btnRegistrarse.TabIndex = 12;
            this.btnRegistrarse.Text = "REGISTRARSE";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnregistrarse_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.Location = new System.Drawing.Point(212, 298);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(115, 23);
            this.btnIngresar.TabIndex = 18;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // tbContrasenai
            // 
            this.tbContrasenai.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbContrasenai.Location = new System.Drawing.Point(198, 139);
            this.tbContrasenai.Name = "tbContrasenai";
            this.tbContrasenai.Size = new System.Drawing.Size(181, 20);
            this.tbContrasenai.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "CONTRASEÑA";
            // 
            // tbDocumento
            // 
            this.tbDocumento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbDocumento.Location = new System.Drawing.Point(198, 60);
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.Size = new System.Drawing.Size(181, 20);
            this.tbDocumento.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "DOCUMENTO";
            // 
            // gbRegistrarse
            // 
            this.gbRegistrarse.Controls.Add(this.btnRegistrarse);
            this.gbRegistrarse.Controls.Add(this.tbCedula);
            this.gbRegistrarse.Controls.Add(this.tbnombre);
            this.gbRegistrarse.Controls.Add(this.label4);
            this.gbRegistrarse.Controls.Add(this.label3);
            this.gbRegistrarse.Controls.Add(this.label2);
            this.gbRegistrarse.Controls.Add(this.label1);
            this.gbRegistrarse.Controls.Add(this.tbContrasena2);
            this.gbRegistrarse.Controls.Add(this.tbContrasena1);
            this.gbRegistrarse.Location = new System.Drawing.Point(44, 202);
            this.gbRegistrarse.Name = "gbRegistrarse";
            this.gbRegistrarse.Size = new System.Drawing.Size(593, 411);
            this.gbRegistrarse.TabIndex = 19;
            this.gbRegistrarse.TabStop = false;
            this.gbRegistrarse.Text = "REGISTRO";
            // 
            // gbIngresar
            // 
            this.gbIngresar.Controls.Add(this.btnIngresar);
            this.gbIngresar.Controls.Add(this.tbContrasenai);
            this.gbIngresar.Controls.Add(this.label5);
            this.gbIngresar.Controls.Add(this.tbDocumento);
            this.gbIngresar.Controls.Add(this.label6);
            this.gbIngresar.Location = new System.Drawing.Point(667, 202);
            this.gbIngresar.Name = "gbIngresar";
            this.gbIngresar.Size = new System.Drawing.Size(496, 411);
            this.gbIngresar.TabIndex = 20;
            this.gbIngresar.TabStop = false;
            this.gbIngresar.Text = "INICIO DE SESION";
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
            // gbEncabezado
            // 
            this.gbEncabezado.Controls.Add(this.pictureBox2);
            this.gbEncabezado.Controls.Add(this.pictureBox1);
            this.gbEncabezado.Location = new System.Drawing.Point(44, 17);
            this.gbEncabezado.Name = "gbEncabezado";
            this.gbEncabezado.Size = new System.Drawing.Size(1119, 179);
            this.gbEncabezado.TabIndex = 21;
            this.gbEncabezado.TabStop = false;
            this.gbEncabezado.Text = " ";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1233, 643);
            this.Controls.Add(this.gbEncabezado);
            this.Controls.Add(this.gbIngresar);
            this.Controls.Add(this.gbRegistrarse);
            this.Name = "FrmRegistro";
            this.Text = "Form2";
            this.gbRegistrarse.ResumeLayout(false);
            this.gbRegistrarse.PerformLayout();
            this.gbIngresar.ResumeLayout(false);
            this.gbIngresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbEncabezado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbContrasena1;
        private System.Windows.Forms.TextBox tbContrasena2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox tbContrasenai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbRegistrarse;
        private System.Windows.Forms.GroupBox gbIngresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbEncabezado;
    }
}