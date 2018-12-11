using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakSavarOyunu.Lib
{
    public abstract class OyunBase
    {
        public PictureBox Resim { get; set; } = new PictureBox();
        public ContainerControl Container { get; set; }

        protected ContainerControl contianer;
        public OyunBase(ContainerControl contianer)
        {
            this.contianer = contianer;
            this.Container = contianer;
        }
    }
}
