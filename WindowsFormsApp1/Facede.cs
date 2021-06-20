using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Sistem1Kontrol
    {
        public bool FaturaKontrol(string Tc)
        {
            if (Tc != "yok")
            {
                return false;
            }
            else
            {
                return true;
            }
            //tcye ait fatura kontrol
            
        }
    }

    public class Sistem2Operations
    {
        public void ÖdemeTransfer(string faturatipi)
        {
            MessageBox.Show(faturatipi);
        }
    }
    public class TcKimlikSistem
    {
        public bool Kontrol(string Tc)
        {
            //tc kimlik  kontrol
            return true;
        }
    }
    public class Facade
    {

        TcKimlikSistem TcSistem = new TcKimlikSistem();
        Sistem1Kontrol Sistem1 = new Sistem1Kontrol();
        Sistem2Operations Sistem2 = new Sistem2Operations();

        public void Transfer_Gerceklestir(string Tc)
        {
            if (TcSistem.Kontrol(Tc) && !Sistem1.FaturaKontrol(Tc))
            {
                Sistem2.ÖdemeTransfer(Tc);
            }
            else
            {
                Sistem2.ÖdemeTransfer("Odeme Bulunamadı!.");
            }
        }
    }
}
