using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringFonksiyonlarOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Kisi> Kisiler = new List<Kisi>();
        List<Kisi> aramalar = new List<Kisi>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi();
            try
            {
                yeniKisi.Ad = txtAd.Text;
                yeniKisi.Soyad = txtSoyad.Text;
                yeniKisi.Telefon = txtTel.Text;
                yeniKisi.Email = txtEmail.Text;
                yeniKisi.TCKN = txtTckn.Text;

                MessageBox.Show($"hosgeldin {yeniKisi.Ad} {yeniKisi.Soyad}");
                Kisiler.Add(yeniKisi);
                FormuTemizle();

                lstKisiler.Items.AddRange(Kisiler.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormuTemizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name=="txtSearch")
                    {
                        continue;
                    }
                    control.Text = string.Empty;
                }
                else if(control is CheckBox)
                {
                    (control as CheckBox).Checked = true;
                }
                else if (control is CheckBox)
                {
                    (control as CheckBox).Checked = false;
                }
                else if (control is ListBox lst)
                {
                    lst.Items.Clear();
                }
            }
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return; //listboc combobox gibi yapılarda her zaman yaz 
            Kisi seciliKisi = lstKisiler.SelectedItem as Kisi; 
            // ya da Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem ;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtTel.Text = seciliKisi.Telefon;
            txtEmail.Text = seciliKisi.Email;
            txtTckn.Text = seciliKisi.TCKN;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem;// referans tip değişkenler !

            try
            {
                seciliKisi.Ad = txtAd.Text;
                seciliKisi.Soyad = txtSoyad.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FormuTemizle();
            lstKisiler.Items.AddRange(Kisiler.ToArray());
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string ara = txtSearch.Text.ToLower();
            aramalar = new List<Kisi>();

            //foreach (Kisi kisi in Kisiler)
            //{
            //    if(kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara))
            //    {
            //        aramalar.Add(kisi);
            //    }
            //} ya da 

            Kisiler.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) 
            || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));

            FormuTemizle();
            lstKisiler.Items.AddRange(aramalar.ToArray());

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem;
            Kisiler.Remove(seciliKisi);
            FormuTemizle();
            lstKisiler.Items.AddRange(Kisiler.ToArray());
        }
        // CRUD operations --> create delete update işlemleri
    }
}
