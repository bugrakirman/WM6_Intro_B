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
    public class Bicak : YakinSaldiri
    {
        private SoundPlayer soundPlayer;

        public Bicak()
        {
            this.Fiyat = 50;
            this.Ulke = "Turkiye";
            this.SilahResmi.Image = Properties.Resources.Bicak;
            this.Hasar = 45;
            this._vurusKatsayisi = 350;
            soundPlayer = new SoundPlayer(Properties.Resources.Bicak_Cikarma);
            soundPlayer.Play();
        }

        public override int Vur()
        {
            soundPlayer = new SoundPlayer(Properties.Resources.Bicak_Saplama);
            soundPlayer.Play();
            Thread.Sleep(500);
            return Hasar;
        }
    }
}
