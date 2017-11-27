using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeDeneme
{

    class KontrolEkEylem
    {
        Boolean durum = false;
        int tireindex;
        int lokasyon = 2;
        int kelimeindex;

        public string[] KontrolEE(string[] kelimedizisi)
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
            lokasyon = 2;
            string sonsaglam = kelime;
            int yol = 0;

            tireindex = indexbul(kelime);

            switch (lokasyon)
            {
                case 17:
                    yol = 4;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 19;
                        goto case 19;
                    }
                    yol = 14;
                    kelime =dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 1;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 19;
                        goto case 19;
                    }
                    yol = 2;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 19;
                        goto case 19;
                    }
                    yol = 3;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 19;
                        goto case 19;
                    }
                    yol = 5;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 19;
                        goto case 19;
                    }
                    goto default;
                case 13:
                    goto default;
                case 3:
                    yol = 14;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
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
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 13;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 14;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    goto default;
                case 11:
                    yol = 4;
                    sonsaglam = kelime;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 19;
                        goto case 19;
                    }
                    yol = 14;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 1;
                    sonsaglam = kelime;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 19;
                        goto case 19;
                    }
                    yol = 2;
                    sonsaglam = kelime;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 19;
                        goto case 19;
                    }
                    yol = 3;
                    sonsaglam = kelime;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 19;
                        goto case 19;
                    }
                    
                    yol = 5;
                    sonsaglam = kelime;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 19;
                        goto case 19;
                    }
                    goto default;

                case 19:

                    yol = 14;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    goto default;
                case 7:
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 13;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    goto default;
                case 2:
                    yol = 15;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {

                        sonsaglam = kelime;
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 4;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    yol = 9;
                    sonsaglam = kelime;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 7;
                        goto case 7;
                    }
                    yol = 1;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
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
                    yol = 3;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 3;
                        goto case 3;
                    }
                    
                    yol = 5;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 5;
                        goto case 5;
                    }
                    yol = 6;
                    sonsaglam = kelime;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 7;
                        goto case 7;
                    }
                    yol = 7;
                    sonsaglam = kelime;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 7;
                        goto case 7;
                    }
                    yol = 8;
                    sonsaglam = kelime;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        lokasyon = 7;
                        goto case 7;
                    }
                    
                    yol = 10;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 11;
                        goto case 11;
                    }
                    yol = 11;
                    sonsaglam = kelime;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        lokasyon = 17;
                        goto case 17;
                    }
                    yol = 12;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 13;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
                    }
                    yol = 14;
                    kelime = dene(yol, kelime);
                    if (durum == true)
                    {
                        Ekler.Ekle(kelimeindex);
                        Ekler.geciciSil();
                        sonsaglam = kelime;
                        lokasyon = 13;
                        goto case 13;
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
                            Ekler.geciciEkle("1. t.k. - EE");
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
                                Ekler.geciciEkle("2. t.k. - EE");
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
                            Ekler.geciciEkle("1. ç.k. - EE");
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
                                        Ekler.geciciEkle( "2. ç.k. - EE");
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
                                Ekler.geciciEkle( "3. ç.k. - EE");
                            }
                        }
                    }
                    break;
                case 6:
                        if (tireindex - 1 < 2)
                            goto default;
                    
                    if (kelime[tireindex - 1] == 'm')
                    {
                        yazibasi = kelime.Remove(tireindex - 1);
                        yazisonu = kelime.Substring(tireindex - 1, (kelime.Length - yazibasi.Length));
                        kelime = yazibasi + "-" + yazisonu;

                        durum = true;
                        Ekler.geciciEkle( "1. t.k. - EE");
                    }
                    break;
                case 7:
                    if (tireindex - 1 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'n')
                    {
                        yazibasi = kelime.Remove(tireindex - 1);
                        yazisonu = kelime.Substring(tireindex - 1, (kelime.Length - yazibasi.Length));
                        kelime = yazibasi + "-" + yazisonu;

                        durum = true;
                        Ekler.geciciEkle( "2. t.k. - EE");
                    }
                    break;
                case 8:
                    if (tireindex - 1 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'k')
                    {
                        yazibasi = kelime.Remove(tireindex - 1);
                        yazisonu = kelime.Substring(tireindex - 1, (kelime.Length - yazibasi.Length));
                        kelime = yazibasi + "-" + yazisonu;

                        durum = true;
                        Ekler.geciciEkle("1. ç.k. - EE");
                    }
                    break;
                case 9:
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
                                Ekler.geciciEkle( "2. ç.k. - EE");
                            }
                        }
                    }
                    break;
                case 10:

                    if (tireindex - 3 < 2)
                        goto default;

                    if (kelime[tireindex - 1] == 'r')
                    {
                        if (kelime[tireindex - 2] == 'i' || kelime[tireindex - 2] == 'ı' || kelime[tireindex - 2] == 'u' || kelime[tireindex - 2] == 'ü')
                        {
                            if (kelime[tireindex - 3] == 'd' || kelime[tireindex - 3] == 't')
                            {
                                yazibasi = kelime.Remove(tireindex - 3);
                                yazisonu = kelime.Substring(tireindex - 3, (kelime.Length - yazibasi.Length));
                                kelime = yazibasi + "-" + yazisonu;

                                durum = true;
                                Ekler.geciciEkle( "bildirme eki - EE");
                            }
                        }
                    }
                    break;
                case 11:

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
                                            Ekler.geciciEkle( "tarz zarfı - EE");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case 12:

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
                            Ekler.geciciEkle("di'li g.z. - EE");
                        }
                    }
                    break;
                case 13:

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
                            Ekler.geciciEkle( "dilek-şart - EE");
                        }
                    }
                    break;
                case 14:

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
                                Ekler.geciciEkle( "miş'li g.z. - EE");
                            }
                        }
                    }
                    break;
                case 15:
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
                                Ekler.geciciEkle( "zaman zarfı - EE");
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