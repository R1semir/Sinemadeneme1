using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1 = 0;
        int seans2 = 0;
        int seans3 = 0;
        int seans3ucret = 0;
        int seans2ucret = 0;
        int seans1ucret = 0;
        int misiradet = 0;
        int misirfiyat = 0;
        int kolaadet = 0;
        int kolafiyat = 0;
        int suadet = 0;
        int sufiyat = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            seans1++;
            seans1ucret = seans1ucret + 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1ucret.ToString();
            if (seans1 == 10)
            {
                button1.Enabled = false;
            }

            if (seans1 > 0)
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seans1--;
            seans1ucret = seans1ucret - 8;
            textBox1.Text = seans1.ToString();
            textBox2.Text = seans1ucret.ToString();
            if (seans1 == 0)
            {
                button2.Enabled = false;
            }
            if (seans1 < 10)
            {
                button1.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            seans2++;
            seans2ucret = seans2ucret + 8;
            textBox4.Text = seans2.ToString();
            textBox3.Text = seans2ucret.ToString();
            if (seans2 == 10)
            {
                button4.Enabled = false;
            }
            if (seans2 > 0)
            {
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seans2--;
            seans2ucret = seans2ucret - 8;
            textBox4.Text = seans2.ToString();
            textBox3.Text = seans2ucret.ToString();
            if(seans2 == 0)
            {
                button3.Enabled = false;
            }
            if (seans2 < 1)
            {
                button4.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btneksi.Enabled = true;
            seans3++;
            seans3ucret = seans3ucret + 8;
            textBox6.Text = seans3.ToString();
            textBox5.Text = seans3ucret.ToString();
            if (seans3 == 10)
            {
                btnartı.Enabled = false;
            }
            if (seans3 > 0)
            {
                btneksi.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seans3--;
            seans3ucret = seans3ucret - 8;
            textBox6.Text = seans3.ToString();
            textBox5.Text = seans3ucret.ToString();
            if (seans3 == 0)
            {
                btnartı.Enabled = true;
            }
            if (seans3 <=0)
            {
                btneksi.Enabled = false;
            }
        }

        private void btnMısır_Click(object sender, EventArgs e)
        {
            misiradet++;
            misirfiyat = misirfiyat + 3;
            textBox7.Text = misiradet.ToString();
            textBox8.Text = misirfiyat.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            misiradet--;
            misirfiyat = misirfiyat - 3;
            textBox7.Text = misiradet.ToString();
            textBox8.Text = misirfiyat.ToString();
        }

        private void btnKola_Click(object sender, EventArgs e)
        {
            kolaadet++;
            kolafiyat = kolafiyat + 2;
            textBox10.Text = kolaadet.ToString();
            textBox9.Text = kolafiyat.ToString();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            kolaadet--;
           kolafiyat = kolafiyat - 2;
            textBox10.Text = kolaadet.ToString();
            textBox9.Text = kolafiyat.ToString();
        }

        private void btnSu_Click(object sender, EventArgs e)
        {
            suadet++;
            sufiyat = sufiyat + 1;
            textBox12.Text = suadet.ToString();
            textBox11.Text = sufiyat.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            suadet--;
            sufiyat = sufiyat - 1;
            textBox12.Text = suadet.ToString();
            textBox11.Text = sufiyat.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int toplamizleyicisayisi, toplamucret;
            toplamizleyicisayisi = seans1 + seans2 + seans3;
            lblizleyici.Text = toplamizleyicisayisi.ToString();

            toplamucret = seans1ucret + seans2ucret + seans3ucret;
            label15.Text = toplamucret.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            btneksi.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int toplamsatilan, toplamfiyat;
            toplamsatilan = misiradet + suadet + kolaadet;
            toplamfiyat = misirfiyat + sufiyat + kolafiyat;

            label19.Text = toplamsatilan.ToString();
            label17.Text = toplamfiyat.ToString();
        }
    }
}
