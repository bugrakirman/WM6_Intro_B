using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soyut.Lib;

namespace Soyut.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Sekil> sekiller = new List<Sekil>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //object initializer--> dikdortgen orneginde space e basınca yazman gerekeni gösteriyor tüm property leri
            //sırayla listeliyor // hiyerarşi olarak constructordan sonra çalışır
            Kare kare = new Kare();
            kare.X = 10;
            MessageBox.Show($"karenin alanı: {kare.AlanHesapla()}");
            Dikdortgen dikdortgen = new Dikdortgen()
            {
                X =5,
                Y =12
            };
            MessageBox.Show($"dikdortgenin kosegeni: {dikdortgen.KosegenHesapla()}");

            sekiller.Add(kare);
            sekiller.Add(dikdortgen);
            // polymorphism
            // bir nesne üzerinden bir sürü nesneyi toplayabildik 
            // birden fazla farklı şeklin kalıtımla ortak classında tutulabilmesini sağlar.
            // kareye özel bir metod olsaydı if yazıp is demek zorundaydık !
            // SOLID prensipleri
            Sekil dikdortgen2 = new Dikdortgen()
            {
                X = 3,
                Y = 4
            };

            Sekil kare2 = new Kare()
            {
                X = 5
            };

            foreach (Sekil sekil in sekiller)
            {
                //if (sekil is Kare kk)
                //{
                //    MessageBox.Show($"şekil alanı: {kk.AlanHesapla()}");
                //}
                //else if (sekil is Dikdortgen dd)
                //{
                //    MessageBox.Show($"şekil alanı: {dd.AlanHesapla()}");
                //}
                MessageBox.Show($"seklin alanı: {sekil.AlanHesapla()}");
            }
        }
    }
}
