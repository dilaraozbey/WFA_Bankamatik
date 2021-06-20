using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    enum TransferTipi
    {
        Havale, Eft
    }
    
    abstract class ParaTransferi
    {
        public string MusteriTuru;
        public  TransferTipi odemeTipi;
        void Baslat()
        {
            MessageBox.Show("Transfer işlemi gerçekleştiriliyor. Lütfen bekleyin...");
        }
        void Bitir()
        {
            MessageBox.Show($"Tutar {MusteriTuru}  {odemeTipi} yöntemiyle gönderilmiştir.");
        }
        abstract public void MusteriTipi();
        abstract public void OdemeSekli();
        public void TemplateMethod()
        {
            Baslat();
            MusteriTipi();
            OdemeSekli();
            Bitir();
        }
    }

    class HavaleYontemi : ParaTransferi
    {
        public override void OdemeSekli()
        {
            odemeTipi = TransferTipi.Havale;
        }

        public override void MusteriTipi()
        {
            MusteriTuru = "Müşterimize ";
        }
    }

    class EFTYontemi : ParaTransferi
    {
        public override void OdemeSekli()
        {
            odemeTipi = TransferTipi.Eft;
        }

        public override void MusteriTipi()
        {
            MusteriTuru = "Müşterimiz Olmayan";
        }
    }
}
