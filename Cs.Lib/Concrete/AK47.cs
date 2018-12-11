using Cs.Lib.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

namespace Cs.Lib.Concrete
{
    public class AK47 : Tufek
    {
        public AK47()
        {
            this._atisKatSayisi = 250;
            this.Fiyat = 2700;
            this.Ulke = "Rusya";
            this._sarjorKapasitesi = 30;
            this._kalanFisek = this._sarjorKapasitesi;
            this.SilahResmi.Image = Properties.Resources.Ak47;
            this.Hasar = 55;
        }
        public override int AtesEt()
        {
            SoundPlayer soundPlayer;
            if (KalanFisek != 0)
            {
                soundPlayer = new SoundPlayer(Properties.Resources.Ak47_Ates);
                soundPlayer.Play();
                Thread.Sleep(_atisKatSayisi);
                this._kalanFisek--;
            }
            else
            {
                soundPlayer = new SoundPlayer(Properties.Resources.Bitik_Mermi_Sesi);
                soundPlayer.Play();
                Thread.Sleep(250);
            }
            return this._kalanFisek;
        }

        public override int YenidenDoldur()
        {
            new SoundPlayer(Properties.Resources.Ak47_Reload).Play();
            Thread.Sleep(1200);
            this._kalanFisek = this._sarjorKapasitesi;
            return _kalanFisek;
        }
    }
}
