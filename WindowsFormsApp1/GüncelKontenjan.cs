using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Islemler;

namespace WindowsFormsApp1
{
    public partial class GüncelKontenjan : Form
    {
        double mevcutKontenjan;
        int sayac;
        string durum = "d";
        public GüncelKontenjan()
        {
            InitializeComponent();

           
        }
        public GüncelKontenjan(mKareGirisEkrani mG, double k)
        {
            InitializeComponent();
            mevcutKontenjan = k;
            sayiGösterim.Text = ((int)mevcutKontenjan).ToString();
            serialPort3.PortName = "COM3";
            serialPort3.BaudRate = 9600;
            serialPort3.Open();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string sonuc = serialPort3.ReadExisting();
                bilgi.Text = sonuc;

                bool donus = Hesaplamalar.kontenjanDonus(sonuc, (int)mevcutKontenjan);

                sayiGösterim.ForeColor = Color.White;
                sayiGösterim.Text = ($"Kontenjan Durumu: {(int)mevcutKontenjan}\n Kalan Kontenjan: {(int)mevcutKontenjan- Hesaplamalar.sayac}");
                if (durum=="a")
                {
                    serialPort3.Write(durum);
                }
                
                if (donus==true)
                {

                    durum = "a";
                   
                    MessageBox.Show("Kontenjan Doldu");
                    bilgi.Text = "";
                    label2.ForeColor = Color.Red;
                    label2.Text = "KONTENJAN DOLDU GİRİŞ YAPILAMAZ !";


                }
            }
            catch (Exception)
            {
                timer1.Stop();
            }
        }

        private void GüncelKontenjan_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort3.Close();
        }

        private void AnaPencereyeDönüs_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            serialPort3.Close();
            this.Close();
        }

        
    }
}
