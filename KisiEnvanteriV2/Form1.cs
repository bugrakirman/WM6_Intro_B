using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace KisiEnvanteriV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // tools --> package nuget manager --> package manager console // google : nuget
        // paketler silinirse restore nuget packages seçeneğine tıkla yeniden yüklesin
        List<Kisi> Kisiler = new List<Kisi>();
        List<Kisi> aramalar = new List<Kisi>();
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (lstKisiler.SelectedItem == null) return;
                Kisi seciliKisi = (Kisi)lstKisiler.SelectedItem;
                Kisiler.Remove(seciliKisi);
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
            if (seciliKisi.Fotograf!=null && seciliKisi.Fotograf.Length>0)
            {
                pictureBox1.Image = new Bitmap(new MemoryStream(seciliKisi.Fotograf));
            }
        }

        private void FormuTemizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name == "txtSearch")
                    {
                        continue;
                    }
                    control.Text = string.Empty;
                }
                else if (control is CheckBox)
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
                else if (control is PictureBox pbox)
                {
                    pbox.Image = null;
                }
            }
        }

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
                if (memoryStream.Length > 0)
                {
                    yeniKisi.Fotograf = memoryStream.ToArray();
                }
                memoryStream = new MemoryStream();

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

        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Bir XML dosyası seçiniz";
            dosyaKaydet.Filter = "(XML Dosyası) | *.xml";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = "Kisiler.xml"; // string.Empty;
            if (dosyaKaydet.ShowDialog()==DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Kisi>));
                TextWriter textWriter = new StreamWriter(dosyaKaydet.FileName);
                serializer.Serialize(textWriter, Kisiler);
                textWriter.Close();
                textWriter.Dispose();
                MessageBox.Show($"XML başarıyla aktarıldı {dosyaKaydet.FileName}");
            }
        }

        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir XML dosyası seçiniz";
            dosyaAc.Filter = "(XML Dosyası) | *.xml";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "Kisiler.xml"; // string.Empty;
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kisi>));
                XmlReader reader = new XmlTextReader(dosyaAc.FileName);
                if(xmlSerializer.CanDeserialize(reader))
                {
                    Kisiler = xmlSerializer.Deserialize(reader) as List<Kisi>;

                    MessageBox.Show($"{Kisiler.Count} kisi başarıyla aktarıldı");
                    lstKisiler.Items.AddRange(Kisiler.ToArray());
                }
            }
        }

        private void dışarıAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaKaydet.Title = "Bir JSON dosyası seçiniz";
            dosyaKaydet.Filter = "(JSON Dosyası) | *.json";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = "Kisiler.json"; // string.Empty;
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream file = File.Open(dosyaKaydet.FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject(Kisiler));
                writer.Close();
                writer.Dispose();
            }
        }

        private void içeriAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "Bir JSON dosyası seçiniz";
            dosyaAc.Filter = "(JSON Dosyası) | *.json";
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaAc.FileName = "Kisiler.json"; // string.Empty;
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream dosya = File.OpenRead(dosyaAc.FileName);
                    StreamReader reader = new StreamReader(dosya);
                    string dosyaIcerigi = reader.ReadToEnd();
                    reader.Close();
                    dosya.Close();
                    Kisiler = JsonConvert.DeserializeObject<List<Kisi>>(dosyaIcerigi);
                    //Kisiler = JsonConvert.DeserializeObject(dosyaIcerigi) as List > Kisi >;
                    //Kisiler = (list<Kisi>)JsonConvert.DeserializeObject(dosyaIcerigi);

                    MessageBox.Show($"{Kisiler.Count} kişi başarıyala aktarıldı");
                    lstKisiler.Items.Clear();
                    lstKisiler.Items.AddRange(Kisiler.ToArray());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("bir hata oluştu "+ex.Message);
                }
            }
        }
        MemoryStream memoryStream = new MemoryStream();
        int bufferSize = 64;
        byte[] resimArray = new byte[64];
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "bir foto seç";
            dosyaAc.Filter= "(JPG Dosyası) | *.jpg";
            dosyaAc.Multiselect = false;
            dosyaAc.FileName= string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaAc.ShowDialog()==DialogResult.OK)
            {
                FileStream dosya = File.OpenRead(dosyaAc.FileName);
                while (dosya.Read(resimArray,0,bufferSize)!=0)
                {
                    memoryStream.Write(resimArray, 0, resimArray.Length);
                }
                dosya.Close();
                dosya.Dispose();
                pictureBox1.Image = new Bitmap(memoryStream);
            }
        }
    }
}
