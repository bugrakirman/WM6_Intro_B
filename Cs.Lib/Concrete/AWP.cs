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
    public class AWP : Tufek
    {
        public AWP()
        {
            this._atisKatSayisi = 1500;
            this.Fiyat = 4750;
            this.Ulke = "İngiltere";
            this._sarjorKapasitesi = 20;
            this._kalanFisek = this._sarjorKapasitesi;
            this.SilahResmi.Image = Properties.Resources.AWP;
            this.Hasar = 120;
        }
        public override int AtesEt()
        {
            SoundPlayer soundPlayer;
            if (KalanFisek != 0)
            {
                soundPlayer = new SoundPlayer(Properties.Resources.AWP_Ates);
                soundPlayer.Play();
                Thread.Sleep(_atisKatSayisi);
                this._kalanFisek--;
            }
            else
            {
                soundPlayer = new SoundPlayer(Properties.Resources.Bitik_Mermi_Sesi);
                soundPlayer.Play();
                Thread.Sleep(100);
            }
            return this._kalanFisek;
        }
        public override int YenidenDoldur()
        {
            new SoundPlayer(Properties.Resources.M4A1_Reload).Play();
            Thread.Sleep(1250);
            this._kalanFisek = this._sarjorKapasitesi;
            return _kalanFisek;
        }
    }
}
