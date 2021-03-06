﻿using Cs.Lib.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public class FlashBombasi : Firlatilan
    {

        public FlashBombasi()
        {
            this.Fiyat = 200;
            this.Ulke = "Almanya";
            this.SilahResmi.Image = Properties.Resources.Flash;
            this.Hasar = 0;
        }
        public override int Firlat()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Flashbang);
            soundPlayer.Play();
            Thread.Sleep(500);
            return Hasar;
        }
    }
}
