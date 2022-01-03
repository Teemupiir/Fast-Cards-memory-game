namespace Muistipeli
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.btnAvaaYksinpeli = new System.Windows.Forms.Button();
            this.pnlValikko = new System.Windows.Forms.Panel();
            this.cBHiljennaTune = new System.Windows.Forms.CheckBox();
            this.btnAvaaGallery = new System.Windows.Forms.Button();
            this.btnPoistupelista = new System.Windows.Forms.Button();
            this.btnAvaamoninpeli = new System.Windows.Forms.Button();
            this.pnlValitseKorttimaara = new System.Windows.Forms.Panel();
            this.btnValitse12 = new System.Windows.Forms.Button();
            this.btnValitse16 = new System.Windows.Forms.Button();
            this.btnValitse8 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblSairaan = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tmrRainbow = new System.Windows.Forms.Timer(this.components);
            this.pnlValikko.SuspendLayout();
            this.pnlValitseKorttimaara.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAvaaYksinpeli
            // 
            this.btnAvaaYksinpeli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAvaaYksinpeli.BackColor = System.Drawing.Color.Aqua;
            this.btnAvaaYksinpeli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAvaaYksinpeli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvaaYksinpeli.FlatAppearance.BorderSize = 2;
            this.btnAvaaYksinpeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvaaYksinpeli.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaaYksinpeli.Location = new System.Drawing.Point(281, 174);
            this.btnAvaaYksinpeli.Name = "btnAvaaYksinpeli";
            this.btnAvaaYksinpeli.Size = new System.Drawing.Size(274, 61);
            this.btnAvaaYksinpeli.TabIndex = 0;
            this.btnAvaaYksinpeli.Text = "Yksinpeli";
            this.toolTip1.SetToolTip(this.btnAvaaYksinpeli, "Pelaa muistipeliä aikaa vastaan!");
            this.btnAvaaYksinpeli.UseVisualStyleBackColor = false;
            this.btnAvaaYksinpeli.Click += new System.EventHandler(this.btnAvaaYksinpeli_Click);
            // 
            // pnlValikko
            // 
            this.pnlValikko.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlValikko.BackColor = System.Drawing.Color.Transparent;
            this.pnlValikko.Controls.Add(this.cBHiljennaTune);
            this.pnlValikko.Controls.Add(this.btnAvaaGallery);
            this.pnlValikko.Controls.Add(this.btnPoistupelista);
            this.pnlValikko.Controls.Add(this.btnAvaamoninpeli);
            this.pnlValikko.Controls.Add(this.btnAvaaYksinpeli);
            this.pnlValikko.Location = new System.Drawing.Point(225, 111);
            this.pnlValikko.Name = "pnlValikko";
            this.pnlValikko.Size = new System.Drawing.Size(836, 662);
            this.pnlValikko.TabIndex = 3;
            this.pnlValikko.Click += new System.EventHandler(this.pnlValikko_Click);
            // 
            // cBHiljennaTune
            // 
            this.cBHiljennaTune.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBHiljennaTune.BackColor = System.Drawing.Color.Aqua;
            this.cBHiljennaTune.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cBHiljennaTune.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBHiljennaTune.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBHiljennaTune.Location = new System.Drawing.Point(281, 487);
            this.cBHiljennaTune.Name = "cBHiljennaTune";
            this.cBHiljennaTune.Size = new System.Drawing.Size(274, 39);
            this.cBHiljennaTune.TabIndex = 3;
            this.cBHiljennaTune.TabStop = false;
            this.cBHiljennaTune.Text = "Hiljennä musiikki (m/p)";
            this.cBHiljennaTune.UseVisualStyleBackColor = false;
            this.cBHiljennaTune.CheckedChanged += new System.EventHandler(this.cBHiljennaTune_CheckedChanged);
            // 
            // btnAvaaGallery
            // 
            this.btnAvaaGallery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAvaaGallery.BackColor = System.Drawing.Color.Aqua;
            this.btnAvaaGallery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAvaaGallery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvaaGallery.FlatAppearance.BorderSize = 2;
            this.btnAvaaGallery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvaaGallery.Font = new System.Drawing.Font("Harlow Solid Italic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaaGallery.Location = new System.Drawing.Point(281, 333);
            this.btnAvaaGallery.Name = "btnAvaaGallery";
            this.btnAvaaGallery.Size = new System.Drawing.Size(274, 61);
            this.btnAvaaGallery.TabIndex = 2;
            this.btnAvaaGallery.Text = "Galleria/Tekijät";
            this.toolTip1.SetToolTip(this.btnAvaaGallery, "Katso tekijätiedot ja ihastele pelin upeita autoja!");
            this.btnAvaaGallery.UseVisualStyleBackColor = false;
            this.btnAvaaGallery.Click += new System.EventHandler(this.btnAvaaGallery_Click);
            // 
            // btnPoistupelista
            // 
            this.btnPoistupelista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPoistupelista.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPoistupelista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPoistupelista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoistupelista.FlatAppearance.BorderSize = 2;
            this.btnPoistupelista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoistupelista.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistupelista.Location = new System.Drawing.Point(281, 532);
            this.btnPoistupelista.Name = "btnPoistupelista";
            this.btnPoistupelista.Size = new System.Drawing.Size(274, 61);
            this.btnPoistupelista.TabIndex = 4;
            this.btnPoistupelista.Text = "Poistu pelistä";
            this.btnPoistupelista.UseVisualStyleBackColor = false;
            this.btnPoistupelista.Click += new System.EventHandler(this.btnPoistupelista_Click);
            // 
            // btnAvaamoninpeli
            // 
            this.btnAvaamoninpeli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAvaamoninpeli.BackColor = System.Drawing.Color.Aqua;
            this.btnAvaamoninpeli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAvaamoninpeli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvaamoninpeli.FlatAppearance.BorderSize = 2;
            this.btnAvaamoninpeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvaamoninpeli.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaamoninpeli.Location = new System.Drawing.Point(281, 254);
            this.btnAvaamoninpeli.Name = "btnAvaamoninpeli";
            this.btnAvaamoninpeli.Size = new System.Drawing.Size(274, 61);
            this.btnAvaamoninpeli.TabIndex = 1;
            this.btnAvaamoninpeli.Text = "Moninpeli";
            this.toolTip1.SetToolTip(this.btnAvaamoninpeli, "Pelaa muistipeliä toista (lokaalia) pelaajaa vastaan!");
            this.btnAvaamoninpeli.UseVisualStyleBackColor = false;
            this.btnAvaamoninpeli.Click += new System.EventHandler(this.btnAvaamoninpeli_Click);
            // 
            // pnlValitseKorttimaara
            // 
            this.pnlValitseKorttimaara.BackColor = System.Drawing.Color.Transparent;
            this.pnlValitseKorttimaara.Controls.Add(this.btnValitse12);
            this.pnlValitseKorttimaara.Controls.Add(this.btnValitse16);
            this.pnlValitseKorttimaara.Controls.Add(this.btnValitse8);
            this.pnlValitseKorttimaara.Enabled = false;
            this.pnlValitseKorttimaara.Location = new System.Drawing.Point(1106, 524);
            this.pnlValitseKorttimaara.Name = "pnlValitseKorttimaara";
            this.pnlValitseKorttimaara.Size = new System.Drawing.Size(220, 162);
            this.pnlValitseKorttimaara.TabIndex = 4;
            this.pnlValitseKorttimaara.Visible = false;
            // 
            // btnValitse12
            // 
            this.btnValitse12.BackColor = System.Drawing.Color.Turquoise;
            this.btnValitse12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValitse12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValitse12.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValitse12.Location = new System.Drawing.Point(3, 54);
            this.btnValitse12.Name = "btnValitse12";
            this.btnValitse12.Size = new System.Drawing.Size(208, 45);
            this.btnValitse12.TabIndex = 1;
            this.btnValitse12.Text = "12 korttia";
            this.btnValitse12.UseVisualStyleBackColor = false;
            this.btnValitse12.Click += new System.EventHandler(this.btnValitse12_Click);
            // 
            // btnValitse16
            // 
            this.btnValitse16.BackColor = System.Drawing.Color.Turquoise;
            this.btnValitse16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValitse16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValitse16.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValitse16.Location = new System.Drawing.Point(3, 105);
            this.btnValitse16.Name = "btnValitse16";
            this.btnValitse16.Size = new System.Drawing.Size(208, 45);
            this.btnValitse16.TabIndex = 2;
            this.btnValitse16.Text = "16 korttia";
            this.btnValitse16.UseVisualStyleBackColor = false;
            this.btnValitse16.Click += new System.EventHandler(this.btnValitse16_Click);
            // 
            // btnValitse8
            // 
            this.btnValitse8.BackColor = System.Drawing.Color.Turquoise;
            this.btnValitse8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValitse8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValitse8.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValitse8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnValitse8.Location = new System.Drawing.Point(3, 3);
            this.btnValitse8.Name = "btnValitse8";
            this.btnValitse8.Size = new System.Drawing.Size(208, 45);
            this.btnValitse8.TabIndex = 0;
            this.btnValitse8.Text = "8 korttia";
            this.btnValitse8.UseVisualStyleBackColor = false;
            this.btnValitse8.Click += new System.EventHandler(this.btnvalitse8_Click);
            // 
            // lblSairaan
            // 
            this.lblSairaan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSairaan.AutoSize = true;
            this.lblSairaan.BackColor = System.Drawing.Color.Transparent;
            this.lblSairaan.Font = new System.Drawing.Font("Magneto", 45.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSairaan.ForeColor = System.Drawing.Color.Red;
            this.lblSairaan.Location = new System.Drawing.Point(250, -143);
            this.lblSairaan.Name = "lblSairaan";
            this.lblSairaan.Size = new System.Drawing.Size(0, 75);
            this.lblSairaan.TabIndex = 5;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Nopeat kortit\r\nYou found me ;)\r\n";
            this.notifyIcon1.Visible = true;
            // 
            // tmrRainbow
            // 
            this.tmrRainbow.Tick += new System.EventHandler(this.tmrRainbow_Tick);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Muistipeli.Properties.Resources.Nopeat_kortit_kansitaide;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1301, 775);
            this.Controls.Add(this.lblSairaan);
            this.Controls.Add(this.pnlValitseKorttimaara);
            this.Controls.Add(this.pnlValikko);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMainMenu";
            this.Text = "Nopeat kortit -muistipeli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.frmMainMenu_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMainMenu_KeyPress);
            this.pnlValikko.ResumeLayout(false);
            this.pnlValitseKorttimaara.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvaaYksinpeli;
        private System.Windows.Forms.Panel pnlValikko;
        private System.Windows.Forms.Button btnPoistupelista;
        private System.Windows.Forms.Button btnAvaamoninpeli;
        private System.Windows.Forms.Button btnValitse16;
        private System.Windows.Forms.Button btnValitse8;
        private System.Windows.Forms.Panel pnlValitseKorttimaara;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cBHiljennaTune;
        private System.Windows.Forms.Button btnAvaaGallery;
        public System.Windows.Forms.Label lblSairaan;
        private System.Windows.Forms.Button btnValitse12;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.Timer tmrRainbow;
    }
}