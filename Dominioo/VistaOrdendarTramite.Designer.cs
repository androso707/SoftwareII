namespace Dominioo
{
    partial class VistaOrdendarTramite
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
            this.btnordenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnordenar
            // 
            this.btnordenar.Location = new System.Drawing.Point(221, 128);
            this.btnordenar.Name = "btnordenar";
            this.btnordenar.Size = new System.Drawing.Size(75, 23);
            this.btnordenar.TabIndex = 0;
            this.btnordenar.Text = "Ordenar Tramite";
            this.btnordenar.UseVisualStyleBackColor = true;
            this.btnordenar.Click += new System.EventHandler(this.btnordenar_Click);
            // 
            // VistaOrdendarTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 283);
            this.Controls.Add(this.btnordenar);
            this.Name = "VistaOrdendarTramite";
            this.Text = "VistaOrdendarTramite";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnordenar;
    }
}