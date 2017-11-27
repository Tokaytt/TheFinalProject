using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeDeneme
{
    class KontrolIsımCekim
    {
        Boolean durum = false;
        int tireindex;
        int lokasyon = 1;
        int kelimeindex;

        public string[] KontrolIC(string[] kelimedizisi)
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
                    yol = 14;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 13;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 2;
                        goto case 2;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
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
                        lokasyon = 5;
                        goto case 5;
                    }
                    yol = 17;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 5;
                        goto case 5;
                    }
                    yol = 18;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 4;
                        goto case 4;
                    }
                    yol = 19;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 11;
                        goto case 11;
                    }
                    yol = 16;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 3;
                        goto case 3;
                    }
                    yol = 15;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 7;
                        goto case 7;
                    }
                    yol = 8;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 2;
                        goto case 2;
                    }

                    yol = 1;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 10;
                        goto case 10;
                    }
                    yol = 2;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 3;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 4;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 5;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 9;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 3;
                        goto case 3;
                    }


                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 9;
                        goto case 9;
                    }
                    yol = 11;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 2;
                        goto case 2;
                    }

                    goto default;
                case 2:
                    yol = 1;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 10;
                        goto case 10;
                    }
                    yol = 5;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 3;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 4;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 2;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    goto default;
                case 3:
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 9;
                        goto case 9;
                    }
                    goto default;
                case 4:
                    yol = 14;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 6;
                        goto case 6;
                    }
                    yol = 13;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 2;
                        goto case 2;
                    }
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 5;
                        goto case 5;
                    }

                    goto default;
                case 5:

                    yol = 3;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 5;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 4;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 2;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 9;
                        goto case 9;
                    }
                    yol = 1;
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
                        lokasyon = 4;
                        goto case 4;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    goto default;
                case 6:
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 9;
                        goto case 9;
                    }
                    yol = 18;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 4;
                        goto case 4;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    goto default;
                case 7:
                    yol = 18;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 4;
                        goto case 4;
                    }
                    yol = 3;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 5;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 1;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 10;
                        goto case 10;
                    }
                    yol = 2;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 4;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    goto default;
                case 8:
                    yol = 1;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 10;
                        goto case 10;
                    }
                    goto default;
                case 9:
                    goto default;
                case 10:
                    yol = 18;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 4;
                        goto case 4;
                    }
                    goto default;
                case 11:
                    yol = 1;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 10;
                        goto case 10;
                    }
                    yol = 3;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 5;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 7;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 9;
                        goto case 9;
                    }
                    yol = 2;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 4;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
                    }
                    yol = 6;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 8;
                        goto case 8;
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
                                Ekler.geciciEkle( "çoğul - İÇ");
                            }
                        }
                    }
                    break;

                case 2:
                    if (tireindex - 2 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'm')
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
                        Ekler.geciciEkle( "1. t.k - İÇ");
                    }
                    break;
                case 3:
                    if (tireindex - 4 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'z')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'm')
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
                                Ekler.geciciEkle( "1. ç.k - İÇ");
                            }
                        }
                    }
                    break;
                case 4:
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
                        Ekler.geciciEkle( "2. t.k - İÇ");
                    }
                    break;
                case 5:
                    if (tireindex - 4 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'z')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'n')
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
                                Ekler.geciciEkle( "2. ç.k - İÇ");
                            }
                        }
                    }
                    break;
                case 6:
                    if (tireindex - 2 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'i' || kelime[tireindex - 1] == 'ı' || kelime[tireindex - 1] == 'u' || kelime[tireindex - 1] == 'ü')
                    {
                        if (kelime[tireindex - 2] == 's')
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
                        Ekler.geciciEkle( "3. t.k - İÇ");
                    }
                    break;
                case 7:
                    if (tireindex - 4 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'i' || kelime[tireindex - 1] == 'ı')
                    {
                        if (kelime[tireindex - 2] == 'r')
                        {
                            if (kelime[tireindex - 3] == 'a' || kelime[tireindex - 3] == 'e')
                            {
                                if (kelime[tireindex - 4] == 'l')
                                {

                                    yazibasi = kelime.Remove(tireindex - 4);
                                    yazisonu = kelime.Substring(tireindex - 4, (kelime.Length - yazibasi.Length));
                                    kelime = yazibasi + "-" + yazisonu;

                                    durum = true;
                                    Ekler.geciciEkle( "1. ç.k - İÇ");
                                }
                            }

                        }
                    }
                    break;
                case 8:
                    if (tireindex - 2 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'i' || kelime[tireindex - 1] == 'ı' || kelime[tireindex - 1] == 'u' || kelime[tireindex - 1] == 'ü')
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
                        Ekler.geciciEkle( "-i hali - İÇ");
                    }
                    break;

                case 9:
                    if (tireindex - 2 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'i' || kelime[tireindex - 1] == 'ı' || kelime[tireindex - 1] == 'u' || kelime[tireindex - 1] == 'ü')
                    {
                        if (kelime[tireindex - 2] == 'n')
                        {

                            yazibasi = kelime.Remove(tireindex - 2);
                            yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                            kelime = yazibasi + "-" + yazisonu;

                            durum = true;
                            Ekler.geciciEkle( "-i hali - İÇ");
                        }
                    }
                    break;
                case 10:
                    if (tireindex - 3 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'n')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'n')
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
                            Ekler.geciciEkle( "tamlama - İÇ");
                        }
                    }
                    break;


                case 11:
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
                        Ekler.geciciEkle( "-e hali - İÇ");
                    }
                    break;

                case 12:
                    if (tireindex - 2 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 'n')
                        {

                            yazibasi = kelime.Remove(tireindex - 2);
                            yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                            kelime = yazibasi + "-" + yazisonu;

                            durum = true;
                            Ekler.geciciEkle( "-e hali - İÇ");
                        }
                    }
                    break;
                case 13:
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
                            Ekler.geciciEkle( "-de hali - İÇ");
                        }
                    }
                    break;
                case 14:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 'd' || kelime[tireindex - 2] == 't')
                        {
                            if (kelime[tireindex - 3] == 'n')
                            {
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                                durum = true;
                                Ekler.geciciEkle( "-de hali - İÇ");
                            }
                        }
                    }
                    break;
                case 15:
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
                                Ekler.geciciEkle( "-den hali - İÇ");
                            }
                        }
                    }
                    break;
                case 16:
                    if (tireindex - 3 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'n')
                    {
                        if (kelime[tireindex - 2] == 'a' || kelime[tireindex - 2] == 'e')
                        {
                            if (kelime[tireindex - 3] == 'd' || kelime[tireindex - 3] == 't')
                            {
                                if (kelime[tireindex - 4] == 'n')
                                {
                                    yazibasi = kelime.Remove(tireindex - 4);
                                    yazisonu = kelime.Substring(tireindex - 4, (kelime.Length - yazibasi.Length));
                                    kelime = yazibasi + "-" + yazisonu;

                                    durum = true;
                                    Ekler.geciciEkle( "-den hali - İÇ");
                                }
                            }
                        }
                    }
                    break;
                case 17:
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
                            Ekler.geciciEkle( "birliktelik - İÇ");
                        }
                    }
                    break;

                case 18:
                    if (tireindex - 2 < 2)
                        goto default;
                    if (kelime[tireindex - 1] == 'i')
                    {
                        if (kelime[tireindex - 2] == 'k')
                        {

                            yazibasi = kelime.Remove(tireindex - 2);
                            yazisonu = kelime.Substring(tireindex - 2, (kelime.Length - yazibasi.Length));
                            kelime = yazibasi + "-" + yazisonu;

                            durum = true;
                            Ekler.geciciEkle( "ilgi - İÇ");
                        }
                    }
                    break;
                case 19:
                    if (tireindex - 3 < 2)
                        goto default;


                    if (kelime[tireindex - 1] == 'a' || kelime[tireindex - 1] == 'e')
                    {
                        if (kelime[tireindex - 2] == 'c')
                        {
                            if (kelime[tireindex - 3] == 'n')
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
                            Ekler.geciciEkle( "görelik - İÇ");
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

