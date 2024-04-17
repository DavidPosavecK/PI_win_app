namespace FastClean
{
    partial class frmOdabir
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
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPrikaz.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrikaz.Location = new System.Drawing.Point(147, 30);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(173, 56);
            this.btnPrikaz.TabIndex = 0;
            this.btnPrikaz.Text = "Prikaz klijenata";
            this.btnPrikaz.UseVisualStyleBackColor = false;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDodaj.ForeColor = System.Drawing.Color.Transparent;
            this.btnDodaj.Location = new System.Drawing.Point(147, 142);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(173, 56);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodavanje klijenta";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmOdabir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(464, 269);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnPrikaz);
            this.Name = "frmOdabir";
            this.Text = "Odabir";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Button btnDodaj;
    }
}

