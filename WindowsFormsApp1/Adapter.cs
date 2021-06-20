using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Target
    {
        public virtual void MusteriIslem()
        {
            MessageBox.Show("bankamızın müsterisi oldugunuz icin para kesimi olmayacak");
        }
    }


    class Adaptee
    {
        public void MusteriOlmayanIslem()
        {
            MessageBox.Show("bankamızın müsterisi olmadıgınız icin gerceklestirdiginiz islemlerden 5 tl kesim gerçekleşecektir.");
        }
    }



    class Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override void MusteriIslem()
        {
            _adaptee.MusteriOlmayanIslem();
        }

    }
}
