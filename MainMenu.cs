using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Muistipeli
{
    public partial class frmMainMenu : Form
    {
        public SoundPlayer sp = new SoundPlayer(Muistipeli.Properties.Resources.FastCardsLoop2);
        

        public frmMainMenu()
        {
            InitializeComponent();
            try
            {
                sp.PlayLooping(); //VAROITUS KUULOKKEIDEN KÄYTTÄJÄT: varmista ettei äänenvoimakkuus ole liian lujalla! Kappale soi heti ohjelman käynnistyttyä.
            }
            catch
            {
                
            }
        }

        private void btnAvaaYksinpeli_Click(object sender, EventArgs e)  //käynnistää yksinpelin
        {
            pnlValitseKorttimaara.Enabled = false;
            pnlValitseKorttimaara.Visible = false;
            frmYksinpeli yp = new frmYksinpeli();
            yp.ShowDialog();
        }

        private void btnPoistupelista_Click(object sender, EventArgs e)  //sulkee ohjelman
        {
            Application.Exit();
        }

        private void btnAvaamoninpeli_Click(object sender, EventArgs e)  //avaa erillisen valikon, josta valitaan korttien määrä moninpeliin
        {
            pnlValitseKorttimaara.Enabled = true;
            pnlValitseKorttimaara.Visible = true;
        }

        private void btnvalitse8_Click(object sender, EventArgs e)  //avaa moninpelin, jossa 8 korttia
        {
            pnlValitseKorttimaara.Enabled = false;
            pnlValitseKorttimaara.Visible = false;
            frmMoninpeli8 mp = new frmMoninpeli8();
            mp.ShowDialog();
            
        }

        private void btnValitse12_Click(object sender, EventArgs e)
        {
            pnlValitseKorttimaara.Enabled = false;
            pnlValitseKorttimaara.Visible = false;
            frmMoninpeli12 mp = new frmMoninpeli12();
            mp.ShowDialog();
        }

        private void btnValitse16_Click(object sender, EventArgs e)  //avaa moninpelin, jossa 16 korttia
        {
            pnlValitseKorttimaara.Enabled = false;
            pnlValitseKorttimaara.Visible = false;
            frmMoninpeli mp = new frmMoninpeli();
            mp.ShowDialog();
            
        }

        private void frmMainMenu_Click(object sender, EventArgs e)  //jos moninpelin korttimäärän valikko on avattu, se menee piiloon formia klikatessa
        {
            pnlValitseKorttimaara.Enabled = false;
            pnlValitseKorttimaara.Visible = false;
        }

        private void pnlValikko_Click(object sender, EventArgs e)  //jos moninpelin korttimäärän valikko on avattu, se menee piiloon paneelia klikatessa
        {
            pnlValitseKorttimaara.Enabled = false;
            pnlValitseKorttimaara.Visible = false;
        }

        private void cBHiljennaTune_CheckedChanged(object sender, EventArgs e)  //mahdollistaa taustamusiikin hiljentämisen
        {
            if (cBHiljennaTune.Checked == true)
            {
                sp.Stop();
            }
            if (cBHiljennaTune.Checked == false)
            {
                sp.PlayLooping();
            }
        }
        
        private void btnAvaaGallery_Click(object sender, EventArgs e)  //avaa formin jossa tekijätiedot ja kuvagalleria
        {
            pnlValitseKorttimaara.Enabled = false;
            pnlValitseKorttimaara.Visible = false;
            frmGalleria g = new frmGalleria();
            g.ShowDialog();
        }

        private void frmMainMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)109)
            {
                sp.Stop();
                cBHiljennaTune.Checked = true;
            }
            if (e.KeyChar == (char)112)
            {
                sp.PlayLooping();
                cBHiljennaTune.Checked = false;
            }
        }

        private void tmrRainbow_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int A = rnd.Next(0, 255);
            int R = rnd.Next(0, 255);
            int G = rnd.Next(0, 255);
            int B = rnd.Next(0, 255);
            lblSairaan.ForeColor = Color.FromArgb(A, R, G, B);
        }
    }
}
