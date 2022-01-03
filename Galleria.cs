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
    public partial class frmGalleria : Form
    {

        
        public frmGalleria()
        {
            InitializeComponent();
            this.Opacity = 0.95;
            

        }

        private void btnPoistu_Click(object sender, EventArgs e)  //paluu päävalikkoon
        {
            this.Close(); 

        }
        
        private void pictureBox7_Click(object sender, EventArgs e)  //easter egg ;)
        {
            frmMainMenu main = new frmMainMenu();
            main.lblSairaan.Text = lblLahetaSairaan.Text;
            main.tmrRainbow.Enabled = true;
            main.ShowDialog();
            this.Close();
        }
    }
}
