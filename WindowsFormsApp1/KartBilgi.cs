using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class KartBilgi : Form
    {
        
        public KartBilgi()
        {
            InitializeComponent();
            serialPort2.PortName = "COM3";
            serialPort2.BaudRate = 9600;
            serialPort2.Open();
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                string okunan = serialPort2.ReadExisting();
                if (okunan != "Giris Yapildi\r\n" && okunan != "Kapi kapandi\r\n" && okunan != "Yetkisiz Kart\r\n" && okunan !="" && okunan !=" ")
                {

                    lbl_KartNum.Text = okunan;

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void KartBilgi_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort2.Close();
        }
    }
}
