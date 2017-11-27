using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeDeneme
{
    class KontrolEylemZaman
    {
        Boolean durum = false;
        int tireindex;
        int lokasyon = 1;
        int kelimeindex;
        public string[] KontrolEZ(string[] kelimedizisi)
        {
            string[] kontrolkelimeler = new string[kelimedizisi.Length];
            kontrolkelimeler = kelimedizisi;
            for (int i = 0; i < kontrolkelimeler.Length; i++)
            {
                kelimeindex = i;
                kontrolkelimeler[i] = kontrol(kontrolkelimeler[i]);
                Ekler.geciciSil();
            }
            return kontrolkelimeler;
        }

        private int indexbul(string kelime)
        {

            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime[i] == '-' || kelime[i] == '(')
                    return i;
            }
            return kelime.Length;

        }
        private string kontrol(string kelime)
        {
            lokasyon = 1;
            string sonsaglam = kelime;
            int yol = 0;

            tireindex = indexbul(kelime);
            switch (lokasyon)
            {
                case 1:
                    yol = 19;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 1;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 2;
                        goto case 2;
                    }
                    yol = 13;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 7;
                        goto case 7;
                    }
                    yol = 2;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    yol = 22;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 29;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 12;
                        goto case 12;
                    }
                    yol = 4;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 2;
                        goto case 2;
                    }
                    yol = 21;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 16;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 7;
                        goto case 7;
                    }
                    yol = 3;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 4;
                        goto case 4;
                    }
                    yol = 23;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 24;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 9;
                        goto case 9;
                    }
                    yol = 5;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 5;
                        goto case 5;
                    }
                    yol = 9;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 27;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 10;
                        goto case 10;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 28;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 11;
                        goto case 11;
                    }
                    yol = 11;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 26;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 10;
                        goto case 10;
                    }
                    yol = 18;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 20;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 25;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 10;
                        goto case 10;
                    }
                    yol = 17;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 14;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 7;
                        goto case 7;
                    }
                    yol = 15;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 7;
                        goto case 7;
                    }
                    goto default;
                case 2:
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 9;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 27;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 15;
                        goto case 15;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 11;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 20;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    goto default;
                case 3:
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 9;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 27;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 15;
                        goto case 15;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 11;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 20;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    goto default;
                case 4:
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 9;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 27;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 15;
                        goto case 15;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 11;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    goto default;
                case 5:
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 9;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 27;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 15;
                        goto case 15;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 11;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 26;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 15;
                        goto case 15;
                    }
                    yol = 18;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 20;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 25;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 15;
                        goto case 15;
                    }
                    yol = 17;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    goto default;
                case 6:
                    goto default;
                case 7:
                    yol = 26;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 15;
                        goto case 15;
                    }
                    yol = 18;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 25;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 15;
                        goto case 15;
                    }
                    yol = 17;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    goto default;
                case 8:
                    yol = 20;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    goto default;
                case 9:
                    yol = 1;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 2;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 4;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 3;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 5;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 9;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 11;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    goto default;
                case 10:
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 5;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 14;
                        goto case 14;
                    }
                    yol = 9;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 11;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 18;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 20;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 17;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    goto default;
                case 11:
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 5;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 9;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 27;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 10;
                        goto case 10;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 11;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    goto default;
                case 12:
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 5;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 9;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 11;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    goto default;
                case 13:
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 9;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 11;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    goto default;
                case 14:
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 9;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 11;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    goto default;
                case 15:
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 9;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 11;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 18;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 20;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 17;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    goto default;
                default:
                    break;
            }
            return sonsaglam;
        }
        private string dene(int yol, string kelime)
        {
            durum = false;
            string yazibasi;
            string yazisonu;
            tireindex = indexbul(kelime);
            switch (yol)
            {
                case 1:
                    if (tireindex - 3 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'm')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'y')
                            {
                                char harf = kelime[tireindex - 3];
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length - 1));
                                kelime = yazibasi + "-" + "(" + harf + ")" + yazisonu;
                            }
                            else
                            {
                                yazibasi = kelime.Remove(tireindex - 2);
                                yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;
                            }
                            durum = true;
                            Ekler.geciciEkle("1. t.k. - EZ");
                        }
                    }
                    break;
                case 2:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'n')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 's')
                            {
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                                durum = true;
                                Ekler.geciciEkle("2. t.k. - EZ");
                            }
                        }
                    }
                    break;
                case 3:
                    if (tireindex - 3 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'z')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'y')
                            {
                                char harf = kelime[tireindex - 3];
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length - 1));
                                kelime = yazibasi + "-" + "(" + harf + ")" + yazisonu;

                            }
                            else
                            {
                                yazibasi = kelime.Remove(tireindex - 2);
                                yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;
                            }
                            durum = true;
                            Ekler.geciciEkle("1. ç.k. - EZ");
                        }
                    }
                    break;
                case 4:
                    if (tireindex - 5 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'z')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'n')
                            {
                                if (kelime[tireindex - 4] == 'i' || kelime[tireindex - 4] == 'ı' || kelime[tireindex - 4] == 'u' || kelime[tireindex - 4] == 'ü')
                                {
                                    if (kelime[tireindex - 5] == 's')
                                    {
                                        yazibasi = kelime.Remove(tireindex - 5);
                                        yazisonu = kelime.Substring(tireindex - 5, (kelime.Length - yazibasi.Length));
                                        kelime = yazibasi + "-" + yazisonu;

                                        durum = true;
                                        Ekler.geciciEkle("2. ç.k. - EZ");
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 5:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'r')
                    {
                        if (kelime[tireindex - 2] == 'a' || kelime[tireindex - 2] == 'e')
                        {
                            if (kelime[tireindex - 3] == 'l')
                            {
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                                durum = true;
                                Ekler.geciciEkle("3. ç.k. - EZ");
                            }
                        }
                    }
                    break;
                case 6:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'ş')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'm')
                            {
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                                durum = true;
                                Ekler.geciciEkle("miş'li g.z. - EZ");
                            }
                        }
                    }
                    break;
                case 7:
                    if (tireindex - 5 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'k')
                    {
                        if (kelime[tireindex - 2] == 'a' || kelime[tireindex - 2] == 'e')
                        {
                            if (kelime[tireindex - 3] == 'c')
                            {
                                if (kelime[tireindex - 4] == 'a' || kelime[tireindex - 4] == 'e')
                                {

                                    if (kelime[tireindex - 5] == 'y')
                                    {
                                        char harf = kelime[tireindex - 5];
                                        yazibasi = kelime.Remove(tireindex - 5);
                                        yazisonu = kelime.Substring(tireindex - 4, (kelime.Length - yazibasi.Length - 1));
                                        kelime = yazibasi + "-" + "(" + harf + ")" + yazisonu;

                                    }
                                    else
                                    {
                                        yazibasi = kelime.Remove(tireindex - 4);
                                        yazisonu = kelime.Substring(tireindex - 4, (kelime.Length - yazibasi.Length));
                                        kelime = yazibasi + "-" + yazisonu;

                                    }
                                    durum = true;
                                    Ekler.geciciEkle("gelecek z. - EZ");
                                }
                            }
                        }
                    }
                    break;
                case 8:
                    if (tireindex - 2 < 2)
                        goto default;


                    if (kelime[tireindex - 2] == 'r')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            char harf = kelime[tireindex - 2];
                            yazibasi = kelime.Remove(tireindex - 2);
                            yazisonu = kelime.Substring(tireindex - 1, (kelime.Length - yazibasi.Length - 1));
                            kelime = yazibasi + "-" + "(" + harf + ")" + yazisonu;

                        }
                        else
                        {
                            yazibasi = kelime.Remove(tireindex - 1);
                            yazisonu = kelime.Substring(tireindex - 1, (kelime.Length - yazibasi.Length));
                            kelime = yazibasi + "-" + yazisonu;
                        }
                        durum = true;
                        Ekler.geciciEkle("geniş z. - EZ");
                    }
                    break;
                case 9:
                    if (tireindex - 2 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'r')
                    {
                        if (kelime[tireindex - 2] == 'e' || kelime[tireindex - 2] == 'a')
                        {

                            yazibasi = kelime.Remove(tireindex - 2);
                            yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                            kelime = yazibasi + "-" + yazisonu;

                            durum = true;
                            Ekler.geciciEkle("geniş z. - EZ");
                        }
                    }
                    break;
                case 10:
                    if (tireindex - 4 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'r')
                    {
                        if (kelime[tireindex - 2] == 'o')
                        {
                            if (kelime[tireindex - 3] == 'y')
                            {

                                if (kelime[tireindex - 4] == 'i' || kelime[tireindex - 4] == 'ı' || kelime[tireindex - 4] == 'u' || kelime[tireindex - 4] == 'ü')
                                {
                                    char harf = kelime[tireindex - 4];
                                    yazibasi = kelime.Remove(tireindex - 4);
                                    yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length - 1));
                                    kelime = yazibasi + "-" + "(" + harf + ")" + yazisonu;

                                }
                                else
                                {
                                    yazibasi = kelime.Remove(tireindex - 3);
                                    yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                    kelime = yazibasi + "-" + yazisonu;

                                }
                                durum = true;
                                Ekler.geciciEkle("şimdiki z. - EZ");
                            }
                        }
                    }
                    break;
                case 11:
                    if (tireindex - 5 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 't')
                        {
                            if (kelime[tireindex - 3] == 'k')
                            {
                                if (kelime[tireindex - 4] == 'a' || kelime[tireindex - 4] == 'e')
                                {
                                    if (kelime[tireindex - 5] == 'm')
                                    {
                                        yazibasi = kelime.Remove(tireindex - 5);
                                        yazisonu = kelime.Substring(tireindex - 5, (kelime.Length - yazibasi.Length));
                                        kelime = yazibasi + "-" + yazisonu;

                                        durum = true;
                                        Ekler.geciciEkle("sürerlilik - EZ");
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 12:
                    if (tireindex - 4 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'ı' || kelime[tireindex - 1] == 'i')
                    {
                        if (kelime[tireindex - 2] == 'l')
                        {
                            if (kelime[tireindex - 3] == 'a' || kelime[tireindex - 3] == 'e')
                            {
                                if (kelime[tireindex - 4] == 'm')
                                {

                                    yazibasi = kelime.Remove(tireindex - 4);
                                    yazisonu = kelime.Substring(tireindex - 4, (kelime.Length - yazibasi.Length));
                                    kelime = yazibasi + "-" + yazisonu;

                                    durum = true;
                                    Ekler.geciciEkle("gereklilik - EZ");

                                }
                            }
                        }
                    }
                    break;
                case 13:
                    if (tireindex - 1 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'm')
                    {
                        yazibasi = kelime.Remove(tireindex - 1);
                        yazisonu = kelime.Substring(tireindex - 1, (kelime.Length - yazibasi.Length));
                        kelime = yazibasi + "-" + yazisonu;

                        durum = true;
                        Ekler.geciciEkle("1. t.k. - EZ");
                    }
                    break;
                case 14:
                    if (tireindex - 1 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'n')
                    {
                        yazibasi = kelime.Remove(tireindex - 1);
                        yazisonu = kelime.Substring(tireindex - 1, (kelime.Length - yazibasi.Length));
                        kelime = yazibasi + "-" + yazisonu;

                        durum = true;
                        Ekler.geciciEkle("2. t.k. - EZ");
                    }
                    break;
                case 15:
                    if (tireindex - 1 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'k')
                    {
                        yazibasi = kelime.Remove(tireindex - 1);
                        yazisonu = kelime.Substring(tireindex - 1, (kelime.Length - yazibasi.Length));
                        kelime = yazibasi + "-" + yazisonu;

                        durum = true;
                        Ekler.geciciEkle("1. ç.k. - EZ");
                    }
                    break;
                case 16:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'z')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'n')
                            {
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                                durum = true;
                                Ekler.geciciEkle("2. ç.k. - EZ");
                            }
                        }
                    }
                    break;
                case 17:
                    if (tireindex - 2 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'i' || kelime[tireindex - 1] == 'ı' || kelime[tireindex - 1] == 'u' || kelime[tireindex - 1] == 'ü')
                    {
                        if (kelime[tireindex - 2] == 'd' || kelime[tireindex - 2] == 't')
                        {

                            yazibasi = kelime.Remove(tireindex - 2);
                            yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                            kelime = yazibasi + "-" + yazisonu;

                            durum = true;
                            Ekler.geciciEkle("di'li g.z. - EZ");
                        }
                    }
                    break;
                case 18:
                    if (tireindex - 2 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 's')
                        {

                            yazibasi = kelime.Remove(tireindex - 2);
                            yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                            kelime = yazibasi + "-" + yazisonu;

                            durum = true;
                            Ekler.geciciEkle("dilek-şart - EZ");
                        }
                    }
                    break;
                case 19:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'm')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı')
                        {
                            if (kelime[tireindex - 3] == 'l')
                            {
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                                durum = true;
                                Ekler.geciciEkle("1. ç.k. - EZ");
                            }
                        }
                    }
                    break;
                case 20:
                    if (tireindex - 2 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 'y')
                        {
                            char harf = kelime[tireindex - 2];
                            yazibasi = kelime.Remove(tireindex - 2);
                            yazisonu = kelime.Substring(tireindex - 1, (kelime.Length - yazibasi.Length - 1));
                            kelime = yazibasi + "-" + "(" + harf + ")" + yazisonu;

                        }
                        else
                        {
                            yazibasi = kelime.Remove(tireindex - 1);
                            yazisonu = kelime.Substring(tireindex - 1, (kelime.Length - yazibasi.Length));
                            kelime = yazibasi + "-" + yazisonu;
                        }

                        durum = true;
                        Ekler.geciciEkle("istek - EZ");
                    }
                    break;
                case 21:
                    if (tireindex - 5 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'z')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'n')
                            {
                                if (kelime[tireindex - 4] == 'i' || kelime[tireindex - 4] == 'ı' || kelime[tireindex - 4] == 'u' || kelime[tireindex - 4] == 'ü')
                                {
                                    if (kelime[tireindex - 5] == 'y')
                                    {
                                        char harf = kelime[tireindex - 5];
                                        yazibasi = kelime.Remove(tireindex - 5);
                                        yazisonu = kelime.Substring(tireindex - 4, (kelime.Length - yazibasi.Length - 1));
                                        kelime = yazibasi + "-" + "(" + harf + ")" + yazisonu;

                                    }
                                    else
                                    {
                                        yazibasi = kelime.Remove(tireindex - 4);
                                        yazisonu = kelime.Substring(tireindex - 4, (kelime.Length - yazibasi.Length));
                                        kelime = yazibasi + "-" + yazisonu;

                                    }
                                    durum = true;
                                    Ekler.geciciEkle("2. ç.k. - EZ");
                                }
                            }
                        }
                    }
                    break;
                case 22:
                    if (tireindex - 3 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'n')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'y')
                            {
                                char harf = kelime[tireindex - 3];
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length - 1));
                                kelime = yazibasi + "-" + "(" + harf + ")" + yazisonu;

                            }
                            else
                            {
                                yazibasi = kelime.Remove(tireindex - 2);
                                yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;
                            }
                            durum = true;
                            Ekler.geciciEkle("2. t.k. - EZ");
                        }
                    }
                    break;
                case 23:
                    if (tireindex - 6 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'r')
                    {
                        if (kelime[tireindex - 2] == 'a' || kelime[tireindex - 2] == 'e')
                        {
                            if (kelime[tireindex - 3] == 'l')
                            {
                                if (kelime[tireindex - 4] == 'n')
                                {
                                    if (kelime[tireindex - 5] == 'u' || kelime[tireindex - 5] == 'i' || kelime[tireindex - 5] == 'ı' || kelime[tireindex - 5] == 'ü')
                                    {
                                        if (kelime[tireindex - 6] == 's')
                                        {
                                            yazibasi = kelime.Remove(tireindex - 6);
                                            yazisonu = kelime.Substring(tireindex - 6, (kelime.Length - yazibasi.Length));
                                            kelime = yazibasi + "-" + yazisonu;

                                            durum = true;
                                            Ekler.geciciEkle("3. ç.k. - EZ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 24:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'r')
                    {
                        if (kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'd' || kelime[tireindex - 3] == 't')
                            {
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                                durum = true;
                                Ekler.geciciEkle("bildirme eki - EZ");
                            }
                        }
                    }
                    break;
                case 25:
                    if (tireindex - 3 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'i' || kelime[tireindex - 1] == 'ı' || kelime[tireindex - 1] == 'u' || kelime[tireindex - 1] == 'ü')
                    {
                        if (kelime[tireindex - 2] == 'd' || kelime[tireindex - 2] == 't')
                        {

                            if (kelime[tireindex - 3] == 'y')
                            {
                                char harf = kelime[tireindex - 3];
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length - 1));
                                kelime = yazibasi + "-" + "(" + harf + ")" + yazisonu;

                            }
                            else
                            {
                                yazibasi = kelime.Remove(tireindex - 2);
                                yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                            }
                            durum = true;
                            Ekler.geciciEkle("hikaye b.z. - EZ");
                        }
                    }
                    break;
                case 26:
                    if (tireindex - 3 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 's')
                        {

                            if (kelime[tireindex - 3] == 'y')
                            {
                                char harf = kelime[tireindex - 3];
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length - 1));
                                kelime = yazibasi + "-" + "(" + harf + ")" + yazisonu;

                            }
                            else
                            {
                                yazibasi = kelime.Remove(tireindex - 2);
                                yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                            }
                            durum = true;
                            Ekler.geciciEkle("şart b.z. - EZ");
                        }
                    }
                    break;
                case 27:
                    if (tireindex - 4 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'ş')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'm')
                            {

                                if (kelime[tireindex - 4] == 'y')
                                {
                                    char harf = kelime[tireindex - 4];
                                    yazibasi = kelime.Remove(tireindex - 4);
                                    yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length - 1));
                                    kelime = yazibasi + "-" + "(" + harf + ")" + yazisonu;

                                }
                                else
                                {
                                    yazibasi = kelime.Remove(tireindex - 3);
                                    yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                    kelime = yazibasi + "-" + yazisonu;

                                }
                                durum = true;
                                Ekler.geciciEkle("rivayet b.z. - EZ");
                            }
                        }
                    }
                    break;
                case 28:
                    if (tireindex - 6 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 'n')
                        {
                            if (kelime[tireindex - 3] == 'i' || kelime[tireindex - 3] == 'ı')
                            {
                                if (kelime[tireindex - 4] == 's')
                                {
                                    if (kelime[tireindex - 5] == 'a' || kelime[tireindex - 5] == 'e')
                                    {
                                        if (kelime[tireindex - 6] == 'c')
                                        {
                                            yazibasi = kelime.Remove(tireindex - 6);
                                            yazisonu = kelime.Substring(tireindex - 6, (kelime.Length - yazibasi.Length));
                                            kelime = yazibasi + "-" + yazisonu;

                                            durum = true;
                                            Ekler.geciciEkle("tarz zarfı - EZ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 29:
                    if (tireindex - 4 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'n')
                    {
                        if (kelime[tireindex - 2] == 'e')
                        {
                            if (kelime[tireindex - 3] == 'k')
                            {
                                if (kelime[tireindex - 4] == 'y')
                                {
                                    char harf = kelime[tireindex - 4];
                                    yazibasi = kelime.Remove(tireindex - 4);
                                    yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length - 1));
                                    kelime = yazibasi + "-" + "(" + harf + ")" + yazisonu;

                                }
                                else
                                {
                                    yazibasi = kelime.Remove(tireindex - 3);
                                    yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                    kelime = yazibasi + "-" + yazisonu;
                                }
                                durum = true;
                                Ekler.geciciEkle("zaman zarfı - EZ");
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            return kelime;
        }
    }
}