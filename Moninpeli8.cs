using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Muistipeli
{
    public partial class frmMoninpeli8 : Form  //HUOM HUOM! Koska frmMoninpeli8 on lähes identtinen verrattuna frmMoninpeli:n, tarkempi kommentointi löytyy Moninpeli.cs:stä
    {
        bool annaklikata2 = false;
        PictureBox ekaarvaus;
        Random rnd = new Random();
        Timer kliktimer = new Timer();  //ajastin estää kuvien kääntämisen liian nopeasti, toimii kun kaksi korttia on käännetty ja ne ovat eripariset
        
        bool vuoro = true;  //true: pelaaja1 vuoro, false: pelaaja2 vuoro
        int P1laskuri = 0;
        int P2laskuri = 0;
        private static readonly Stopwatch watch = new Stopwatch();  //pelikello, josta voi seurata, kuinka kauan peli on kestänyt

        public frmMoninpeli8()
        {
            InitializeComponent();
            lblPisteetP1.Text = 0.ToString();
            pnlPisteet.Visible = false;
            UpdateTime();
        }

        private void UpdateTime()
        {
            lblTimer2.Text = GetTimeString(watch.Elapsed);
        }

        private string GetTimeString(TimeSpan elapsed)
        {
            string result = string.Empty;
            result = string.Format("{0:00}:{1:00}:{2:00}", elapsed.Hours, elapsed.Minutes, elapsed.Seconds);
            return result;
        }
        
        private void taimeri_Tick(object sender, EventArgs e)
        {
            UpdateTime();
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
                    //Properties.Resources.img5,
                    //Properties.Resources.img6,
                    //Properties.Resources.img7,
                    //Properties.Resources.img8,
                };
            }
        }
        
        private void aloitaPeliAika()  //käynnistää pelikellon
        {
            watch.Start();
            taimeri.Enabled = true;
        }
        
        /*
        private void ResetKuvat()
        {
            foreach (var kuv in kuvaboksit)
            {
                kuv.Tag = null;
                kuv.Visible = true;
            }

            PiilotaKuvat();
            LaitaRndKuvat();
            aika = 60;
            ajastin.Start();
        }
        */
        private void PiilotaKuvat()  //Peittää kuvat niiden "kääntöpuolella" pelikorttien tyyliin
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

        private void LaitaRndKuvat()  //Sijottaa kuvat satunnaisesti paikoilleen
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
            annaklikata2 = true;
            kliktimer.Stop();
        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!annaklikata2) return;
            var kuv = (PictureBox)sender;


            if (ekaarvaus == null)
            {
                ekaarvaus = kuv;
                kuv.Image = (Image)kuv.Tag;

                //if (!annaklikata) return;
                return;

            }
            kuv.Image = (Image)kuv.Tag;
            if (kuv.Image == ekaarvaus.Image && kuv != ekaarvaus)
            {

                kuv.Visible = ekaarvaus.Visible = false;
                {
                    ekaarvaus = kuv;
                    if (vuoro == true)
                    {
                        P1laskuri++;
                        lblPisteetP1.Text = P1laskuri.ToString();
                    }
                    else
                    {
                        P2laskuri++;
                        lblPisteetP2.Text = P2laskuri.ToString();
                    }

                }
                PiilotaKuvat();
            }
            else
            {
                annaklikata2 = false;
                kliktimer.Start();
                if (vuoro == true)
                {
                    vuoro = false;
                }
                else if (vuoro == false)
                {
                    vuoro = true;
                }
            }
            ekaarvaus = null;
            if (vuoro == true)
            {
                lblKenenVuoro.Text = tbPelaaja1.Text + " vuoro";
            }
            else
            {
                lblKenenVuoro.Text = tbPelaaja2.Text + " vuoro";
            }
            if (kuvaboksit.Any(p => p.Visible)) return;
            {
                watch.Stop();
                taimeri.Enabled = false;
                ValitseVoittaja();
            }

        }

        private void startGame(object sender, EventArgs e)
        {
            lblP1Pisteet.Text = tbPelaaja1.Text;  //Muuta pistelistan pelaajanimet
            lblP2Pisteet.Text = tbPelaaja2.Text;  //syötetyiksi pelaajanimiksi
            pnlPisteet.Visible = true;
            annaklikata2 = true;
            LaitaRndKuvat();
            PiilotaKuvat();
            aloitaPeliAika();
            pnlPelaajatiedot.Visible = false;
            pnlPelaajatiedot.Enabled = false;
            kliktimer.Interval = 750;
            kliktimer.Tick += kliktimertick;
            btnAloitaMp.Enabled = false;

            int kenenvuoro = rnd.Next(1, 4);
            if (kenenvuoro < 3)
            {
                vuoro = true;
            }
            else if (kenenvuoro > 2)
            {
                vuoro = false;
            }

            
            if (vuoro == true)
            {
                lblKenenVuoro.Text = tbPelaaja1.Text + " vuoro";
            }
            else
            {
                lblKenenVuoro.Text = tbPelaaja2.Text + " vuoro";
            }
            lblKenenVuoro.Visible = true;
        }

        private void btnPoistuYksPel_Click(object sender, EventArgs e)
        {
            if (pnlVoitit2.Enabled == true)
            {
                MessageBoxButtons mb = MessageBoxButtons.YesNo;
                DialogResult dr;
                dr = MessageBox.Show("Et ole tallentanut pelituloksia, haluatko poistua tallentamatta?", "Poistu tallentamatta?", mb);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
            }
            this.Close();
            watch.Stop();
            taimeri.Enabled = false;
            watch.Reset();
        }

        private void ValitseVoittaja() //Valitsee voittajan, kun kaikki korttiparit on löydetty, näyttää "onnittelukortin"
        {
            pnlVoitit2.Visible = true;
            pnlVoitit2.Enabled = true;
            if (P1laskuri > P2laskuri)
            {
                lblVoittaja.Text = "Voittaja: " + tbPelaaja1.Text;
            }
            else if (P2laskuri > P1laskuri)
            {
                lblVoittaja.Text = "Voittaja: " + tbPelaaja2.Text;
            }
            else
            {
                lblVoittaja.Text = "Tasapeli!";
            }
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Tulokset " + DateTime.Today.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString();  // asettaa päivämäärän tulostiedoston oletusnimeksi
            savefile.Filter = "Text files (*.txt)|*.txt";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                {
                    sw.WriteLine("Moninpeli: 8 korttia");
                    sw.WriteLine("Pelaaja 1: " + tbPelaaja1.Text + " pisteet: " + lblPisteetP1.Text);
                    sw.WriteLine("Pelaaja 2: " + tbPelaaja2.Text + " pisteet: " + lblPisteetP2.Text);
                    sw.Write("Pelin kesto: " + lblTimer2.Text);
                }
            }

            this.Close();
            watch.Stop();
            taimeri.Enabled = false;
            watch.Reset();
        }

        public string errorMsgPitka = "Liian pitkä nimi!";
        public string errorMsgTyhja = "Ei voi olla tyhjä!";
        public string errorMsgSama = "Ei voi olla sama nimi!";
        private void tbPelaaja1_Validating(object sender, CancelEventArgs e)
        {
            if (tbPelaaja1.Text.Length > 12)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(tbPelaaja1, errorMsgPitka);
            }
            if (tbPelaaja1.Text.Length < 1)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(tbPelaaja1, errorMsgTyhja);
            }
            if (tbPelaaja1.Text == tbPelaaja2.Text)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(tbPelaaja1, errorMsgSama);
            }
        }

        private void tbPelaaja1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbPelaaja1, "");
        }

        private void tbPelaaja2_Validating(object sender, CancelEventArgs e)
        {
            if (tbPelaaja2.Text.Length > 12)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(tbPelaaja2, errorMsgPitka);
            }
            if (tbPelaaja2.Text.Length < 1)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(tbPelaaja2, errorMsgTyhja);
            }
            if (tbPelaaja2.Text == tbPelaaja1.Text)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(tbPelaaja2, errorMsgSama);
            }
        }

        private void tbPelaaja2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbPelaaja2, "");
        }

    }
}
