using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XmlJsonServislerineBaglanma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Doviz> dovizler;
        private FourFactory fourFactory;
        private int sayac=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            var doviz = dovizler[sayac++ % dovizler.Count];
            lblKod.Text = $"{doviz.Birim} {doviz.Ad}-{doviz.Kod}";
            lblDeger.Text = $"Alis: {doviz.Alis:c4}\nSatis: {doviz.Satis:c4}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fourFactory = new FourFactory();
                dovizler = DovizFactory.Dovizler;
                //listBox1.Items.AddRange(dovizler.ToArray());
                listBox1.DataSource = dovizler;
                //listBox1.DisplayMember = "Ad";     ezmek yerine kullanılabilir ama tek satır yazılır
                //listBox1.ValueMember = "Satis";
                timer1.Start();
                
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Doviz seciliDoviz = listBox1.SelectedItem as Doviz;
            this.Text = $"{seciliDoviz.Birim} {seciliDoviz.Ad} - {seciliDoviz.Kod} Alis: {seciliDoviz.Alis} Satis: {seciliDoviz.Satis}";
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            
            var liste = fourFactory.Firmalar;
            lstFirmalar.DataSource = liste.OrderBy(x=>x.name).ToList(); //order by ile a dan z ye sıraladık
            lstFirmalar.DisplayMember = "name";
        }
    }
}
