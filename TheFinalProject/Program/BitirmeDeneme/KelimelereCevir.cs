using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BitirmeDeneme
{
    class KelimelereCevir
    {
        

        public string[] KelimeAyir(string yazi)
        {
            
            char kontrol='a';
            char onceki='a';
            string yazibasi="";
            string yazisonu="";
            for (int i=0 ; i<yazi.Length ; i++)
            {
                onceki = kontrol;
                kontrol = yazi[i];
                if (kontrol == ' ' && onceki == ' ')
                { 
                    yazibasi=yazi.Remove(i-1);
                    yazisonu = yazi.Substring(i, (yazi.Length-i));
                    yazi = yazibasi + yazisonu;
                    i--;
                }
            }
            
            char[] ayraclar = { '/', ' ', '#', '.', ',', '!', '?', '-', '(', ')', '%', '+', '&', '*', '£' ,'"' };
            string[] kelimeler = yazi.Split(ayraclar);
            int kelimesayisi = 0;
            kelimesayisi = kelimeler.Length;
            
            string[] yenikelimeler = new string[9999];
            int sayac = 0;
            for(int i=0;i<kelimeler.Length;i++)
            {
                if (kelimeler[i] != " "&&kelimeler[i]!="")
                {  
                    yenikelimeler[sayac] = kelimeler[i];
                    sayac++;
                }
            }
            kontrol = 'b';
            yazibasi = "";
            yazisonu = "";
            for (int i = 0; i < yenikelimeler.Length; i++)
            {
                if (yenikelimeler[i] == null)
                    break;
                   for (int j = 0; j < yenikelimeler[i].Length; j++)
                   {
                         kontrol = yenikelimeler[i][j];
                         if (kontrol == '\'')
                         {
                         yazibasi = yenikelimeler[i].Remove(j);
                         yazisonu = yenikelimeler[i].Substring(j+1, (yenikelimeler[i].Length - j-1));
                         yenikelimeler[i] = yazibasi + yazisonu;
                         j--;
                        }
                    }
            }
            int uzunluk=0;
            for (int i = 0; i < yenikelimeler.Length; i++)
            {
                if (yenikelimeler[i] == null)
                { 
                    uzunluk = i;
                    break;
                }
            }
            string[] sonKelimeler = new string[uzunluk];
            for (int i = 0; i < uzunluk; i++)
            {
                if (yenikelimeler != null)
                {
                    sonKelimeler[i] = yenikelimeler[i];
                }
            }
            return sonKelimeler;
        }
    }
}