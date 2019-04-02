namespace Dominioo
{
    partial class ControlFormTramite
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
            this.OrdenarFin = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblidtramite = new System.Windows.Forms.Label();
            this.nomtramite = new System.Windows.Forms.Label();
            this.txttramite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OrdenarFin
            // 
            this.OrdenarFin.Location = new System.Drawing.Point(55, 160);
            this.OrdenarFin.Name = "OrdenarFin";
            this.OrdenarFin.Size = new System.Drawing.Size(75, 23);
            this.OrdenarFin.TabIndex = 0;
            this.OrdenarFin.Text = "Ordenar";
            this.OrdenarFin.UseVisualStyleBackColor = true;
            this.OrdenarFin.Click += new System.EventHandler(this.OrdenarFin_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(127, 49);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 1;
            // 
            // lblidtramite
            // 
            this.lblidtramite.AutoSize = true;
            this.lblidtramite.Location = new System.Drawing.Point(52, 52);
            this.lblidtramite.Name = "lblidtramite";
            this.lblidtramite.Size = new System.Drawing.Size(50, 13);
            this.lblidtramite.TabIndex = 2;
            this.lblidtramite.Text = "Id tramite";
            // 
            // nomtramite
            // 
            this.nomtramite.AutoSize = true;
            this.nomtramite.Location = new System.Drawing.Point(55, 92);
            this.nomtramite.Name = "nomtramite";
            this.nomtramite.Size = new System.Drawing.Size(44, 13);
            this.nomtramite.TabIndex = 3;
            this.nomtramite.Text = "Nombre";
            // 
            // txttramite
            // 
            this.txttramite.Location = new System.Drawing.Point(127, 84);
            this.txttramite.Name = "txttramite";
            this.txttramite.Size = new System.Drawing.Size(100, 20);
            this.txttramite.TabIndex = 4;
            // 
            // ControlFormTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 271);
            this.Controls.Add(this.txttramite);
            this.Controls.Add(this.nomtramite);
            this.Controls.Add(this.lblidtramite);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.OrdenarFin);
            this.Name = "ControlFormTramite";
            this.Text = "ControlFormTramite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrdenarFin;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblidtramite;
        private System.Windows.Forms.Label nomtramite;
        private System.Windows.Forms.TextBox txttramite;
    }
}