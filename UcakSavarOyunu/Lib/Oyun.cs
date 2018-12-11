using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakSavarOyunu.Lib
{
    public class Oyun
    {
        private Timer tmr_Roket,tmr_Uretici,tmr_Ucak,tmr_Kontrol;
        private ContainerControl container;
        List<Ucak> Ucaklar = new List<Ucak>();
        public Oyun(ContainerControl container)
        {
            this.container = container;
            this.UcakSavar = new UcakSavar(container);
            tmr_Roket = new Timer()
            {
                Enabled = true,
                Interval = 5
            };
            tmr_Roket.Tick += tmr_Roket_Tick;
            tmr_Uretici = new Timer() {
                Enabled = true,
                Interval=1200
            };
            tmr_Uretici.Tick += tmr_Uretici_Tick;
            tmr_Ucak = new Timer()
            {
                Enabled = true,
                Interval = 120
            };
            tmr_Ucak.Tick += tmr_Ucak_Tick;
            tmr_Kontrol = new Timer() {
            Enabled=true,
            Interval=3
            };
            tmr_Kontrol.Tick += tmr_Kontrol_Tick;
        }
        public void Resized(ContainerControl container)
        {
            this.container = container;
            UcakSavar.Container = container;
            foreach (var ucak in Ucaklar)
            {
                ucak.Container = container;
            }
            foreach (Roket roket in UcakSavar.roketler)
            {
                roket.Container = container;
            }
        }
        private void tmr_Kontrol_Tick(object sender, EventArgs e)
        {
            foreach (Ucak ucak in Ucaklar)
            {
                Rectangle ru = new Rectangle();
                Rectangle rr = new Rectangle();
                
                if (ucak.Resim.Location.Y+ucak.Resim.Height>container.Height-70)
                {
                    tmr_Kontrol.Stop();
                    tmr_Ucak.Stop();
                    tmr_Uretici.Stop();
                    tmr_Roket.Stop();
                }

                ru.Location = ucak.Resim.Location;
                ru.Width = ucak.Resim.Width;
                ru.Height = ucak.Resim.Height;
                bool vurduMu = false;
                foreach (Roket roket in UcakSavar.roketler)
                {
                    rr.Location = roket.Resim.Location;
                    rr.Width = roket.Resim.Width;
                    rr.Height = roket.Resim.Height;

                    //if (ru.IntersectsWith(rr))
                    //{
                    //    vurduMu = true;
                    //    container.Controls.Remove(ucak.Resim);
                    //    container.Controls.Remove(roket.Resim);
                    //    UcakSavar.roketler.Remove(roket);
                    //    SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.bomb_small);
                    //    soundPlayer.Play();
                    //    break;
                    //}
                    if (roket.Resim.Bounds.IntersectsWith(ucak.Resim.Bounds))
                    {
                        vurduMu = true;
                        container.Controls.Remove(ucak.Resim);
                        container.Controls.Remove(roket.Resim);
                        UcakSavar.roketler.Remove(roket);
                        Ucaklar.Remove(ucak);
                        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.bomb_small);
                        soundPlayer.Play();
                        break;
                    }
                }
                if (vurduMu) break;
            }
            foreach (Roket roket in UcakSavar.roketler)
            {
                if (roket.Resim.Location.Y < 0)
                {
                    UcakSavar.roketler.Remove(roket);
                    this.container.Controls.Remove(roket.Resim);
                    break;
                }
            }
        }

        private void tmr_Ucak_Tick(object sender, EventArgs e)
        {
            foreach (IHareketEdebilir ucak in Ucaklar)
            {
                ucak.HareketEt(Yonler.Asagi);
            }
        }

        private void tmr_Roket_Tick(object sender, EventArgs e)
        {
            foreach (Roket roket in UcakSavar.roketler)
            {
                roket.HareketEt(Yonler.Yukari);
            }
            //veya
            //foreach (IHareketEdebilir hareket in UcakSavar.roketler)
            //{
            //    hareket.HareketEt(Yonler.Yukari);
            //}
        }
        Random rnd = new Random();
        private void tmr_Uretici_Tick(object sender, EventArgs e)
        {
            Point konum = new Point(rnd.Next(20,container.Width-70));
            Ucak ucak = new Ucak(konum,this.container);
            Ucaklar.Add(ucak);
        }

        public UcakSavar UcakSavar { get; set; }
    }
}
