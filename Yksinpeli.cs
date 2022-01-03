using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muistipeli
{
    public partial class frmYksinpeli : Form
    {
        bool annaklikata = false;
        PictureBox ekaarvaus;
        Random rnd = new Random();
        Timer kliktimer = new Timer();
        int aika = 60;
        Timer ajastin = new Timer { Interval = 1000 };
        

        public frmYksinpeli()
        {
            InitializeComponent();
        }

        private PictureBox[] kuvaboksit
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }
        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.img1,
                    Properties.Resources.img2,
                    Properties.Resources.img3,
                    Properties.Resources.img4,
                    Properties.Resources.img5,
                    Properties.Resources.img6,
                    Properties.Resources.img7,
                    Properties.Resources.img8,
                };
            }
        }
        private void aloitaPeliAika()
        {
            ajastin.Start();
            ajastin.Tick += delegate
            {
                aika--;
                if (aika <= 0)
                {
                    
                    ajastin.Stop();

                    pnlHavisitPelin.Location = new Point(681, 365);
                    pnlHavisitPelin.Enabled = true;
                    pnlHavisitPelin.Visible = true;
                    
                    
                }
                var ssTime = TimeSpan.FromSeconds(aika);
                lblTime.Text = "00:" + aika.ToString();
            };
        }
        
        
        
        private void PiilotaKuvat()
        {
            foreach (var kuv in kuvaboksit)
            {
                kuv.Image = Properties.Resources.question;
            }
        }

        private PictureBox getVapaa()
        {
            int num;
            do
            {
                num = rnd.Next(0, kuvaboksit.Count());
            }
            while (kuvaboksit[num].Tag != null);
            return kuvaboksit[num];
        }
        private void LaitaRndKuvat()
        {
            foreach (var kuva in images)
            {
                getVapaa().Tag = kuva;
                getVapaa().Tag = kuva;
            }
        }
        private void kliktimertick(object sender, EventArgs e)
        {
            PiilotaKuvat();
            annaklikata = true;
            kliktimer.Stop();
        }
        

        private void clickImage(object sender, EventArgs e)
        {
            if (!annaklikata) return;
            var kuv = (PictureBox)sender;

            if (ekaarvaus == null)
            {
                ekaarvaus = kuv;
                kuv.Image = (Image)kuv.Tag;
                return;
            }
            kuv.Image = (Image)kuv.Tag;
            if (kuv.Image == ekaarvaus.Image && kuv != ekaarvaus)
            {
                kuv.Visible = ekaarvaus.Visible = false;
                {
                    ekaarvaus = kuv;
                }
                PiilotaKuvat();
            }
            else
            {
                annaklikata = false;
                kliktimer.Start();
            }
            ekaarvaus = null;
            if (kuvaboksit.Any(p => p.Visible)) return;
            ajastin.Stop();
            
            pnlVoitit.Visible = true;
            pnlVoitit.Enabled = true;
            
        }

        private void startGame(object sender, EventArgs e)
        {
            annaklikata = true;
            LaitaRndKuvat();
            PiilotaKuvat();
            aloitaPeliAika();
            kliktimer.Interval = 750;
            kliktimer.Tick += kliktimertick;
            btnAloita.Enabled = false;
        }

        private void btnPoistuYksPel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
