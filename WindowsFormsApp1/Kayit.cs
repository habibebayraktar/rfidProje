using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Islemler;
using WindowsFormsApp1.Siniflar;

namespace WindowsFormsApp1
{
    public partial class Kayit : Form
    {
        bool d = false;
        public Kayit()
        {
            InitializeComponent();
            

        }

        private void btn_KartKayit_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;
            
            KayitContext ctx = new KayitContext();
            bool durum = true;
            if (txtBox_HesKodu.Text == "" || txtBox_TcNo.Text == "" || txtBox_KartNum.Text == "" || txtBox_Ad.Text == "" || txtBox_Soyad.Text == "" || txtBox_KartNum.Text == "" )
            {
                MessageBox.Show("Alanlar Boş Geçilemez !");
                durum = false;
            }
            else if (Hesaplamalar.SayiMi(txtBox_TcNo.Text)==false)
            {
                MessageBox.Show("Tc alanına sayisal değer dışında herhangi bir değer girilemez");
                txtBox_TcNo.Text = "";
                durum = false;
            }
            else if (Hesaplamalar.SayiMi(txtBox_KartNum.Text)==false)
            {
                MessageBox.Show("Kart numarası alanına sayisal değer dışında herhangi bir değer(harf/boşluk) girilemez");
                txtBox_KartNum.Text = "";
                durum = false;
            }
            else if (txtBox_TcNo.Text.Length < 11)
            {
                 MessageBox.Show("TC Alanı Eksik !!");
                 durum = false;
            }
            else if (txtBox_KartNum.Text.Length<10)
            {
                MessageBox.Show("Kart Numara Alanı Eksik !!");
                durum = false;
            }
            else if (txtBox_HesKodu.Text != "" || txtBox_TcNo.Text != "" || txtBox_KartNum.Text != "")
            {
                foreach (var item in ctx.Kisiler)
                {
                    if (item.Tc == txtBox_TcNo.Text)
                    {
                        MessageBox.Show("Bu Tc Bilgisiyle Kayıt Mevcut");
                        durum = false;
                    }
                    else if (item.HesKodu == txtBox_HesKodu.Text)
                    {
                        MessageBox.Show("Hes Kodu Sistemde Başkasına Ait");
                        durum = false;
                    }
                    else if (item.kartNumara== txtBox_KartNum.Text)
                    {
                        MessageBox.Show("Kart Sisteme Kayıtlı");
                        durum = false;
                    }
                    
                }
            }
            else
            {
                durum = true;
            }
            if (durum)
            {
                serialPort1.Open();
                using (ctx)
                {
                    try
                    {
                        ctx.Kisiler.Add(new Kisi { Ad = txtBox_Ad.Text, Soyad = txtBox_Soyad.Text, Tc = txtBox_TcNo.Text, HesKodu = txtBox_HesKodu.Text, kartNumara = txtBox_KartNum.Text, KayitTarihi = TimePckr_KartOlusumTarihi.Value });
                        int sonuc = ctx.SaveChanges();
                        d = true;
                        timer1.Start();
                        MessageBox.Show(sonuc > 0 ? "Kart Kayıt İşlemi Başarılı" : "Kart Kayıt İşlemi Başarısız");
                        txtBox_Ad.Text = "";
                        txtBox_Soyad.Text = "";
                        txtBox_TcNo.Text = "";
                        txtBox_HesKodu.Text = "";
                        txtBox_KartNum.Text = "";

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            

            
            

        }

        private void btn_KartNumOgren_Click(object sender, EventArgs e)
        {
            KartBilgi kartBilgi = new KartBilgi();
            serialPort1.Close();
            kartBilgi.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (d==true)
                {
                    serialPort1.Write("b");
                    d = false;
                }
            }
            catch (Exception)
            {
                timer1.Stop();
                throw;
            }
        }

        private void Kayit_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }
    }
}
