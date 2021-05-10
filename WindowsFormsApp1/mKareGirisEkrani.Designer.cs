
namespace WindowsFormsApp1
{
    partial class mKareGirisEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMetreKare = new System.Windows.Forms.TextBox();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            this.kisiSayisiHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "m² bilgisini giriniz:";
            // 
            // txtBoxMetreKare
            // 
            this.txtBoxMetreKare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxMetreKare.Location = new System.Drawing.Point(161, 47);
            this.txtBoxMetreKare.Multiline = true;
            this.txtBoxMetreKare.Name = "txtBoxMetreKare";
            this.txtBoxMetreKare.Size = new System.Drawing.Size(200, 27);
            this.txtBoxMetreKare.TabIndex = 1;
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio1.Location = new System.Drawing.Point(89, 102);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(14, 13);
            this.radio1.TabIndex = 2;
            this.radio1.TabStop = true;
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio2.Location = new System.Drawing.Point(89, 149);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(14, 13);
            this.radio2.TabIndex = 3;
            this.radio2.TabStop = true;
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio3.Location = new System.Drawing.Point(89, 192);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(14, 13);
            this.radio3.TabIndex = 4;
            this.radio3.TabStop = true;
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio4.Location = new System.Drawing.Point(89, 240);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(14, 13);
            this.radio4.TabIndex = 5;
            this.radio4.TabStop = true;
            this.radio4.UseVisualStyleBackColor = true;
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio5.Location = new System.Drawing.Point(89, 286);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(14, 13);
            this.radio5.TabIndex = 6;
            this.radio5.TabStop = true;
            this.radio5.UseVisualStyleBackColor = true;
            // 
            // kisiSayisiHesapla
            // 
            this.kisiSayisiHesapla.Location = new System.Drawing.Point(31, 385);
            this.kisiSayisiHesapla.Name = "kisiSayisiHesapla";
            this.kisiSayisiHesapla.Size = new System.Drawing.Size(359, 40);
            this.kisiSayisiHesapla.TabIndex = 7;
            this.kisiSayisiHesapla.Text = "m²\' ye Düşen Kişi Sayısını Hesapla";
            this.kisiSayisiHesapla.UseVisualStyleBackColor = true;
            this.kisiSayisiHesapla.Click += new System.EventHandler(this.kisiSayisiHesapla_Click);
            // 
            // mKareGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(444, 451);
            this.Controls.Add(this.kisiSayisiHesapla);
            this.Controls.Add(this.radio5);
            this.Controls.Add(this.radio4);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.txtBoxMetreKare);
            this.Controls.Add(this.label1);
            this.Name = "mKareGirisEkrani";
            this.RightToLeftLayout = true;
            this.Tag = "";
            this.Text = "mKareGirisEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMetreKare;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.RadioButton radio5;
        private System.Windows.Forms.Button kisiSayisiHesapla;
    }
}