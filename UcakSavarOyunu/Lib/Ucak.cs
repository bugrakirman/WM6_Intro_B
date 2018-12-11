using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakSavarOyunu.Lib
{
    public class Ucak : OyunBase, IHareketEdebilir
    {
        public Ucak(Point point,ContainerControl contianer) : base(contianer)
        {
            Resim = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(52, 44),
                Image = Properties.Resources.ucak,
                Location = point
            };
            contianer.Controls.Add(Resim);
        }

        public void HareketEt(Yonler yon)
        {
            if (yon == Yonler.Asagi)
            {
                Resim.Location = new Point()
                {
                    X = Resim.Location.X,
                    Y = Resim.Location.Y + 5
                };
            }
            else
                throw new Exception("ucak sadece asagi hareket edebilir");
        }
    }
}
