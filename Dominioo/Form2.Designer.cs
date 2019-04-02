namespace Dominioo
{
    partial class Form2
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
            this.cedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tipovehiculo = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.experiencial = new System.Windows.Forms.TextBox();
            this.descripcionp = new System.Windows.Forms.TextBox();
            this.pasadojudicial = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.fechanacimiento = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.Registrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(163, 35);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(100, 20);
            this.cedula.TabIndex = 0;
            this.cedula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pasado Judicial";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cedula";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Apellidos";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Contraseña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Correo Electronico";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Experiencia Laboral";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(368, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Descripción de perfil";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(368, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Tipo Vehiculo";
            // 
            // tipovehiculo
            // 
            this.tipovehiculo.Location = new System.Drawing.Point(495, 179);
            this.tipovehiculo.Name = "tipovehiculo";
            this.tipovehiculo.Size = new System.Drawing.Size(100, 20);
            this.tipovehiculo.TabIndex = 15;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(495, 147);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(100, 20);
            this.contraseña.TabIndex = 16;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(495, 112);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 17;
            this.email.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // experiencial
            // 
            this.experiencial.Location = new System.Drawing.Point(495, 74);
            this.experiencial.Name = "experiencial";
            this.experiencial.Size = new System.Drawing.Size(100, 20);
            this.experiencial.TabIndex = 18;
            // 
            // descripcionp
            // 
            this.descripcionp.Location = new System.Drawing.Point(495, 35);
            this.descripcionp.Name = "descripcionp";
            this.descripcionp.Size = new System.Drawing.Size(100, 20);
            this.descripcionp.TabIndex = 19;
            // 
            // pasadojudicial
            // 
            this.pasadojudicial.Location = new System.Drawing.Point(163, 251);
            this.pasadojudicial.Name = "pasadojudicial";
            this.pasadojudicial.Size = new System.Drawing.Size(100, 20);
            this.pasadojudicial.TabIndex = 20;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(163, 219);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 21;
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(163, 183);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 20);
            this.direccion.TabIndex = 22;
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.Location = new System.Drawing.Point(163, 144);
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.Size = new System.Drawing.Size(100, 20);
            this.fechanacimiento.TabIndex = 23;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(163, 109);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 24;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(163, 74);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 25;
            this.nombre.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // Registrarse
            // 
            this.Registrarse.Location = new System.Drawing.Point(667, 265);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(75, 23);
            this.Registrarse.TabIndex = 26;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = true;
            this.Registrarse.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.fechanacimiento);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.pasadojudicial);
            this.Controls.Add(this.descripcionp);
            this.Controls.Add(this.experiencial);
            this.Controls.Add(this.email);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.tipovehiculo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cedula);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tipovehiculo;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox experiencial;
        private System.Windows.Forms.TextBox descripcionp;
        private System.Windows.Forms.TextBox pasadojudicial;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox fechanacimiento;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button Registrarse;
    }
}