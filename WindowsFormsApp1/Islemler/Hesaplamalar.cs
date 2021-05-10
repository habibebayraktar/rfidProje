using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Islemler
{
    public class Hesaplamalar
    {
        public static double mKare6(double Alan)
        {
            double gönderim = Alan / 6;
            return gönderim;
        }
        public static double mKare8(double Alan)
        {
            double gönderim = Alan / 8;
            return gönderim;
        }
        public static double mKare10(double Alan)
        {
            double gönderim = Alan / 10;
            return gönderim;
        }
        public static double mKare4(double Alan)
        {
            double gönderim = Alan / 4;
            return gönderim;
        }
        public static int sayac { get; set; }
        public static bool kontenjanDonus(string gelenText, int kontenjan)
        {
            
            if (gelenText== "Giris Yapildi\r\n" )
            {
                sayac++;
                if (sayac==kontenjan)
                {
                    return true;
                }
                return false;
            }
            
            return false;
        }
        public int sayiDonus()
        {
            return sayac;
        }

        public static bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
    }
}
