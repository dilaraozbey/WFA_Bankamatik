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
    public partial class frm_giris : Form
    {

        public static string tc;
        public static string sifre;
        public static string isim = "a";
        public static string soyisim;
        public static string hesapno;
        public static double bakiye;
        public static int musterimidegilmi = 2;
        public static int i_degeri;
        public static double fark = 5;
        public static string tctest;
        


        public frm_giris()
        {
            InitializeComponent();
        }
        

        private void frm_musteri_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }


        private void txt_tcmusteri_TextChanged(object sender, EventArgs e)
        {

        }


        private  void btn_onaylamusteri_Click(object sender, EventArgs e)
        {

            musteriolanlar musteriolanlar = new musteriolanlar();
            musteriolanlar.MusteriGetir();
            int j=0;
            

            for ( int i = 0; i <= musteriolanlar.musteri.GetUpperBound(0); i++)
            {
                
                
                tctest = (musteriolanlar.musteri[i, j]);
                sifre = (musteriolanlar.musteri[i, (j + 1)]);

                if (tctest == txt_tcmusteri.Text && sifre == txt_sifremusteri.Text)
                {
                    musterimidegilmi = 1;
                    tc = tctest;
                    isim = musteriolanlar.musteri[i, j + 2];
                    soyisim = musteriolanlar.musteri[i, j + 3];
                    hesapno = musteriolanlar.musteri[i, j + 4];
                    bakiye = Convert.ToDouble(musteriolanlar.musteri[i, j + 5]);
                    i_degeri = i;
                    i = musteriolanlar.musteri.GetUpperBound(0)+1;

                }
            }

            //musteridegil
            musteriolanlar.MusteriOlmayanGetir();

            for (int i = 0; i <= musteriolanlar.musteridegil.GetUpperBound(0); i++)
            {
                    
                
                tctest= (musteriolanlar.musteridegil[i, j]);
                sifre = (musteriolanlar.musteridegil[i, (j + 1)]);
                if (tctest == txt_tcmusteri.Text && sifre == txt_sifremusteri.Text)
                {
                        musterimidegilmi = 0;
                        tc = tctest;
                        isim = musteriolanlar.musteridegil[i, j + 2];
                        soyisim = musteriolanlar.musteridegil[i, j + 3];
                        hesapno = musteriolanlar.musteridegil[i, j + 4];
                        bakiye = Convert.ToDouble(musteriolanlar.musteridegil[i, j + 5]);
                        i_degeri = i;
                        i = musteriolanlar.musteri.GetUpperBound(0)+1;

                }
             

            }
            if (musterimidegilmi == 0)
            {
                Target target = new Adapter();
                target.MusteriIslem();
               
                this.Hide();
                frm_hesapici frm = new frm_hesapici();
                frm.Show();



            }

            else if (musterimidegilmi == 1)
            {
                this.Hide();
                frm_hesapici frm = new frm_hesapici();
                frm.Show();
            }
            else
            {


                txt_tcmusteri.Clear();
                txt_sifremusteri.Clear();
                MessageBox.Show("Yanlış ya da eksik bilgi girdiniz!");

            }
        }

        private void txt_sifremusteri_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            dilarabank frm = new dilarabank();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblsaat.Text = DateTime.Now.ToLongTimeString();
            lbltarih.Text = DateTime.Now.ToShortDateString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_giris_FormClosing(object sender, FormClosingEventArgs e)
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
