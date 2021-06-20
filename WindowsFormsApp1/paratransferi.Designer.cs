namespace WindowsFormsApp1
{
    partial class frm_paratransferi
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
            this.grpKisiBilgileri = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.lbl_hesapno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_transfertutari = new System.Windows.Forms.TextBox();
            this.txt_yollanantc = new System.Windows.Forms.TextBox();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_yollananhesapno = new System.Windows.Forms.TextBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.grpKisiBilgileri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKisiBilgileri
            // 
            this.grpKisiBilgileri.Controls.Add(this.label4);
            this.grpKisiBilgileri.Controls.Add(this.lbl_11);
            this.grpKisiBilgileri.Controls.Add(this.label1);
            this.grpKisiBilgileri.Controls.Add(this.lbl_tc);
            this.grpKisiBilgileri.Controls.Add(this.lbl_soyisim);
            this.grpKisiBilgileri.Controls.Add(this.lbl_isim);
            this.grpKisiBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKisiBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpKisiBilgileri.Name = "grpKisiBilgileri";
            this.grpKisiBilgileri.Size = new System.Drawing.Size(289, 97);
            this.grpKisiBilgileri.TabIndex = 12;
            this.grpKisiBilgileri.TabStop = false;
            this.grpKisiBilgileri.Text = "Müşteri Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "TC:";
            // 
            // lbl_11
            // 
            this.lbl_11.AutoSize = true;
            this.lbl_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_11.Location = new System.Drawing.Point(6, 47);
            this.lbl_11.Name = "lbl_11";
            this.lbl_11.Size = new System.Drawing.Size(54, 18);
            this.lbl_11.TabIndex = 0;
            this.lbl_11.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(71, 71);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(22, 20);
            this.lbl_tc.TabIndex = 0;
            this.lbl_tc.Text = "tc";
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(71, 45);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(60, 20);
            this.lbl_soyisim.TabIndex = 0;
            this.lbl_soyisim.Text = "soyisim";
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(71, 22);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(38, 20);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "İsim";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl_3);
            this.groupBox1.Controls.Add(this.lbl_bakiye);
            this.groupBox1.Controls.Add(this.lbl_hesapno);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(308, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 97);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bakiye:";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_3.Location = new System.Drawing.Point(6, 22);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(79, 18);
            this.lbl_3.TabIndex = 0;
            this.lbl_3.Text = "Hesap No:";
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.Location = new System.Drawing.Point(87, 45);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(54, 20);
            this.lbl_bakiye.TabIndex = 0;
            this.lbl_bakiye.Text = "bakiye";
            // 
            // lbl_hesapno
            // 
            this.lbl_hesapno.AutoSize = true;
            this.lbl_hesapno.Location = new System.Drawing.Point(87, 22);
            this.lbl_hesapno.Name = "lbl_hesapno";
            this.lbl_hesapno.Size = new System.Drawing.Size(71, 20);
            this.lbl_hesapno.TabIndex = 0;
            this.lbl_hesapno.Text = "hesapno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(101, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Transfer Edilecek Tutar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Transfer Edilecek Kişinin TC\'si:";
            // 
            // txt_transfertutari
            // 
            this.txt_transfertutari.Location = new System.Drawing.Point(324, 122);
            this.txt_transfertutari.Name = "txt_transfertutari";
            this.txt_transfertutari.Size = new System.Drawing.Size(247, 20);
            this.txt_transfertutari.TabIndex = 15;
            this.txt_transfertutari.TextChanged += new System.EventHandler(this.frm_paratransferi_TextChanged);
            // 
            // txt_yollanantc
            // 
            this.txt_yollanantc.Location = new System.Drawing.Point(324, 170);
            this.txt_yollanantc.Name = "txt_yollanantc";
            this.txt_yollanantc.Size = new System.Drawing.Size(247, 20);
            this.txt_yollanantc.TabIndex = 2;
            // 
            // btn_onayla
            // 
            this.btn_onayla.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ok_button;
            this.btn_onayla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_onayla.Location = new System.Drawing.Point(242, 249);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(116, 39);
            this.btn_onayla.TabIndex = 4;
            this.btn_onayla.UseVisualStyleBackColor = true;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Trasfer Edilecek Kişinin Hesap No:";
            // 
            // txt_yollananhesapno
            // 
            this.txt_yollananhesapno.Location = new System.Drawing.Point(324, 214);
            this.txt_yollananhesapno.Name = "txt_yollananhesapno";
            this.txt_yollananhesapno.Size = new System.Drawing.Size(247, 20);
            this.txt_yollananhesapno.TabIndex = 3;
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.exit_signal;
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(495, 282);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(119, 35);
            this.btn_cikis.TabIndex = 6;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.left_arrow__1_;
            this.btn_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(12, 282);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(109, 35);
            this.btn_geri.TabIndex = 5;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // frm_paratransferi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.A;
            this.ClientSize = new System.Drawing.Size(626, 340);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_onayla);
            this.Controls.Add(this.txt_yollananhesapno);
            this.Controls.Add(this.txt_yollanantc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_transfertutari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpKisiBilgileri);
            this.Name = "frm_paratransferi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Transferi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_paratransferi_FormClosing);
            this.Load += new System.EventHandler(this.paratransferi_Load);
            this.grpKisiBilgileri.ResumeLayout(false);
            this.grpKisiBilgileri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKisiBilgileri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.Label lbl_hesapno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_transfertutari;
        private System.Windows.Forms.TextBox txt_yollanantc;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_yollananhesapno;
    }
}