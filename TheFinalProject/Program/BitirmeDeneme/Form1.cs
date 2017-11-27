using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitirmeDeneme
{
    public partial class Form1 : Form
    {
        string yazi;

        public Form1()
        {
            InitializeComponent();
        }

        public void Calistir()
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yazdir.text = "";
            Ekler.eklistesi = new string[4999, 30];
            yazi = richTextBox1.Text;
            yazi = yazi.ToLower();
            KelimelereCevir kc = new KelimelereCevir();
            string[] kelimeler = kc.KelimeAyir(yazi);
            string[] orjinal = kc.KelimeAyir(yazi);

            Ekler ekdosyası = new Ekler();

            KontrolEkEylem EkEylem = new KontrolEkEylem();
            kelimeler = EkEylem.KontrolEE(kelimeler);

            KontrolIsımCekim IsimCekim = new KontrolIsımCekim();
            kelimeler = IsimCekim.KontrolIC(kelimeler);

            KontrolEylemCekim EylemCekim = new KontrolEylemCekim();
            kelimeler = EylemCekim.KontrolEC(kelimeler);

            KontrolEylemZaman EylemZaman = new KontrolEylemZaman();
            kelimeler = EylemZaman.KontrolEZ(kelimeler);



            Yazdir Yazdırma = new Yazdir();
            Yazdırma.Yaz(kelimeler, orjinal);

            richTextBox2.Text = Yazdir.text;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
