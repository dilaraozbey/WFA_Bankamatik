using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class musteriolanlar
    {
        public string[,] musteri = new string[8000, 6];
        public string[,] musteridegil = new string[8000, 6];
        public static int bizdenmi = 2;
        public static string yollanantc;
        public static string yollananisim = "a";
        public static string yollanansoyisim;
        public static string yollananhesapno;
        public static double yollananbakiye;
        public static int yollanani_degeri;
        public static double yollananfark = 5;




        public void MusteriGetir()
        {
            string dosya_yolu = @"musteriolanlar.txt";
            //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            int i = 0;
            while (yazi != null)
            {
                string[] words = yazi.Split(' ');

                musteri[i, 0] = words[0];
                musteri[i, 1] = words[1];
                musteri[i, 2] = words[2];
                musteri[i, 3] = words[3];
                musteri[i, 4] = words[4];
                musteri[i, 5] = words[5];

                i++;
                yazi = sw.ReadLine();

            }
            sw.Close();
            fs.Close();


        }

       

        public void MusteriOlmayanGetir()
        {
            string dosya_yolu = @"musteriolmayanlar.txt";
            //Okuma işlem yapacağımız dosyanın yolunu belirtiyoruz.
            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);
            //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
            //2.parametre dosyanın açılacağını,
            //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
            StreamReader sw = new StreamReader(fs);
            //Okuma işlemi için bir StreamReader nesnesi oluşturduk.
            string yazi = sw.ReadLine();
            int i = 0;
            while (yazi != null)
            {
                string[] words = yazi.Split(' ');

                musteridegil[i, 0] = words[0];
                musteridegil[i, 1] = words[1];
                musteridegil[i, 2] = words[2];
                musteridegil[i, 3] = words[3];
                musteridegil[i, 4] = words[4];
                musteridegil[i, 5] = words[5];

                i++;
                yazi = sw.ReadLine();

            }
            sw.Close();
            fs.Close();


        }


        // bu fonksiyo bakiye değiştirir.
        public void MusteriolanlarBakiyeDegistir(string tc, string bakiye)
        {

            StringBuilder newFile = new StringBuilder();
            string temp = "";
            string[] file = File.ReadAllLines(@"musteriolanlar.txt");
            foreach (string line in file)
            {
                if (line.Contains(tc))
                {
                    string[] words = line.Split(' ');
                    temp = line.Replace(words[5], bakiye);
                    newFile.Append(temp + "\r\n");
                    continue;
                }
                newFile.Append(line + "\r\n");
            }
            File.WriteAllText(@"musteriolanlar.txt", newFile.ToString());

        }
        // bu fonksiyo bakiye değiştirir.
        public void MusteriOlmayanlarBakiyeDegistir(string tc, string bakiye)
        {

            StringBuilder newFile = new StringBuilder();
            string temp = "";
            string[] file = File.ReadAllLines(@"musteriolmayanlar.txt");
            foreach (string line in file)
            {
                if (line.Contains(tc))
                {
                    string[] words = line.Split(' ');
                    temp = line.Replace(words[5], bakiye);
                    newFile.Append(temp + "\r\n");
                    continue;
                }
                newFile.Append(line + "\r\n");
            }
            File.WriteAllText(@"musteriolmayanlar.txt", newFile.ToString());

        }


        public void odeme(double fatura)
        {
            musteriolanlar musteriolanlar = new musteriolanlar();
            
            if (frm_giris.musterimidegilmi==1)
            {
                if (frm_giris.bakiye < fatura)
                {
                    MessageBox.Show("Yeterli bakiye yok!");
                }
                else
                {
                    MessageBox.Show("Ödeme Başarılı!\n" + "Kalan Bakiye:" + (frm_giris.bakiye - fatura).ToString() + "₺");
                    frm_giris.bakiye = frm_giris.bakiye - fatura;
                    musteriolanlar.MusteriolanlarBakiyeDegistir(frm_giris.tc, frm_giris.bakiye.ToString());
                }
            }
            if (frm_giris.musterimidegilmi==0)
            {
                if (MessageBox.Show("işleminizeden 5 tl kesim gerçekleşecektir.Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                { 

                        if (frm_giris.bakiye < fatura)
                    {
                        MessageBox.Show("Yeterli bakiye yok!");
                    }
                    else
                    {
                        MessageBox.Show("Ödeme Başarılı!\n" +  "Kalan Bakiye:" + (frm_giris.bakiye - fatura-frm_giris.fark).ToString() + "₺");
                        frm_giris.bakiye = frm_giris.bakiye - fatura - frm_giris.fark;
                        musteriolanlar.MusteriOlmayanlarBakiyeDegistir(frm_giris.tc, frm_giris.bakiye.ToString());
                    }
                }
            }            
        }






        public void TransferKontrol(string tctest, string hesapnotest)
        {
            musteriolanlar musteriolanlar = new musteriolanlar();
            musteriolanlar.MusteriGetir();


            for (int i = 0; i <= musteriolanlar.musteri.GetUpperBound(0); i++)
            {


                tctest = (musteriolanlar.musteri[i, 0]);
                hesapnotest = (musteriolanlar.musteri[i, 4]);


                if (tctest == frm_paratransferi.yollanan_tc && hesapnotest == frm_paratransferi.yollanan_hesapno)
                {
                    bizdenmi = 1;
                    yollanantc = tctest;
                    yollananisim = musteriolanlar.musteri[i, 2];
                    yollanansoyisim = musteriolanlar.musteri[i, 3];
                    yollananhesapno = hesapnotest;
                    yollananbakiye = Convert.ToDouble(musteriolanlar.musteri[i, 5]);
                    yollanani_degeri = i;
                    i = musteriolanlar.musteri.GetUpperBound(0) + 1;

                }
            }

            //musteridegil
            musteriolanlar.MusteriOlmayanGetir();

            for (int i = 0; i <= musteriolanlar.musteridegil.GetUpperBound(0); i++)
            {


                tctest = (musteriolanlar.musteridegil[i, 0]);
                hesapnotest = (musteriolanlar.musteridegil[i, 4]);
                if (tctest == frm_paratransferi.yollanan_tc && hesapnotest == frm_paratransferi.yollanan_hesapno)
                {
                    bizdenmi = 0;
                    yollanantc = tctest;
                    yollananisim = musteriolanlar.musteridegil[i, 2];
                    yollanansoyisim = musteriolanlar.musteridegil[i, 3];
                    yollananhesapno = hesapnotest;
                    yollananbakiye = Convert.ToDouble(musteriolanlar.musteridegil[i, 5]);
                    yollanani_degeri = i;
                    i = musteriolanlar.musteri.GetUpperBound(0) + 1;

                }

            }

        }
    }
    
}







