using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //Receiver
    class KomutYonetimi
    {
        public void Cekme()
        {
            MessageBox.Show("Para Çekildi");
        }
        public void Yatirma()
        {
            MessageBox.Show("Para Yatirildi");
        }

    }

//command
    interface Iislem
    {
        void Execute();
    }
   //concreatecommand
    class ParaYatirma : Iislem
    {
        private KomutYonetimi _komutYonetimi;

        public ParaYatirma(KomutYonetimi komutYonetimi)
        {
            _komutYonetimi = komutYonetimi;
        }

        public void Execute()
        {
            _komutYonetimi.Yatirma();
        }
    }
    //concreatecommand
    class ParaCekme : Iislem
    {
        private KomutYonetimi _komutYonetimi;

        public ParaCekme(KomutYonetimi komutYonetimi)
        {
            _komutYonetimi = komutYonetimi;
        }

        public void Execute()
        {
            _komutYonetimi.Cekme();
        }
    }
    //Invoker
    class KomutKontrol
    {
        List<Iislem> _islemler = new List<Iislem>();
        public void islemAl(Iislem islem)
        {
            _islemler.Add(islem);
        }
        public void islemCalistir()
        {
            foreach (var islem in _islemler)
            {
                islem.Execute();
            }
            _islemler.Clear();
        }
    }
}
