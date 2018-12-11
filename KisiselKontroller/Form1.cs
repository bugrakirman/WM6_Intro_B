using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiselKontroller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
             standart kalıpların olduğu ekranlardan birden fazla yerde kullanılması gerekiyorsa bu ekranlar UserControl olarak tasarlanıp istenilen yere toolbox üzerinden sürükle bırakla oluşturulabilir.
             */
        }

        
        private void btnOku_Click(object sender, EventArgs e)
        {

        }

        private void txtConverter1_SinirAsildi(string mesaj)
        {
            MessageBox.Show(mesaj);
        }
    }
}
