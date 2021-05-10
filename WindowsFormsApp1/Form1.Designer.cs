
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.metreKareGiris = new System.Windows.Forms.Button();
            this.KisiKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metreKareGiris
            // 
            this.metreKareGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metreKareGiris.Location = new System.Drawing.Point(92, 51);
            this.metreKareGiris.Name = "metreKareGiris";
            this.metreKareGiris.Size = new System.Drawing.Size(136, 37);
            this.metreKareGiris.TabIndex = 0;
            this.metreKareGiris.Text = " m² giriş";
            this.metreKareGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.metreKareGiris.UseVisualStyleBackColor = true;
            this.metreKareGiris.Click += new System.EventHandler(this.metreKareGiris_Click);
            // 
            // KisiKayit
            // 
            this.KisiKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KisiKayit.Location = new System.Drawing.Point(92, 116);
            this.KisiKayit.Name = "KisiKayit";
            this.KisiKayit.Size = new System.Drawing.Size(136, 41);
            this.KisiKayit.TabIndex = 1;
            this.KisiKayit.Text = "Kart Tanımla";
            this.KisiKayit.UseVisualStyleBackColor = true;
            this.KisiKayit.Click += new System.EventHandler(this.KisiKayit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.KisiKayit);
            this.Controls.Add(this.metreKareGiris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button metreKareGiris;
        private System.Windows.Forms.Button KisiKayit;
    }
}

