﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Cs.Lib.Abstracts
{
    public abstract class Silah
    {
        public string Ulke { get; protected set; }

        public decimal Fiyat { get; protected set; }

        public int Hasar { get; protected set; }

        public PictureBox SilahResmi { get; protected set; } = new PictureBox();

        protected Silah()
        {
            SilahResmi.Size = new Size(500, 400);
            SilahResmi.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        
    }
    public enum Silahlar: Byte
    {
        Bıçak,
        USP,
        Glock,
        DesertEagle,
        AK47,
        M4A1S,
        AWP,
        ElBombası,
        FlashBombası
    }
}
