using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeDeneme
{
    class KontrolEylemCekim
    {
        Boolean durum = false;
        int tireindex;
        int lokasyon = 1;
        int kelimeindex;

        public string[] KontrolEC(string[] kelimedizisi)
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
            lokasyon = lokasyonBul(kelime);
            string sonsaglam = kelime;
            int yol = 0;

            tireindex = indexbul(kelime);
            switch (lokasyon)
            {
                case 1:
                    yol = 38;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "zarf eki - EÇ");

                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 39;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "zarf eki - EÇ");
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
                        Ekler.geciciEkle( "3. ç.k. - EÇ");
                        lokasyon = 2;
                        goto case 2;
                    }
                    yol = 5;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "2. ç.k. - EÇ");
                        lokasyon = 2;
                        goto case 2;
                    }
                    yol = 4;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "1. ç.k. - EÇ");
                        lokasyon = 2;
                        goto case 2;
                    }
                    yol = 2;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "2. t.k. - EÇ");
                        lokasyon = 2;
                        goto case 2;
                    }
                    yol = 19;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "zarf eki - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    yol = 20;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "zarf eki - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    yol = 21;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "zarf eki - EÇ");
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
                        Ekler.geciciEkle( "zarf eki - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;

                    }
                    yol = 23;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "zarf eki - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    yol = 25;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "zarf eki - EÇ");
                        lokasyon = 5;
                        goto case 5;
                    }
                    yol = 24;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "zarf eki - EÇ");
                        lokasyon = 4;
                        goto case 4;
                    }
                    yol = 3;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "3. t.k. - EÇ");
                        lokasyon = 2;
                        goto case 2;
                    }
                    yol = 1;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "1. t.k. - EÇ");
                        lokasyon = 2;
                        goto case 2;
                    }
                    goto default;
                case 2:
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "2. t.k. - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 7;
                        goto case 7;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "olumsuzluk - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 7;
                        goto case 7;
                    }
                    goto default;
                case 3:
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "olumsuzluk - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 7;
                        goto case 7;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "olumsuzluk - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 7;
                        goto case 7;
                    }

                    yol = 14;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "yaklaşma bileşik - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 7;
                        goto case 7;
                    }
                    yol = 15;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "sürerlik bileşik - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 7;
                        goto case 7;
                    }
                    yol = 16;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "sürerlik bileşik - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 7;
                        goto case 7;
                    }
                    yol = 13;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "yeterlik bileşik - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 9;
                        goto case 9;
                    }
                    yol = 9;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "sürerlik bileşik - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "tezlik bileşik - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 11;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "sürerlik bileşik - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "sürerlik bileşik - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 43;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "oldurgan - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 44;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "ettirgen - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 12;
                        goto case 12;
                    }
                    yol = 41;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "işteş - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 14;
                        goto case 14;
                    }
                    yol = 42;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "edilgen dönüşlü - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 11;
                        goto case 11;
                    }
                    yol = 40;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "edilgen dönüşlü - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 10;
                        goto case 10;
                    }
                    goto default;
                case 4:
                    yol = 22;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "zarf eki - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    goto default;
                case 5:
                    yol = 23;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "zarf eki - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    goto default;
                case 6:
                    yol = 22;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "zarf eki - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    yol = 41;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "işteş - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 14;
                        goto case 14;
                    }
                    goto default;
                case 7:
                    yol = 42;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "edilgen dönüşlü - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 11;
                        goto case 11;
                    }
                    yol = 44;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "ettirgen - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 12;
                        goto case 12;
                    }
                    yol = 41;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "işteş - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 14;
                        goto case 14;
                    }
                    yol = 43;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "oldurgan - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 40;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "edilgen dönüşlü - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 10;
                        goto case 10;
                    }
                    goto default;
                case 8:
                    yol = 42;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "edilgen dönüşlü - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 11;
                        goto case 11;
                    }
                    yol = 44;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "ettirgen - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 12;
                        goto case 12;
                    }
                    yol = 41;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "işteş - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 14;
                        goto case 14;
                    }
                    yol = 43;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "oldurgan - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 40;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "edilgen dönüşlü - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 10;
                        goto case 10;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "olumsuzluk - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 7;
                        goto case 7;
                    }
                    goto default;
                case 9:
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "olumsuzluk - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 7;
                        goto case 7;
                    }
                    yol = 44;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "ettirgen - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 12;
                        goto case 12;
                    }
                    yol = 40;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "edilgen dönüşlü - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 10;
                        goto case 10;
                    }
                    yol = 42;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "edilgen dönüşlü - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 11;
                        goto case 11;
                    }
                    yol = 41;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "işteş - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 14;
                        goto case 14;
                    }
                    yol = 43;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "oldurgan - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    goto default;
                case 10:
                    yol = 44;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "ettirgen - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 12;
                        goto case 12;
                    }
                    yol = 42;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "edilgen dönüşlü - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 11;
                        goto case 11;
                    }
                    yol = 40;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "edilgen dönüşlü - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 14;
                        goto case 14;
                    }
                    yol = 41;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "işteş - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 14;
                        goto case 14;
                    }
                    yol = 43;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "oldurgan - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    goto default;
                case 11:
                    yol = 43;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "oldurgan - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 40;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "edilgen dönüşlü - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 14;
                        goto case 14;
                    }
                    yol = 41;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "işteş - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 14;
                        goto case 14;
                    }
                    yol = 44;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "ettirgen - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 12;
                        goto case 12;
                    }
                    goto default;
                case 12:
                    yol = 43;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "oldurgan - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    goto default;
                case 13:
                    yol = 40;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "edilgen dönüşlü - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 14;
                        goto case 14;
                    }
                    yol = 41;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "işteş - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 14;
                        goto case 14;
                    }
                    goto default;
                case 14:
                    goto default;
                case 15:
                    yol = 3;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "3. t.k. - EÇ");
                        lokasyon = 2;
                        goto case 2;
                    }
                    goto default;
                case 16:
                    yol = 18;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "görev - EÇ");
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
                        Ekler.geciciEkle( "sıfat fiil - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    yol = 27;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "fiileden isim - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    yol = 28;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "sıfat fiil - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    yol = 29;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "sıfat fiil - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    yol = 30;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "sıfat fiil - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    yol = 31;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "fiilden isim - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    yol = 32;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "mastar - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    yol = 33;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "fiilden isim - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    goto default;
                case 17:
                    yol = 17;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "mastar - EÇ");
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    goto default;
                case 18:
                    yol = 34;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "-den hali - EÇ");
                        lokasyon = 17;
                        goto case 17;
                    }
                    yol = 35;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle("-de hali - EÇ");
                        lokasyon = 17;
                        goto case 17;
                    }
                    yol = 36;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "birliktelik - EÇ");
                        lokasyon = 17;
                        goto case 17;
                    }
                    yol = 37;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.geciciEkle( "-e hali - EÇ");
                        lokasyon = 17;
                        goto case 17;
                    }
                    goto default;
                default:
                    break;
            }
            return sonsaglam;
        }

        private int lokasyonBul(string kelime)
        {
            kelime = dene(3, kelime);
            if (durum == true)
                return 15;
            kelime = dene(18, kelime);
            if (durum == true)
                return 16;
            kelime = dene(26, kelime);
            if (durum == true)
                return 16;
            kelime = dene(27, kelime);
            if (durum == true)
                return 16;
            kelime = dene(28, kelime);
            if (durum == true)
                return 16;
            kelime = dene(29, kelime);
            if (durum == true)
                return 16;
            kelime = dene(30, kelime);
            if (durum == true)
                return 16;
            kelime = dene(31, kelime);
            if (durum == true)
                return 16;
            kelime = dene(32, kelime);
            if (durum == true)
                return 16;
            kelime = dene(33, kelime);
            if (durum == true)
                return 16;
            kelime = dene(34, kelime);
            if (durum == true)
                return 18;
            kelime = dene(35, kelime);
            if (durum == true)
                return 18;
            kelime = dene(36, kelime);
            if (durum == true)
                return 18;
            kelime = dene(37, kelime);
            if (durum == true)
                return 18;
            kelime = dene(17, kelime);
            if (durum == true)
                return 17;
            kelime = dene(41, kelime);
            if (durum == true)
                return 3;
            kelime = dene(42, kelime);
            if (durum == true)
                return 3;
            kelime = dene(40, kelime);
            if (durum == true)
                return 3;
            kelime = dene(7, kelime);
            if (durum == true)
                return 3;
            kelime = dene(8, kelime);
            if (durum == true)
                return 3;
            kelime = dene(14, kelime);
            if (durum == true)
                return 3;
            kelime = dene(15, kelime);
            if (durum == true)
                return 3;
            kelime = dene(16, kelime);
            if (durum == true)
                return 3;
            kelime = dene(13, kelime);
            if (durum == true)
                return 3;
            kelime = dene(9, kelime);
            if (durum == true)
                return 3;
            kelime = dene(10, kelime);
            if (durum == true)
                return 3;
            kelime = dene(11, kelime);
            if (durum == true)
                return 3;
            kelime = dene(12, kelime);
            if (durum == true)
                return 3;


            return 1;
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
                    if (tireindex - 1 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'm')
                    {
                        yazibasi = kelime.Remove(tireindex - 1);
                        yazisonu = kelime.Substring(tireindex - 1, (kelime.Length - yazibasi.Length));
                        kelime = yazibasi + "-" + yazisonu;

                        durum = true;
                    }
                    break;
                case 2:
                    if (tireindex - 4 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'n')
                    {
                        if (kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'i')
                        {
                            if (kelime[tireindex - 3] == 's')
                            {
                                if (kelime[tireindex - 4] == 'z')
                                {

                                    yazibasi = kelime.Remove(tireindex - 4);
                                    yazisonu = kelime.Substring(tireindex - 4, (kelime.Length - yazibasi.Length));
                                    kelime = yazibasi + "-" + yazisonu;

                                    durum = true;
                                }
                            }
                        }
                    }
                    break;
                case 3:
                    if (tireindex - 1 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'z')
                    {
                        yazibasi = kelime.Remove(tireindex - 1);
                        yazisonu = kelime.Substring(tireindex - 1, (kelime.Length - yazibasi.Length));
                        kelime = yazibasi + "-" + yazisonu;

                        durum = true;
                    }
                    break;
                case 4:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'z')
                    {
                        if (kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'i')
                        {
                            if (kelime[tireindex - 3] == 'y')
                            {


                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                                durum = true;
                            }
                        }
                    }
                    break;
                case 5:
                    if (tireindex - 6 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'z')
                    {
                        if (kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'i')
                        {
                            if (kelime[tireindex - 3] == 'n')
                            {
                                if (kelime[tireindex - 4] == 'ı' || kelime[tireindex - 4] == 'i')
                                {
                                    if (kelime[tireindex - 5] == 's')
                                    {
                                        if (kelime[tireindex - 6] == 'z')
                                        {

                                            yazibasi = kelime.Remove(tireindex - 6);
                                            yazisonu = kelime.Substring(tireindex - 6, (kelime.Length - yazibasi.Length));
                                            kelime = yazibasi + "-" + yazisonu;

                                            durum = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 6:
                    if (tireindex - 4 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'r')
                    {
                        if (kelime[tireindex - 2] == 'a' || kelime[tireindex - 2] == 'e')
                        {
                            if (kelime[tireindex - 3] == 'l')
                            {
                                if (kelime[tireindex - 4] == 'z')
                                {

                                    yazibasi = kelime.Remove(tireindex - 4);
                                    yazisonu = kelime.Substring(tireindex - 4, (kelime.Length - yazibasi.Length));
                                    kelime = yazibasi + "-" + yazisonu;

                                    durum = true;
                                }
                            }
                        }
                    }
                    break;
                case 7:
                    if (tireindex - 2 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 'm')
                        {

                            yazibasi = kelime.Remove(tireindex - 2);
                            yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                            kelime = yazibasi + "-" + yazisonu;

                            durum = true;
                        }
                    }
                    break;
                case 8:
                    if (tireindex - 4 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'e' || kelime[tireindex - 1] == 'a')
                    {
                        if (kelime[tireindex - 2] == 'm')
                        {
                            if (kelime[tireindex - 3] == 'e' || kelime[tireindex - 3] == 'a')
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
                            }
                        }
                    }
                    break;
                case 9:
                    if (tireindex - 5 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'r')
                    {
                        if (kelime[tireindex - 2] == 'u')
                        {
                            if (kelime[tireindex - 3] == 'd')
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
                                }
                            }
                        }
                    }
                    break;
                case 10:
                    if (tireindex - 5 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'r')
                    {
                        if (kelime[tireindex - 2] == 'e')
                        {
                            if (kelime[tireindex - 3] == 'v')
                            {
                                if (kelime[tireindex - 4] == 'ı' || kelime[tireindex - 4] == 'i' || kelime[tireindex - 4] == 'u' || kelime[tireindex - 4] == 'ü')
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
                                }
                            }
                        }
                    }
                    break;
                case 11:
                    if (tireindex - 5 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'l')
                    {
                        if (kelime[tireindex - 2] == 'e')
                        {
                            if (kelime[tireindex - 3] == 'g')
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
                                }
                            }
                        }
                    }
                    break;
                case 12:
                    if (tireindex - 5 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'r')
                    {
                        if (kelime[tireindex - 2] == 'ö')
                        {
                            if (kelime[tireindex - 3] == 'g')
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
                                }
                            }
                        }
                    }
                    break;
                case 13:
                    if (tireindex - 5 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'l')
                    {
                        if (kelime[tireindex - 2] == 'i')
                        {
                            if (kelime[tireindex - 3] == 'b')
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
                                }
                            }
                        }
                    }
                    break;
                case 14:
                    if (tireindex - 5 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'z')
                    {
                        if (kelime[tireindex - 2] == 'a')
                        {
                            if (kelime[tireindex - 3] == 'y')
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
                                }
                            }
                        }
                    }
                    break;
                case 15:
                    if (tireindex - 5 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'l')
                    {
                        if (kelime[tireindex - 2] == 'a')
                        {
                            if (kelime[tireindex - 3] == 'k')
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
                                }
                            }
                        }
                    }
                    break;
                case 16:
                    if (tireindex - 5 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'y')
                    {
                        if (kelime[tireindex - 2] == 'o')
                        {
                            if (kelime[tireindex - 3] == 'k')
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
                                }
                            }
                        }
                    }
                    break;
                case 17:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'k')
                    {
                        if (kelime[tireindex - 2] == 'a' || kelime[tireindex - 2] == 'e')
                        {
                            if (kelime[tireindex - 3] == 'm')
                            {
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                                durum = true;
                            }
                        }
                    }
                    break;
                case 18:
                    if (tireindex - 4 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'ı' || kelime[tireindex - 1] == 'i' || kelime[tireindex - 1] == 'u' || kelime[tireindex - 1] == 'ü')
                    {
                        if (kelime[tireindex - 2] == 'c')
                        {
                            if (kelime[tireindex - 3] == 'ı' || kelime[tireindex - 3] == 'i' || kelime[tireindex - 3] == 'u' || kelime[tireindex - 3] == 'ü')
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
                            }
                        }
                    }
                    break;
                case 19:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'p')
                    {
                        if (kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
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
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                            }
                            durum = true;
                        }
                    }
                    break;
                case 20:
                    if (tireindex - 4 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'ı' || kelime[tireindex - 1] == 'i')
                    {
                        if (kelime[tireindex - 2] == 'l')
                        {
                            if (kelime[tireindex - 3] == 'a' || kelime[tireindex - 3] == 'e')
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
                            }
                        }
                    }
                    break;
                case 21:
                    if (tireindex - 5 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 'ç')
                        {
                            if (kelime[tireindex - 3] == 'k')
                            {
                                if (kelime[tireindex - 4] == 'i' || kelime[tireindex - 4] == 'ı' || kelime[tireindex - 4] == 'u' || kelime[tireindex - 4] == 'ü')
                                {
                                    if (kelime[tireindex - 5] == 'd' || kelime[tireindex - 5] == 't')
                                    {
                                        yazibasi = kelime.Remove(tireindex - 5);
                                        yazisonu = kelime.Substring(tireindex - 5, (kelime.Length - yazibasi.Length));
                                        kelime = yazibasi + "-" + yazisonu;

                                        durum = true;
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 22:
                    if (tireindex - 5 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'k')
                    {
                        if (kelime[tireindex - 2] == 'a' || kelime[tireindex - 2] == 'e')
                        {
                            if (kelime[tireindex - 3] == 'r')
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
                                }
                            }
                        }
                    }
                    break;
                case 23:
                    if (tireindex - 5 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 'c')
                        {
                            if (kelime[tireindex - 3] == 'n')
                            {
                                if (kelime[tireindex - 4] == 'ı' || kelime[tireindex - 4] == 'i' || kelime[tireindex - 4] == 'u' || kelime[tireindex - 4] == 'ü')
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
                                }
                            }
                        }
                    }
                    break;
                case 24:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'n')
                    {
                        if (kelime[tireindex - 2] == 'a' || kelime[tireindex - 2] == 'e')
                        {
                            if (kelime[tireindex - 3] == 'd' || kelime[tireindex - 3] == 't')
                            {
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                                durum = true;
                            }
                        }
                    }
                    break;
                case 25:
                    if (tireindex - 2 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 'y')
                        {
                            yazibasi = kelime.Remove(tireindex - 2);
                            yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                            kelime = yazibasi + "-" + yazisonu;

                            durum = true;

                        }
                    }
                    break;

                case 26:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'n')
                    {
                        if (kelime[tireindex - 2] == 'a' || kelime[tireindex - 2] == 'e')
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
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                            }
                            durum = true;
                        }
                    }
                    break;
                case 27:
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
                                }
                            }
                        }
                    }
                    break;
                case 28:
                    if (tireindex - 4 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'ı' || kelime[tireindex - 1] == 'i')
                    {
                        if (kelime[tireindex - 2] == 's')
                        {
                            if (kelime[tireindex - 3] == 'a' || kelime[tireindex - 3] == 'e')
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
                            }
                        }
                    }
                    break;
                case 29:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'k')
                    {
                        if (kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'd' || kelime[tireindex - 3] == 't')
                            {
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                                durum = true;
                            }
                        }
                    }
                    break;
                case 30:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'ş')
                    {
                        if (kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'm')
                            {
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                                durum = true;
                            }
                        }
                    }
                    break;
                case 31:
                    if (tireindex - 6 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'k')
                    {
                        if (kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'i')
                        {
                            if (kelime[tireindex - 3] == 'l')
                            {
                                if (kelime[tireindex - 4] == 'z')
                                {
                                    if (kelime[tireindex - 5] == 'a' || kelime[tireindex - 5] == 'e')
                                    {
                                        if (kelime[tireindex - 6] == 'm')
                                        {

                                            yazibasi = kelime.Remove(tireindex - 6);
                                            yazisonu = kelime.Substring(tireindex - 6, (kelime.Length - yazibasi.Length));
                                            kelime = yazibasi + "-" + yazisonu;

                                            durum = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 32:
                    if (tireindex - 2 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 'm')
                        {

                            yazibasi = kelime.Remove(tireindex - 2);
                            yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                            kelime = yazibasi + "-" + yazisonu;

                            durum = true;
                        }
                    }
                    break;
                case 33:
                    if (tireindex - 3 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'ş')
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
                        }
                    }
                    break;
                case 34:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'n')
                    {
                        if (kelime[tireindex - 2] == 'a' || kelime[tireindex - 2] == 'e')
                        {
                            if (kelime[tireindex - 3] == 'd' || kelime[tireindex - 3] == 't')
                            {
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                                durum = true;
                            }
                        }
                    }
                    break;
                case 35:
                    if (tireindex - 2 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 'd' || kelime[tireindex - 2] == 't')
                        {
                            yazibasi = kelime.Remove(tireindex - 2);
                            yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                            kelime = yazibasi + "-" + yazisonu;

                            durum = true;
                        }
                    }
                    break;
                case 36:
                    if (tireindex - 3 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 'l')
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
                        }
                    }
                    break;
                case 37:
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
                    }
                    break;
                case 38:
                    if (tireindex - 8 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'n')
                    {
                        if (kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'i')
                        {
                            if (kelime[tireindex - 3] == 'z')
                            {
                                if (kelime[tireindex - 4] == 'ı' || kelime[tireindex - 5] == 'i')
                                {
                                    if (kelime[tireindex - 5] == 's')
                                    {
                                        if (kelime[tireindex - 6] == 'k')
                                        {
                                            if (kelime[tireindex - 7] == 'a' || kelime[tireindex - 7] == 'e')
                                            {
                                                if (kelime[tireindex - 8] == 'm')
                                                {


                                                    yazibasi = kelime.Remove(tireindex - 8);
                                                    yazisonu = kelime.Substring(tireindex - 8, (kelime.Length - yazibasi.Length));
                                                    kelime = yazibasi + "-" + yazisonu;

                                                    durum = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 39:
                    if (tireindex - 5 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'n')
                    {
                        if (kelime[tireindex - 2] == 'a' || kelime[tireindex - 2] == 'e')
                        {
                            if (kelime[tireindex - 3] == 'd')
                            {
                                if (kelime[tireindex - 4] == 'a' || kelime[tireindex - 5] == 'e')
                                {
                                    if (kelime[tireindex - 5] == 'm')
                                    {


                                        yazibasi = kelime.Remove(tireindex - 5);
                                        yazisonu = kelime.Substring(tireindex - 5, (kelime.Length - yazibasi.Length));
                                        kelime = yazibasi + "-" + yazisonu;

                                        durum = true;

                                    }
                                }
                            }
                        }
                    }
                    break;
                case 40:
                    if (tireindex - 2 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'n')
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
                    }
                    break;
                case 41:
                    if (tireindex - 2 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'ş')
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
                    }
                    break;
                case 42:
                    if (tireindex - 2 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'l')
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
                    }
                    break;
                case 43:
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
                            }
                        }
                    }
                    break;
                case 44:
                    if (tireindex - 2 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 't')
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
                    }
                    break;
                default:
                    break;
            }
            return kelime;
        }
    }
}
