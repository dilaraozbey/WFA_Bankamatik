using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_hesapici : Form
    {
        public frm_hesapici()
        {   
           

            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_hesapici_Load(object sender, EventArgs e)

        {

            lbl_isim.Text = frm_giris.isim;
            lbl_soyisim.Text = frm_giris.soyisim;
            lbl_tc.Text = frm_giris.tc;
            lbl_hesapno.Text = frm_giris.hesapno;
            lbl_bakiye.Text = (Convert.ToString(frm_giris.bakiye)+ "₺");

            
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_parayatırma_Click(object sender, EventArgs e)
        {



            this.Hide();
            frm_parayatırma frm = new frm_parayatırma();
            frm.Show();

        }

        private void btn_paracekme_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_paracekme frm = new frm_paracekme();
            frm.Show();

        }

        private void lbl_tc_Click(object sender, EventArgs e)
        {

        }

        private void btn_paratransferi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_paratransferi frm = new frm_paratransferi();
            frm.Show();

        }

        private void btn_odemeler_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_odemeler frm = new frm_odemeler();
            frm.Show();
        }

        private void frm_hesapici_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                DialogResult dialog = MessageBox.Show("Programı Kapatmak İstiyor Musunuz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialog == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
