using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometri.Lib;

namespace Geometri.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kare kare = new Kare();
            kare.X = 5;
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.X = 3;
            dikdortgen.Y = 4;
            DikUcgen DikUcgen = new DikUcgen();
            DikUcgen.X = 5;
            DikUcgen.Y = 12;
            //MessageBox.Show($"ucgen alanı: {DikUcgen.AlanHesapla()}");
            //MessageBox.Show($"ucgen cevresi: {DikUcgen.CevreHesapla()}");
            //MessageBox.Show($"hipotenüs: {DikUcgen.KosegenHesapla()}");

            //Sekil sekil = new Sekil(); //şekil abstract olduğu için sadece kalıtım yapılıor ulaşılamıyor
            //sekil.X = 10;
            //MessageBox.Show($"sekil alan: {sekil.AlanHesapla()}");
        }
    }
}
