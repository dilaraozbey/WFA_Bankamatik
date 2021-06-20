namespace WindowsFormsApp1
{
    partial class frm_giris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_tcmusteri = new System.Windows.Forms.Label();
            this.lbl_sifremusteri = new System.Windows.Forms.Label();
            this.txt_tcmusteri = new System.Windows.Forms.TextBox();
            this.txt_sifremusteri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblsaat = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_giris = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_tcmusteri
            // 
            this.lbl_tcmusteri.AutoSize = true;
            this.lbl_tcmusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tcmusteri.Location = new System.Drawing.Point(46, 121);
            this.lbl_tcmusteri.Name = "lbl_tcmusteri";
            this.lbl_tcmusteri.Size = new System.Drawing.Size(164, 18);
            this.lbl_tcmusteri.TabIndex = 5;
            this.lbl_tcmusteri.Text = "TC KİMLİK NUMARASI:";
            // 
            // lbl_sifremusteri
            // 
            this.lbl_sifremusteri.AutoSize = true;
            this.lbl_sifremusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifremusteri.Location = new System.Drawing.Point(155, 184);
            this.lbl_sifremusteri.Name = "lbl_sifremusteri";
            this.lbl_sifremusteri.Size = new System.Drawing.Size(55, 18);
            this.lbl_sifremusteri.TabIndex = 5;
            this.lbl_sifremusteri.Text = "ŞİFRE:";
            // 
            // txt_tcmusteri
            // 
            this.txt_tcmusteri.Location = new System.Drawing.Point(216, 121);
            this.txt_tcmusteri.Name = "txt_tcmusteri";
            this.txt_tcmusteri.Size = new System.Drawing.Size(203, 20);
            this.txt_tcmusteri.TabIndex = 1;
            this.txt_tcmusteri.TextChanged += new System.EventHandler(this.txt_tcmusteri_TextChanged);
            // 
            // txt_sifremusteri
            // 
            this.txt_sifremusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifremusteri.Location = new System.Drawing.Point(216, 181);
            this.txt_sifremusteri.Name = "txt_sifremusteri";
            this.txt_sifremusteri.PasswordChar = '❤';
            this.txt_sifremusteri.Size = new System.Drawing.Size(203, 24);
            this.txt_sifremusteri.TabIndex = 2;
            this.txt_sifremusteri.TextChanged += new System.EventHandler(this.txt_sifremusteri_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(179, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "HOŞGELDİNİZ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Indigo;
            this.linkLabel1.Location = new System.Drawing.Point(23, 277);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.dilarabank.com.tr";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.Location = new System.Drawing.Point(53, 8);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(37, 13);
            this.lblsaat.TabIndex = 10;
            this.lblsaat.Text = "lblsaat";
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.Location = new System.Drawing.Point(55, 34);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(37, 13);
            this.lbltarih.TabIndex = 10;
            this.lbltarih.Text = "lbltarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Saat :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tarih :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblsaat);
            this.panel1.Controls.Add(this.lbltarih);
            this.panel1.Location = new System.Drawing.Point(446, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 54);
            this.panel1.TabIndex = 21;
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.Color.Indigo;
            this.btn_giris.Location = new System.Drawing.Point(237, 227);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(102, 35);
            this.btn_giris.TabIndex = 3;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_onaylamusteri_Click);
            // 
            // frm_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.A;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 305);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_sifremusteri);
            this.Controls.Add(this.txt_tcmusteri);
            this.Controls.Add(this.lbl_sifremusteri);
            this.Controls.Add(this.lbl_tcmusteri);
            this.Name = "frm_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_giris_FormClosing);
            this.Load += new System.EventHandler(this.frm_musteri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_tcmusteri;
        private System.Windows.Forms.Label lbl_sifremusteri;
        private System.Windows.Forms.TextBox txt_tcmusteri;
        private System.Windows.Forms.TextBox txt_sifremusteri;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}