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

namespace BinarySerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bufferSize = 64;
        byte[] resimArray = new byte[64];
        MemoryStream memoryStream = new MemoryStream();
        private void btnAc_Click(object sender, EventArgs e)
        {
            dosyaAc.Title = "bir resim dosyası seçiniz";
            dosyaAc.Filter = "Resim Dosyaları | *.jpg;*.png";
            dosyaAc.FileName = string.Empty;
            dosyaAc.Multiselect = false;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //opendialog açıldığında default desktop açılır
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Open(dosyaAc.FileName,FileMode.Open);
                while (dosya.Read(resimArray, 0, bufferSize) != 0)
                {
                    memoryStream.Write(resimArray, 0, resimArray.Length);
                }
                dosya.Close(); 
                dosya.Dispose(); //rami temizler
                pbResim.Image = new Bitmap(memoryStream);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (memoryStream.Length==0)
            {
                MessageBox.Show("ramda bir dosya bulunmamaktadır");
                return;
            }
            dosyaKaydet.Title = "bir resim dosyası seçiniz";
            dosyaKaydet.Filter = "*.jpg | *.jpg;*.png";
            dosyaKaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dosyaKaydet.FileName = string.Empty;
            if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Create(dosyaKaydet.FileName);
                memoryStream.Seek(0,SeekOrigin.Begin);
                while (memoryStream.Read(resimArray, 0, bufferSize) != 0)
                {
                    dosya.Write(resimArray, 0, resimArray.Length);
                }
                dosya.Close();
                dosya.Dispose(); //rami temizler
            }
        }
    }
}
