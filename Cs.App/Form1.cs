using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cs.Lib;
using Cs.Lib.Abstracts;
using Cs.Lib.Concrete;

namespace Cs.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer seriTimer = new Timer();
        private Silah seciliSilah;
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSilahlar.Items.AddRange(Enum.GetNames(typeof(Silahlar)));
            seriTimer.Tick += seriTimer_Tick;
        }

        private void seriTimer_Tick(object sender, EventArgs e)
        {
            btnAtesEt.PerformClick();
        }

        private void cmbSilahlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSilahlar.SelectedIndex < 0) return;
            
            Silahlar silah = (Silahlar)Enum.Parse(typeof(Silahlar), cmbSilahlar.SelectedItem.ToString());
            //silah.ToString(); //string silah adını verir

            //Silahlar silahb = (Silahlar)cmbSilahlar.SelectedIndex;
            //byte deger = (byte)silah; // Enum ın integer değerini verir

            switch (silah)
            {
                case Silahlar.Bıçak:
                    seciliSilah = new Bicak();
                    break;
                case Silahlar.USP:
                    seciliSilah = new USP();
                    break;
                case Silahlar.Glock:
                    seciliSilah = new Glock();
                    break;
                case Silahlar.DesertEagle:
                    seciliSilah = new DesertDeagle();
                    break;
                case Silahlar.AK47:
                    seciliSilah = new AK47();
                    break;
                case Silahlar.M4A1S:
                    seciliSilah = new M4A1S();
                    break;
                case Silahlar.AWP:
                    seciliSilah = new AWP();
                    break;
                case Silahlar.ElBombası:
                    seciliSilah = new ElBombasi();
                    break;
                case Silahlar.FlashBombası:
                    seciliSilah = new FlashBombasi();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            panelSilah.Controls.Clear();
            panelSilah.Controls.Add(seciliSilah.SilahResmi);
            seciliSilah.SilahResmi.Dock = DockStyle.Fill;

            SilahBilgisiGöster(seciliSilah);

            gbAtesliSilah.Visible = seciliSilah is IAtesEdebilen;
            gbYakinSaldiri.Visible = seciliSilah is IVurulabilir;
            gbFirlatilan.Visible = seciliSilah is IFirlatilabilen;
        }

        private void SilahBilgisiGöster(Silah silah)
        {
            lblDetay.Text = $"ülke {seciliSilah.Ulke}\nfiyat {seciliSilah.Fiyat:c2}";
            if (silah is ISarjorlu sarjorSilah)
            {
                lblDurum.Text = $"{sarjorSilah.KalanFisek}/{sarjorSilah.SarjorKapasitesi}";
            }
        }

        private void btnAtesEt_Click(object sender, EventArgs e)
        {
            btnAtesEt.Enabled = false;
            (seciliSilah as IAtesEdebilen).AtesEt();
            SilahBilgisiGöster(seciliSilah);
            btnAtesEt.Enabled = true;
        }

        private void btnYenidenDoldur_Click(object sender, EventArgs e)
        {
            btnYenidenDoldur.Enabled = false;
            (seciliSilah as ISarjorlu).YenidenDoldur();
            SilahBilgisiGöster(seciliSilah);
            btnYenidenDoldur.Enabled = true;
        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            btnSaldir.Enabled = false;
            (seciliSilah as IVurulabilir).Vur();
            SilahBilgisiGöster(seciliSilah);
            btnSaldir.Enabled = true;
        }

        private void btnFirlat_Click(object sender, EventArgs e)
        {
            btnFirlat.Enabled = false;
            (seciliSilah as IFirlatilabilen).Firlat();
            SilahBilgisiGöster(seciliSilah);
            btnFirlat.Enabled = true;
        }

        private void btnAtesEt_MouseDown(object sender, MouseEventArgs e)
        {
            if (seciliSilah is ISeriAtabilir seriSilah)
            {
                seriTimer.Interval = seriSilah.AtisKatSayisi;
                seriTimer.Start();
            }
        }

        private void btnAtesEt_MouseUp(object sender, MouseEventArgs e)
        {
            if (seciliSilah is ISeriAtabilir)
            {
                seriTimer.Stop();
            }

        }
    }
}
