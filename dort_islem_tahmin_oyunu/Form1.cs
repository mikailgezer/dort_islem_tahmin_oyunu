using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dort_islem_tahmin_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int puan = 0 ;
        int sure = 100;

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            textBox1.Clear();
            timer1.Start();


            button1.Enabled = false;
            button2.Enabled = true;

            int sayi1, sayi2, islem;
            int sonuc ,a,b;

            sayi1 = rastgele.Next(0, 51);
            sayi2 = rastgele.Next(0, 51);
            islem = rastgele.Next(1, 5);


            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();

            //if (islem == 1)
            //{
            //    label3.Text = "+";
            //    sonuc = sayi1 + sayi2;
            //    label5.Text = sonuc.ToString();

            //a = Convert.ToInt32(label1);
            //b = Convert.ToInt32(label2);


            switch (islem)
            {
                case 1:
                    label3.Text = "+";
                    sonuc = sayi1 + sayi2;
                    label5.Text = sonuc.ToString();
                    break;
                case 2:
                    label3.Text = "-";
                    sonuc = sayi1 - sayi2;
                    label5.Text = sonuc.ToString();
                    break;
                case 3:
                    label3.Text = "*";
                    sonuc = sayi1 * sayi2;
                    label5.Text = sonuc.ToString();
                    break;
                case 4:
                    label3.Text = "/";
                    sonuc = sayi1 / sayi2;
                    label5.Text = sonuc.ToString();
                    break;
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            
            if (label5.Text == textBox1 .Text)
            {
                puan = puan + 10;
                label7.Text = puan.ToString();
            }
            else
            {
                puan = puan - 10;
                label7.Text = puan.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Text = sure.ToString();
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = sure - 1;
            label8.Text = sure.ToString();

            if(sure == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                timer1.Stop();
                button3.Visible = true;
                MessageBox.Show("Puanınız: " + puan.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Visible = false;
            sure = 100;
            puan = 0;
            label7.Text = puan.ToString();
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "?";
        }
    }
}
