using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace Pişti_Oyunu_Ntp
{
    public partial class Masa : Form
    {
        public Masa()
        {
            InitializeComponent();
        }
        int Count = 0;
        KartDestesi Destemiz = new KartDestesi();
        Oyuncu adam1 = new Oyuncu();
        Oyuncu adam2 = new Oyuncu();
        Oyuncu adam3 = new Oyuncu();
        Oyuncu adam4 = new Oyuncu();
        YeniOyun oyun = new YeniOyun();
        private void ZamanTarih()
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSistemiSaat.Text = DateTime.Now.ToLongTimeString();
        }
        private void Masamız_Load(object sender, EventArgs e)
        {
            ZamanTarih();
        }
        void OyunaBasla()
        {
            Count = 0;
            Label[] dizi3 = { lblPlayer1, lblPlayer2, lblPlayer3,  lblPlayer4 };
            ListBox[] dizi = { lstMasa, lstOyuncu1, lstOyuncu2, lstOyuncu3, lstOyuncu4 };
            ComboBox[] dizi2 = { cmbOyun1, cmbOyun2, cmbOyun3, cmbOyun4 };
            oyun.Temizle(dizi3, dizi, dizi2);
            Destemiz = new KartDestesi();
            Destemiz.KartDagit(dizi);
        }

        public void Hesapla()
        {
            adam1.Hesapla2(cmbOyun1, 1, lblPlayer1);
            adam2.Hesapla2(cmbOyun2, 2, lblPlayer2);
            adam3.Hesapla2(cmbOyun3, 3, lblPlayer3);
            adam4.Hesapla2(cmbOyun4, 4, lblPlayer4);
        }
        void playerOyna()
        {
            adam1.playerOyna(lstMasa, lstOyuncu2, cmbOyun2, 2);
            adam2.playerOyna(lstMasa, lstOyuncu3, cmbOyun3, 3);
            adam3.playerOyna(lstMasa, lstOyuncu4, cmbOyun4, 4);
        }

        private void btnKagıtAt_Click(object sender, EventArgs e)
        {
            adam2.playerOyna(lstMasa, lstOyuncu1, cmbOyun1, 1);
            Count++;
            playerOyna();
            if (Count == 4 || Count == 8)
            {
                ListBox[] dizi = { lstOyuncu1, lstOyuncu2, lstOyuncu3, lstOyuncu4 };
                Destemiz.KartDagit(dizi);
            }
            if (Count == 12)
            {
                Hesapla();
                MessageBox.Show("Üzgünüz..Oyun bitti");
            }
            if (!(lstOyuncu1.Items.Count == 0))
            {
                lstOyuncu1.SelectedIndex = 0;
            }
        }
        DialogResult cikisYap = new DialogResult();
        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            cikisYap = MessageBox.Show("Pişti Oyunu Sonlandırılsın Mı?", "Pişti Gaming", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (cikisYap == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Pişti Oyunu Kapatılmadı.", "Pişti Gaming", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKagıtAt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKagıtAt.PerformClick();
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            OyunaBasla();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOyuncu1.Items.Clear();
            lstOyuncu2.Items.Clear();
            lstOyuncu3.Items.Clear();
            lstOyuncu4.Items.Clear();
            lstMasa.Items.Clear();
        }


    }
}
