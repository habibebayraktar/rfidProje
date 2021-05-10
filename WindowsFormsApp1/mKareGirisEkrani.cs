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
using WindowsFormsApp1.Siniflar;

namespace WindowsFormsApp1
{
    public partial class mKareGirisEkrani : Form
    {
        
        public mKareGirisEkrani()
        {
            InitializeComponent();

            radio1.Text = "Spor salonları ve fiziksel aktivitelerin yapıldığı diğer yerler";
            radio2.Text = "Müzeler, AVM'lerdeki iş yerleri, market ve süpermarketler";
            radio3.Text = "AVM ve Plazalar";
            radio4.Text = "Açık Hava Alanları";
            radio5.Text = "esnaflar, bakkallar, büfe, kantin ve bayiler," + Environment.NewLine + "gıda satış yerleri, kırtasiye ve giyim mağazaları," + Environment.NewLine + "kuyumcu,terzi, ayakkabı tadilat işletmeleri," + Environment.NewLine + "kuru temizlemeciler,mobilya mağazaları," + Environment.NewLine + "kozmetik mağazaları, akaryakıt istasyonları," + Environment.NewLine + "elektronik ve telekomünikasyon mağazaları";


            
        }

        private void kisiSayisiHesapla_Click(object sender, EventArgs e)
        {
            if (txtBoxMetreKare.Text.Length == 0)
            {
                MessageBox.Show(" m² bilgisi boş geçilemez !!");
            }
            else if (Hesaplamalar.SayiMi(txtBoxMetreKare.Text)==false)
            {
                MessageBox.Show("Sayısal değer girilmelidir. Harf, boşluk, özel karakter vb. girilemez !");
            }
            else if (radio1.Checked == false && radio2.Checked == false && radio3.Checked == false && radio4.Checked == false && radio5.Checked == false)
            {
                MessageBox.Show("Mekan Sınıflandırmasını Seçmelisinz !! ");
            }
            else
            {
                var mKare = Convert.ToDouble(txtBoxMetreKare.Text);
                double kontenjan = radio1.Checked == true ? Hesaplamalar.mKare6(mKare) : (radio2.Checked == true ? kontenjan = Hesaplamalar.mKare8(mKare) : (radio3.Checked == true ? kontenjan = Hesaplamalar.mKare10(mKare) : (radio4.Checked == true ? kontenjan = Hesaplamalar.mKare4(mKare) : (radio5.Checked == true ? Hesaplamalar.mKare4(mKare) : 0))));

                GüncelKontenjan gk = new GüncelKontenjan(this, kontenjan);
                gk.Show();
                MessageBox.Show("İşlem başarılı, kontenjan hakkı : "+ ((int)kontenjan).ToString());
                this.Hide();

            }
        }
        private void donus_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
