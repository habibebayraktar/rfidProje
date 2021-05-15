
namespace WindowsFormsApp1
{
    partial class GüncelKontenjan
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
            this.sayiGösterim = new System.Windows.Forms.Label();
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bilgi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "GÜNCEL DURUM:";
            // 
            // sayiGösterim
            // 
            this.sayiGösterim.AutoSize = true;
            this.sayiGösterim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayiGösterim.ForeColor = System.Drawing.SystemColors.Control;
            this.sayiGösterim.Location = new System.Drawing.Point(175, 57);
            this.sayiGösterim.Name = "sayiGösterim";
            this.sayiGösterim.Size = new System.Drawing.Size(0, 13);
            this.sayiGösterim.TabIndex = 1;
            this.sayiGösterim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPort3
            // 
            this.serialPort3.PortName = "COM3";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bilgi
            // 
            this.bilgi.AutoSize = true;
            this.bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bilgi.Location = new System.Drawing.Point(146, 116);
            this.bilgi.Name = "bilgi";
            this.bilgi.Size = new System.Drawing.Size(0, 17);
            this.bilgi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(110, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 5;
            // 
            // GüncelKontenjan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(440, 214);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bilgi);
            this.Controls.Add(this.sayiGösterim);
            this.Controls.Add(this.label1);
            this.Name = "GüncelKontenjan";
            this.Text = "GüncelKontenjan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GüncelKontenjan_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sayiGösterim;
        private System.IO.Ports.SerialPort serialPort3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label bilgi;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
    }
}