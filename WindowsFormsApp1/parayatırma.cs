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
    public partial class frm_parayatırma : Form
    {   

        public frm_parayatırma()
        {
            InitializeComponent();
        }
        
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_hesapici frm = new frm_hesapici();
            frm.Show();

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            musteriolanlar musteriolanlar = new musteriolanlar();
            if (txt_eklenentutar.Text == "")
            {
                MessageBox.Show("Lütfen Tutar Giriniz!");
            }

            else
            {
                string eklenen = txt_eklenentutar.Text;
                if (Convert.ToDouble(eklenen) % 5 == 0)
                {
                    if (frm_giris.musterimidegilmi == 1)
                    {

                        frm_giris.bakiye = Convert.ToDouble(eklenen) + frm_giris.bakiye;
                        txt_eklenentutar.Clear();
                        musteriolanlar.musteri[frm_giris.i_degeri, 5] = Convert.ToString(frm_giris.bakiye);

                        //Bu fonksiyonu bakiye değiştirmek için çağırıyoruz.
                        musteriolanlar.MusteriolanlarBakiyeDegistir(frm_giris.tc, frm_giris.bakiye.ToString());

                        KomutYonetimi komutYonetimi = new KomutYonetimi();
                        ParaYatirma parayatirma = new ParaYatirma(komutYonetimi);
                        KomutKontrol komutkontrol = new KomutKontrol();
                        komutkontrol.islemAl(parayatirma);
                        komutkontrol.islemCalistir();

                        MessageBox.Show(Convert.ToString("Yeni Bakiyeniz:" + frm_giris.bakiye) + "₺");


                        this.Hide();
                        frm_hesapici frm = new frm_hesapici();
                        frm.Show();


                    }
                    else
                    {
                        if (MessageBox.Show("işleminizeden 5 tl kesim gerçekleşecektir.Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {


                            frm_giris.bakiye = Convert.ToDouble(eklenen) + frm_giris.bakiye - frm_giris.fark;
                            txt_eklenentutar.Clear();
                            musteriolanlar.musteridegil[frm_giris.i_degeri, 5] = Convert.ToString(frm_giris.bakiye);

                            musteriolanlar.MusteriOlmayanlarBakiyeDegistir(frm_giris.tc, frm_giris.bakiye.ToString());

                            KomutYonetimi komutYonetimi = new KomutYonetimi();
                            ParaYatirma parayatirma = new ParaYatirma(komutYonetimi);
                            KomutKontrol komutkontrol = new KomutKontrol();
                            komutkontrol.islemAl(parayatirma);
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

                    MessageBox.Show("!!Lütfen 5 ve 5 in katlarında tutar giriniz!!");
                    txt_eklenentutar.Clear();
                }

            }
        }

        private void frm_parayatırma_Load(object sender, EventArgs e)
        {

            lbl_isim.Text = frm_giris.isim;
            lbl_soyisim.Text = frm_giris.soyisim;
            lbl_tc.Text = frm_giris.tc;
            lbl_hesapno.Text = frm_giris.hesapno;
            lbl_bakiye.Text = (Convert.ToString(frm_giris.bakiye) + "₺");
        }

        private void grpKisiBilgileri_Enter(object sender, EventArgs e)
        {

        }
        
    }
    
}
