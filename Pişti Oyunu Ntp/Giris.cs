using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pişti_Oyunu_Ntp
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            prgGiris.Maximum = 350;
            prgGiris.BackColor = Color.Cyan;
            prgGiris.ForeColor = Color.DarkBlue;
            tmrGiris.Interval = 10;
            tmrGiris.Enabled = true;

        }
        Masa masaCagir = new Masa();
        private void tmrGiris_Tick(object sender, EventArgs e)
        {
            if (prgGiris.Value==prgGiris.Maximum)
            {
                tmrGiris.Enabled = false;
                this.Hide();
                masaCagir.ShowDialog();
            }
            else
            {
                prgGiris.Value += 1;
            }
        }

  
    }
}
