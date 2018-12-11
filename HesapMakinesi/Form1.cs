using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitMyComponents();
            txtEkran.Text = "0";
        }

        private double sayi = 0, ekran = 0;
        private char islem = '0';
        

        private void InitMyComponents()
        {
            // eventleri oluştur
            btn0.Click += BtnSayi_Click;
            btn1.Click += BtnSayi_Click;
            btn2.Click += BtnSayi_Click;
            btn3.Click += BtnSayi_Click;
            btn4.Click += BtnSayi_Click;
            btn5.Click += BtnSayi_Click;
            btn6.Click += BtnSayi_Click;
            btn7.Click += BtnSayi_Click;
            btn8.Click += BtnSayi_Click;
            btn9.Click += BtnSayi_Click;

            btnEsittir.Click += BtnIslem_Click;
            btnTopla.Click += BtnIslem_Click;
            btnCıkart.Click += BtnIslem_Click;
            btnCarp.Click += BtnIslem_Click;
            btnBol.Click += BtnIslem_Click;
        }

        private void BtnIslem_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            sayi = ekran;
            ekran = 0;
            islem = Convert.ToChar(btn.Text);
            
            if (islem == '0')
            {
                sayi = ekran;
                ekran = 0;
                txtEkran.Text = "0";
            }
            else if (islem == '+')
            {
                sayi += ekran;
                ekran = 0;
                txtEkran.Text = sayi.ToString();
            }
            else if (islem == '-')
            {
                sayi -= ekran;
                ekran = 0;
                txtEkran.Text = sayi.ToString();
            }
            else if (islem == '/')
            {
                sayi /= ekran;
                ekran = 0;
                txtEkran.Text = sayi.ToString();
            }
            else if(islem == 'x')
            {
                sayi *= ekran;
                ekran = 0;
                txtEkran.Text = sayi.ToString();
            }
            else if(islem == '=')
            {
                txtEkran.Text = sayi.ToString();
            }
            islem = Convert.ToChar(btn.Text);
        }

        private void BtnSayi_Click(object sender, EventArgs e)
        {
            // Button btn = sender as Button;  ya da 
            Button btn = (Button)sender;
            string birlestirme = ekran + btn.Text;
            ekran = double.Parse(birlestirme);
            txtEkran.Text = ekran.ToString();

        }
    }
}
