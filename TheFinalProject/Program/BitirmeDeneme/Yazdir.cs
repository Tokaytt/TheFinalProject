using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeDeneme
{
    class Yazdir
    {
        public static string text;
        public void Yaz(string[] kelime0, string[] kelime1)
        {
            for (int i = 0; i < kelime0.Length; i++)
            {
                text = text + "*****************************\n";
                text = text + "Girilen Kelime  :   " + kelime1[i] + "\n";
                text = text + "Bölünmüş Hali   :   " + kelime0[i] + "\n";
                text = text + "*****************************\n";
                Ekler.Yaz(i);
                text = text + "*****************************\n";
            }
        }
    }
}
