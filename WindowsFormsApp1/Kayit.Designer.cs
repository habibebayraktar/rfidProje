
namespace WindowsFormsApp1
{
    partial class Kayit
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Ad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Soyad = new System.Windows.Forms.TextBox();
            this.txtBox_TcNo = new System.Windows.Forms.TextBox();
            this.txtBox_HesKodu = new System.Windows.Forms.TextBox();
            this.txtBox_KartNum = new System.Windows.Forms.TextBox();
            this.TimePckr_KartOlusumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btn_KartKayit = new System.Windows.Forms.Button();
            this.btn_KartNumOgren = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // txtBox_Ad
            // 
            this.txtBox_Ad.Location = new System.Drawing.Point(138, 27);
            this.txtBox_Ad.MaxLength = 70;
            this.txtBox_Ad.Name = "txtBox_Ad";
            this.txtBox_Ad.Size = new System.Drawing.Size(170, 20);
            this.txtBox_Ad.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.label7.Location = new System.Drawing.Point(36, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(36, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.label3.Location = new System.Drawing.Point(36, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "HES Kodu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.label4.Location = new System.Drawing.Point(36, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kart Numara :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.label5.Location = new System.Drawing.Point(36, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kart Oluşum Tarihi :";
            // 
            // txtBox_Soyad
            // 
            this.txtBox_Soyad.Location = new System.Drawing.Point(138, 66);
            this.txtBox_Soyad.MaxLength = 70;
            this.txtBox_Soyad.Name = "txtBox_Soyad";
            this.txtBox_Soyad.Size = new System.Drawing.Size(170, 20);
            this.txtBox_Soyad.TabIndex = 12;
            // 
            // txtBox_TcNo
            // 
            this.txtBox_TcNo.Location = new System.Drawing.Point(138, 106);
            this.txtBox_TcNo.MaxLength = 11;
            this.txtBox_TcNo.Name = "txtBox_TcNo";
            this.txtBox_TcNo.Size = new System.Drawing.Size(170, 20);
            this.txtBox_TcNo.TabIndex = 13;
            // 
            // txtBox_HesKodu
            // 
            this.txtBox_HesKodu.Location = new System.Drawing.Point(138, 146);
            this.txtBox_HesKodu.MaxLength = 20;
            this.txtBox_HesKodu.Name = "txtBox_HesKodu";
            this.txtBox_HesKodu.Size = new System.Drawing.Size(170, 20);
            this.txtBox_HesKodu.TabIndex = 14;
            // 
            // txtBox_KartNum
            // 
            this.txtBox_KartNum.Location = new System.Drawing.Point(138, 186);
            this.txtBox_KartNum.MaxLength = 10;
            this.txtBox_KartNum.Name = "txtBox_KartNum";
            this.txtBox_KartNum.Size = new System.Drawing.Size(170, 20);
            this.txtBox_KartNum.TabIndex = 15;
            // 
            // TimePckr_KartOlusumTarihi
            // 
            this.TimePckr_KartOlusumTarihi.Location = new System.Drawing.Point(177, 233);
            this.TimePckr_KartOlusumTarihi.Name = "TimePckr_KartOlusumTarihi";
            this.TimePckr_KartOlusumTarihi.Size = new System.Drawing.Size(131, 20);
            this.TimePckr_KartOlusumTarihi.TabIndex = 16;
            // 
            // btn_KartKayit
            // 
            this.btn_KartKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.btn_KartKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KartKayit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_KartKayit.Location = new System.Drawing.Point(39, 294);
            this.btn_KartKayit.Name = "btn_KartKayit";
            this.btn_KartKayit.Size = new System.Drawing.Size(269, 49);
            this.btn_KartKayit.TabIndex = 17;
            this.btn_KartKayit.Text = "Kart Kayıt";
            this.btn_KartKayit.UseVisualStyleBackColor = false;
            this.btn_KartKayit.Click += new System.EventHandler(this.btn_KartKayit_Click);
            // 
            // btn_KartNumOgren
            // 
            this.btn_KartNumOgren.BackColor = System.Drawing.SystemColors.Control;
            this.btn_KartNumOgren.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KartNumOgren.Location = new System.Drawing.Point(314, 181);
            this.btn_KartNumOgren.Name = "btn_KartNumOgren";
            this.btn_KartNumOgren.Size = new System.Drawing.Size(141, 27);
            this.btn_KartNumOgren.TabIndex = 18;
            this.btn_KartNumOgren.Text = "Kart Numara Öğren";
            this.btn_KartNumOgren.UseVisualStyleBackColor = false;
            this.btn_KartNumOgren.Click += new System.EventHandler(this.btn_KartNumOgren_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(467, 393);
            this.Controls.Add(this.btn_KartNumOgren);
            this.Controls.Add(this.btn_KartKayit);
            this.Controls.Add(this.TimePckr_KartOlusumTarihi);
            this.Controls.Add(this.txtBox_KartNum);
            this.Controls.Add(this.txtBox_HesKodu);
            this.Controls.Add(this.txtBox_TcNo);
            this.Controls.Add(this.txtBox_Soyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBox_Ad);
            this.Controls.Add(this.label1);
            this.Name = "Kayit";
            this.Text = "Kayıt Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kayit_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Ad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_Soyad;
        private System.Windows.Forms.TextBox txtBox_TcNo;
        private System.Windows.Forms.TextBox txtBox_HesKodu;
        private System.Windows.Forms.TextBox txtBox_KartNum;
        private System.Windows.Forms.DateTimePicker TimePckr_KartOlusumTarihi;
        private System.Windows.Forms.Button btn_KartKayit;
        private System.Windows.Forms.Button btn_KartNumOgren;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}