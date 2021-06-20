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
    
    public partial class frm_paratransferi : Form
    {

        public static string yollanan_tc;
        public static string yollanan_hesapno;


        public frm_paratransferi()
        {
            InitializeComponent();
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

        private void paratransferi_Load(object sender, EventArgs e)
        {
            lbl_isim.Text = frm_giris.isim;
            lbl_soyisim.Text = frm_giris.soyisim;
            lbl_tc.Text = frm_giris.tc;
            lbl_hesapno.Text = frm_giris.hesapno;
            lbl_bakiye.Text = (Convert.ToString(frm_giris.bakiye) + "₺");
        }

        private void btn_onayla_Click(object sender, EventArgs e)

        {
            musteriolanlar musteriolanlar = new musteriolanlar();
         
            if (txt_transfertutari.Text == "" || txt_yollananhesapno.Text == "" || txt_yollanantc.Text == "")
            {
                MessageBox.Show("!!EKSİK BİLGİ VAR!!!");
                txt_yollananhesapno.Clear();
                txt_yollanantc.Clear();
                txt_transfertutari.Clear();

            }
            else if (Convert.ToDouble(txt_transfertutari.Text) % 5 == 0)
            {
                double yollanacak = Convert.ToDouble(txt_transfertutari.Text);
                yollanan_tc = txt_yollanantc.Text;
                yollanan_hesapno = txt_yollananhesapno.Text;
                musteriolanlar.TransferKontrol(yollanan_tc,yollanan_hesapno);
                if (frm_giris.bakiye >= yollanacak + frm_giris.fark)
                {

                    if (frm_giris.musterimidegilmi == 1 && musteriolanlar.bizdenmi == 1)
                    {
                        frm_giris.bakiye = frm_giris.bakiye - yollanacak;
                  
                        musteriolanlar.musteri[frm_giris.i_degeri, 5] = Convert.ToString(frm_giris.bakiye);
                        musteriolanlar.MusteriolanlarBakiyeDegistir(frm_giris.tc, frm_giris.bakiye.ToString());

                        musteriolanlar.yollananbakiye = yollanacak + musteriolanlar.yollananbakiye;
                        musteriolanlar.musteri[musteriolanlar.yollanani_degeri, 5] = Convert.ToString(musteriolanlar.yollananbakiye);
                        musteriolanlar.MusteriolanlarBakiyeDegistir(musteriolanlar.yollanantc,musteriolanlar.yollananbakiye.ToString());

                        ParaTransferi transfer = new HavaleYontemi();
                        transfer.TemplateMethod();


                        MessageBox.Show(Convert.ToString("Yeni Bakiyeniz:" + frm_giris.bakiye) + "₺");
                        txt_yollananhesapno.Clear();
                        txt_yollanantc.Clear();
                        txt_transfertutari.Clear();

                        


                        //Bu fonksiyonu bakiye değiştirmek için çağırıyoruz.
                        
                        
                        this.Hide();
                        frm_hesapici frm = new frm_hesapici();
                        frm.Show();

                    }
                    else if(musteriolanlar.bizdenmi==2)
                    {

                        MessageBox.Show("!!Böyle bir müşteri yok!!");
                        txt_yollananhesapno.Clear();
                        txt_yollanantc.Clear();
                        txt_transfertutari.Clear();
                    }
                    else if(frm_giris.musterimidegilmi==1 && musteriolanlar.bizdenmi==0)
                    {

                        if (MessageBox.Show("işleminizeden 5 tl kesim gerçekleşecektir.Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {


                            frm_giris.bakiye = frm_giris.bakiye - yollanacak-frm_giris.fark;

                            musteriolanlar.musteri[frm_giris.i_degeri, 5] = Convert.ToString(frm_giris.bakiye);                      
                            musteriolanlar.yollananbakiye = yollanacak + musteriolanlar.yollananbakiye;

                            musteriolanlar.MusteriolanlarBakiyeDegistir(frm_giris.tc, frm_giris.bakiye.ToString());

                            musteriolanlar.musteri[musteriolanlar.yollanani_degeri, 5] = Convert.ToString(musteriolanlar.yollananbakiye);
                            musteriolanlar.MusteriOlmayanlarBakiyeDegistir(musteriolanlar.yollanantc, musteriolanlar.yollananbakiye.ToString());

                            ParaTransferi transfer = new EFTYontemi();
                            transfer.TemplateMethod();


                            MessageBox.Show(Convert.ToString("Yeni Bakiyeniz:" + frm_giris.bakiye) + "₺");
                            

                           

                            txt_yollananhesapno.Clear();
                            txt_yollanantc.Clear();
                            txt_transfertutari.Clear();
                            this.Hide();
                            frm_hesapici frm = new frm_hesapici();
                            frm.Show();

                        }
                    }



                    else if(musteriolanlar.bizdenmi==1 && frm_giris.musterimidegilmi == 0)
                    {

                         if (MessageBox.Show("işleminizeden 5 tl kesim gerçekleşecektir.Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                frm_giris.bakiye = frm_giris.bakiye - yollanacak-frm_giris.fark;

                                musteriolanlar.musteri[frm_giris.i_degeri, 5] = Convert.ToString(frm_giris.bakiye);
                                musteriolanlar.MusteriOlmayanlarBakiyeDegistir(frm_giris.tc, frm_giris.bakiye.ToString());

                                musteriolanlar.yollananbakiye = yollanacak + musteriolanlar.yollananbakiye;
                                musteriolanlar.musteri[musteriolanlar.yollanani_degeri, 5] = Convert.ToString(musteriolanlar.yollananbakiye);
                                musteriolanlar.MusteriolanlarBakiyeDegistir(musteriolanlar.yollanantc, musteriolanlar.yollananbakiye.ToString());

                                ParaTransferi transfer = new EFTYontemi();
                                transfer.TemplateMethod();


                            MessageBox.Show(Convert.ToString("Yeni Bakiyeniz:" + frm_giris.bakiye) + "₺");
                                txt_yollananhesapno.Clear();
                                txt_yollanantc.Clear();
                                txt_transfertutari.Clear();

                        


                        //Bu fonksiyonu bakiye değiştirmek için çağırıyoruz.

                            txt_yollananhesapno.Clear();
                             txt_yollanantc.Clear();
                            txt_transfertutari.Clear();
                            this.Hide();
                            frm_hesapici frm = new frm_hesapici();
                            frm.Show();
                        }
                    }
                    else if (frm_giris.musterimidegilmi == 0 && musteriolanlar.bizdenmi == 0)
                    {

                        if (MessageBox.Show("işleminizeden 5 tl kesim gerçekleşecektir.Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {


                            frm_giris.bakiye = frm_giris.bakiye - yollanacak - frm_giris.fark;

                            musteriolanlar.musteri[frm_giris.i_degeri, 5] = Convert.ToString(frm_giris.bakiye);
                            musteriolanlar.yollananbakiye = yollanacak + musteriolanlar.yollananbakiye;

                            musteriolanlar.MusteriOlmayanlarBakiyeDegistir (frm_giris.tc, frm_giris.bakiye.ToString());

                            musteriolanlar.musteri[musteriolanlar.yollanani_degeri, 5] = Convert.ToString(musteriolanlar.yollananbakiye);
                            musteriolanlar.MusteriOlmayanlarBakiyeDegistir(musteriolanlar.yollanantc, musteriolanlar.yollananbakiye.ToString());

                            ParaTransferi transfer = new EFTYontemi();
                            transfer.TemplateMethod();


                            MessageBox.Show(Convert.ToString("Yeni Bakiyeniz:" + frm_giris.bakiye) + "₺");




                            txt_yollananhesapno.Clear();
                            txt_yollanantc.Clear();
                            txt_transfertutari.Clear();
                            this.Hide();
                            frm_hesapici frm = new frm_hesapici();
                            frm.Show();

                        }
                    }


                }
                else
                {

                    MessageBox.Show("Yeterli Bakiye Yok!");
                    txt_transfertutari.Clear();
                    txt_yollananhesapno.Clear();
                    txt_yollanantc.Clear();


                }
            }

            else
            {

                MessageBox.Show("!!Lütfen 5 ve 5 in katlarında tutar giriniz!!");
                txt_transfertutari.Clear();
                txt_yollananhesapno.Clear();
                txt_yollanantc.Clear();



            }
        }

        private void frm_paratransferi_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_paratransferi_FormClosing(object sender, FormClosingEventArgs e)
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
