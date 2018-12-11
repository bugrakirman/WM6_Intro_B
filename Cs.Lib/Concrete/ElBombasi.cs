using Cs.Lib.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cs.Lib.Concrete
{
    public class ElBombasi : Firlatilan
    {
        private SoundPlayer soundPlayer;

        public ElBombasi()
        {
            this.Fiyat = 350;
            this.Ulke = "Turkiye";
            this.SilahResmi.Image = Properties.Resources.Bomba;
            this.Hasar = 80;
        }
        public override int Firlat()
        {
            soundPlayer = new SoundPlayer(Properties.Resources.Bomb);
            soundPlayer.Play();
            Thread.Sleep(500);
            return Hasar;
        }
    }
}
