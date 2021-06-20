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
    public partial class frm_odemeler : Form
    {
        public static int odemedeger;
        Facade f = new Facade();


        public frm_odemeler()
        {
            InitializeComponent();
        }

        private void frm_odemeler_Load(object sender, EventArgs e)
        {
            cmbbx_telefonodeme.Visible = false;
            cmbbx_kartodemesi.Visible = false;
            cmbbx_egitimodeme.Visible = false;
            lbl_isim.Text = frm_giris.isim;
            lbl_soyisim.Text = frm_giris.soyisim;
            lbl_tc.Text = frm_giris.tc;
            lbl_hesapno.Text = frm_giris.hesapno;
            lbl_bakiye.Text = (Convert.ToString(frm_giris.bakiye) + "₺");
        }



        private void radio_telefonodeme_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_telefonodeme.Checked)
            {
                cmbbx_telefonodeme.Visible = true;


            }
            else
            {
                cmbbx_telefonodeme.Visible =false;
            }

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            musteriolanlar odemeturu = new musteriolanlar();

            if (cmbbx_telefonodeme.Visible == true && cmbbx_telefonodeme.Text == "cep telefonu faturası")
            {
                
                f.Transfer_Gerceklestir(cmbbx_telefonodeme.Text + ": 42,5₺");


                odemeturu.odeme(42.5);
                this.Hide();
                frm_odemeler frm = new frm_odemeler();
                frm.Show();
            }
            else if (cmbbx_telefonodeme.Visible == true && cmbbx_telefonodeme.Text == "ev telefonu faturası")
            {
                
                f.Transfer_Gerceklestir("yok");
                this.Hide();
                frm_odemeler frm = new frm_odemeler();
                frm.Show();
            }
            if (cmbbx_egitimodeme.Visible == true && cmbbx_egitimodeme.Text == "KYK Borç Ödemesi")
            {
                f.Transfer_Gerceklestir(cmbbx_egitimodeme.Text + ": 400");
                odemeturu.odeme(400);
                this.Hide();
                frm_odemeler frm = new frm_odemeler();
                frm.Show();
            }
            else if (cmbbx_egitimodeme.Visible == true && cmbbx_egitimodeme.Text == "KYK Yurt Parası Ödeme")
            {
                f.Transfer_Gerceklestir("KYK Yurt  Ücreti:" + " 230");
                odemeturu.odeme(230);
                this.Hide();
                frm_odemeler frm = new frm_odemeler();
                frm.Show();
            }
            else if (cmbbx_egitimodeme.Visible == true && cmbbx_egitimodeme.Text == "Sınav Parası Yatırma")
            {
                f.Transfer_Gerceklestir("sınav giriş ücreti" + ": 55");
                odemeturu.odeme(55);
                this.Hide();
                frm_odemeler frm = new frm_odemeler();
                frm.Show();

            }
            if (cmbbx_kartodemesi.Visible == true && cmbbx_kartodemesi.Text == "Tüm Borç Ödeme")
            {
                f.Transfer_Gerceklestir("Tüm Borç :"+" 600");
                odemeturu.odeme(600);
                this.Hide();
                frm_odemeler frm = new frm_odemeler();
                frm.Show();
            }
            else if (cmbbx_kartodemesi.Visible == true && cmbbx_kartodemesi.Text == "Dönem Borcu Ödeme")
            {
                f.Transfer_Gerceklestir("Dönem Borcu:" + "236");
                odemeturu.odeme(236);
                this.Hide();
                frm_odemeler frm = new frm_odemeler();
                frm.Show();
            }
        }

        private void radio_kartodemesi_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_kartodemesi.Checked)
            {
                cmbbx_kartodemesi.Visible = true;

            }
            else
            {
                cmbbx_kartodemesi.Visible = false;
            }

        }

        private void radio_egitimodemesi_CheckedChanged(object sender, EventArgs e)
        {


            if (radio_egitimodemesi.Checked)
            {
                cmbbx_egitimodeme.Visible = true;

            }
            else
            {
                cmbbx_egitimodeme.Visible = false;

            }

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_hesapici frm = new frm_hesapici();
            frm.Show();

            
        }

        private void btn_cikis_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       
    }
}
    
