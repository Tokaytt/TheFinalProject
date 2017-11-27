using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeDeneme
{
    class Ekler
    {
        public static string[] gecici = new string[30];
        public static string[,] eklistesi = new string[4999, 30];
        public static void Ekle(int kelimeindex)
        {
            for (int i = 0; i < 30; i++)
            {
                if (eklistesi[kelimeindex, i] == null)
                {
                    for (int j = 0; gecici[j] != null; j++)
                    {
                        eklistesi[kelimeindex, i] = gecici[j];
                        i++;
                    }
                    break;
                }
            }
        }
        public static void geciciEkle(string ekAdi)
        {
            for (int i = 0; i < 30; i++)
            {
                if (gecici[i] == null)
                {
                    gecici[i] = ekAdi;
                    break;
                }
            }
        }
        public static void geciciSil()
        {
            for (int i = 0; i < 30; i++)
            {
                    gecici[i] = null;
            }
        }
        public static void Yaz(int index)
        {

            for (int i = 29; i >= 0; i--)
            {
                if (eklistesi[index, i] != null)
                {
                    Yazdir.text = Yazdir.text + eklistesi[index, i] + "\n";
                }
            }
        }
    }
}
