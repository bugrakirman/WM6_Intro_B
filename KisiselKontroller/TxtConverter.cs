using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselKontroller
{

    public delegate void SinirAsimiHandler(string mesaj); //delege
    public delegate void FalanHandler(object sender, EventArgs e);
    public partial class TxtConverter : UserControl
    {
        public TxtConverter()
        {
            InitializeComponent();
        }
        // property ekranında gözüküyor

        public event SinirAsimiHandler SinirAsildi; // delege tanımlıyoruz
        public event FalanHandler FalanOldu;
        
        public int Sayi { get; set; }
        public DateTime Tarih { get; set; }
        public bool  AktifMi { get; set; }
        public Color Renk { get; set; }

        public decimal Value { get => nuSayi.Value; set => nuSayi.Value = value; }

        public string ConvertedText => txtOkunus.Text; //sadece get var ise bu şekilde yazılabilir.
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //txtOkunus.Text=Convert.ToString( nuSayi.Value);
            //this.ParentForm.Text = txtOkunus.Text;
            //this.Sayi = Convert.ToInt32(txtOkunus.Text);
            //[] dizi = new string[4];
            //this.Sayi = Convert.ToInt32(nuSayi.Value.ToString());
            int sayi = Convert.ToInt32(nuSayi.Value);
            //txtOkunus.Text = TextTools.OkunusuGetir(Convert.ToInt32(nuSayi.Value));
            if (sayi < 0)
            {
                nuSayi.Value = 0;
                SinirAsildi?.Invoke("sayi 0 dan kucuk olamaz"); //?.Invoke null ise satırın çalışmamasını sağlıyor
                return;
            }
            else if (sayi>9999)
            {
                nuSayi.Value = 9999;
                FalanOldu?.Invoke(sender,e); // event oluşturup tetiklemeyi gösterdi sadece
                SinirAsildi?.Invoke("sayi 9999 dan buyuk olamaz");
                return;
            }

            txtOkunus.Text = sayi.OkunusuGetir();
        }
    }
}
