using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakSavarOyunu.Lib
{
    public class Roket : OyunBase, IHareketEdebilir
    {
        public Roket(Point point,ContainerControl container):base(container)
        {
            Resim = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(28, 36),
                Image = Properties.Resources.mermi,
                Location = point 
            };
            container.Controls.Add(Resim);
        }
        public void HareketEt(Yonler yon)
        {
            if (yon == Yonler.Yukari)
            {
                Resim.Location = new Point()
                {
                    X = Resim.Location.X,
                    Y = Resim.Location.Y - 5
                };
            }
            else
                throw new Exception("roket sadece yukari hareket edebilir");
        }
    }
}
