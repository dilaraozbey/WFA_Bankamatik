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
    public partial class dilarabank : Form
    {
        public dilarabank()
        {
            InitializeComponent();
        }

        private void dilarabank_FormClosing(object sender, FormClosingEventArgs e)
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_giris frm = new frm_giris();
            frm.Show();
        }
    }
}
