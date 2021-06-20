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
    public partial class frm_paracekme : Form
    {
        public frm_paracekme()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_hesapici frm = new frm_hesapici();
            frm.Show();
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            musteriolanlar musteriolanlar = new musteriolanlar();
            if (txt_cekilecektutar.Text == "")
            {
                MessageBox.Show("Lütfen Tutar Giriniz!");
            }
            


            else
            {
                double cekilen = Convert.ToDouble(txt_cekilecektutar.Text);

                if (cekilen % 5 == 0)
                {

                    if (frm_giris.bakiye >= cekilen + frm_giris.fark)
                    {
                        if (frm_giris.musterimidegilmi == 1)
                        {
                            frm_giris.bakiye = frm_giris.bakiye - Convert.ToDouble(cekilen);
                            txt_cekilecektutar.Clear();
                            musteriolanlar.musteri[frm_giris.i_degeri, 5] = Convert.ToString(frm_giris.bakiye);
                            musteriolanlar.MusteriolanlarBakiyeDegistir(frm_giris.tc,musteriolanlar.musteri[frm_giris.i_degeri, 5]);

                            KomutYonetimi komutYonetimi = new KomutYonetimi();
                            ParaCekme paracekme = new ParaCekme(komutYonetimi);
                            KomutKontrol komutkontrol = new KomutKontrol();
                            komutkontrol.islemAl(paracekme);
                            komutkontrol.islemCalistir();

                            MessageBox.Show(Convert.ToString("Yeni Bakiyeniz:" + frm_giris.bakiye + "₺"));


                            this.Hide();
                            frm_hesapici frm = new frm_hesapici();
                            frm.Show();


                        }
                        else
                        {
                            if (MessageBox.Show("işleminizeden 5 tl kesim gerçekleşecektir.Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {

                                frm_giris.bakiye = frm_giris.bakiye - Convert.ToDouble(cekilen) - frm_giris.fark;
                                txt_cekilecektutar.Clear();
                                musteriolanlar.musteridegil[frm_giris.i_degeri, 5] = Convert.ToString(frm_giris.bakiye);
                                musteriolanlar.MusteriOlmayanlarBakiyeDegistir( frm_giris.tc,musteriolanlar.musteridegil[frm_giris.i_degeri, 5]);

                                KomutYonetimi komutYonetimi = new KomutYonetimi();
                                ParaCekme paracekme = new ParaCekme(komutYonetimi);
                                KomutKontrol komutkontrol = new KomutKontrol();
                                komutkontrol.islemAl(paracekme);
                                komutkontrol.islemCalistir();

                                MessageBox.Show(Convert.ToString("Yeni Bakiyeniz:" + frm_giris.bakiye) + "₺");


                                this.Hide();
                                frm_hesapici frm = new frm_hesapici();
                                frm.Show();
                            }


                        }
                    }
                    else
                    {
                        MessageBox.Show("Yeterli Bakiye Yok!");
                        txt_cekilecektutar.Clear();

                    }

                }
                else
                {


                    MessageBox.Show("!!Lütfen 5 ve 5 in katlarında tutar giriniz!!");
                    txt_cekilecektutar.Clear();
                }

            }


            
        }

        private void frm_paracekme_Load(object sender, EventArgs e)
        {
            lbl_isim.Text = frm_giris.isim;
            lbl_soyisim.Text = frm_giris.soyisim;
            lbl_tc.Text = frm_giris.tc;
            lbl_hesapno.Text = frm_giris.hesapno;
            lbl_bakiye.Text = (Convert.ToString(frm_giris.bakiye) + "₺");
        }
        private void frm_paracekme_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frm_paracekme_FormClosing_1(object sender, FormClosingEventArgs e)
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
