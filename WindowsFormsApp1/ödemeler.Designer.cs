namespace WindowsFormsApp1
{
    partial class frm_odemeler
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
            this.cmbbx_telefonodeme = new System.Windows.Forms.ComboBox();
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
            this.cmbbx_kartodemesi = new System.Windows.Forms.ComboBox();
            this.cmbbx_egitimodeme = new System.Windows.Forms.ComboBox();
            this.radio_egitimodemesi = new System.Windows.Forms.RadioButton();
            this.radio_kartodemesi = new System.Windows.Forms.RadioButton();
            this.radio_telefonodeme = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Odeme = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.grpKisiBilgileri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbbx_telefonodeme
            // 
            this.cmbbx_telefonodeme.FormattingEnabled = true;
            this.cmbbx_telefonodeme.Items.AddRange(new object[] {
            "ev telefonu faturası",
            "cep telefonu faturası"});
            this.cmbbx_telefonodeme.Location = new System.Drawing.Point(179, 14);
            this.cmbbx_telefonodeme.Name = "cmbbx_telefonodeme";
            this.cmbbx_telefonodeme.Size = new System.Drawing.Size(139, 21);
            this.cmbbx_telefonodeme.TabIndex = 2;
            this.cmbbx_telefonodeme.Text = "Seçim Yapınız";
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
            this.grpKisiBilgileri.Location = new System.Drawing.Point(12, 0);
            this.grpKisiBilgileri.Name = "grpKisiBilgileri";
            this.grpKisiBilgileri.Size = new System.Drawing.Size(289, 109);
            this.grpKisiBilgileri.TabIndex = 10;
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
            this.groupBox1.Location = new System.Drawing.Point(327, 12);
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
            // cmbbx_kartodemesi
            // 
            this.cmbbx_kartodemesi.FormattingEnabled = true;
            this.cmbbx_kartodemesi.Items.AddRange(new object[] {
            "Dönem Borcu Ödeme",
            "Tüm Borç Ödeme"});
            this.cmbbx_kartodemesi.Location = new System.Drawing.Point(179, 51);
            this.cmbbx_kartodemesi.Name = "cmbbx_kartodemesi";
            this.cmbbx_kartodemesi.Size = new System.Drawing.Size(139, 21);
            this.cmbbx_kartodemesi.TabIndex = 4;
            this.cmbbx_kartodemesi.Text = "Seçim Yapınız";
            // 
            // cmbbx_egitimodeme
            // 
            this.cmbbx_egitimodeme.FormattingEnabled = true;
            this.cmbbx_egitimodeme.Items.AddRange(new object[] {
            "Sınav Parası Yatırma",
            "KYK Borç Ödemesi",
            "KYK Yurt Parası Ödeme"});
            this.cmbbx_egitimodeme.Location = new System.Drawing.Point(179, 88);
            this.cmbbx_egitimodeme.Name = "cmbbx_egitimodeme";
            this.cmbbx_egitimodeme.Size = new System.Drawing.Size(139, 21);
            this.cmbbx_egitimodeme.TabIndex = 6;
            this.cmbbx_egitimodeme.Text = "Seçim Yapınız";
            // 
            // radio_egitimodemesi
            // 
            this.radio_egitimodemesi.AutoSize = true;
            this.radio_egitimodemesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_egitimodemesi.Location = new System.Drawing.Point(28, 92);
            this.radio_egitimodemesi.Name = "radio_egitimodemesi";
            this.radio_egitimodemesi.Size = new System.Drawing.Size(103, 17);
            this.radio_egitimodemesi.TabIndex = 5;
            this.radio_egitimodemesi.TabStop = true;
            this.radio_egitimodemesi.Text = "Eğitim Ödemeleri";
            this.radio_egitimodemesi.UseVisualStyleBackColor = true;
            this.radio_egitimodemesi.CheckedChanged += new System.EventHandler(this.radio_egitimodemesi_CheckedChanged);
            // 
            // radio_kartodemesi
            // 
            this.radio_kartodemesi.AutoSize = true;
            this.radio_kartodemesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_kartodemesi.Location = new System.Drawing.Point(28, 51);
            this.radio_kartodemesi.Name = "radio_kartodemesi";
            this.radio_kartodemesi.Size = new System.Drawing.Size(119, 17);
            this.radio_kartodemesi.TabIndex = 3;
            this.radio_kartodemesi.TabStop = true;
            this.radio_kartodemesi.Text = "Kart Borcu Ödemesi";
            this.radio_kartodemesi.UseVisualStyleBackColor = true;
            this.radio_kartodemesi.CheckedChanged += new System.EventHandler(this.radio_kartodemesi_CheckedChanged);
            // 
            // radio_telefonodeme
            // 
            this.radio_telefonodeme.AutoSize = true;
            this.radio_telefonodeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radio_telefonodeme.Location = new System.Drawing.Point(28, 14);
            this.radio_telefonodeme.Name = "radio_telefonodeme";
            this.radio_telefonodeme.Size = new System.Drawing.Size(138, 17);
            this.radio_telefonodeme.TabIndex = 21;
            this.radio_telefonodeme.TabStop = true;
            this.radio_telefonodeme.Text = "Telefon Faturası Ödeme";
            this.radio_telefonodeme.UseVisualStyleBackColor = true;
            this.radio_telefonodeme.CheckedChanged += new System.EventHandler(this.radio_telefonodeme_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radio_egitimodemesi);
            this.panel1.Controls.Add(this.radio_kartodemesi);
            this.panel1.Controls.Add(this.radio_telefonodeme);
            this.panel1.Controls.Add(this.cmbbx_egitimodeme);
            this.panel1.Controls.Add(this.cmbbx_kartodemesi);
            this.panel1.Controls.Add(this.cmbbx_telefonodeme);
            this.panel1.Location = new System.Drawing.Point(126, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 125);
            this.panel1.TabIndex = 20;
            // 
            // btn_Odeme
            // 
            this.btn_Odeme.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Odeme.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.payment_method1;
            this.btn_Odeme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Odeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Odeme.Location = new System.Drawing.Point(252, 246);
            this.btn_Odeme.Name = "btn_Odeme";
            this.btn_Odeme.Size = new System.Drawing.Size(125, 45);
            this.btn_Odeme.TabIndex = 7;
            this.btn_Odeme.UseVisualStyleBackColor = false;
            this.btn_Odeme.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.exit_signal;
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(482, 284);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(119, 35);
            this.btn_cikis.TabIndex = 9;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click_1);
            // 
            // btn_geri
            // 
            this.btn_geri.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.left_arrow__1_;
            this.btn_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(12, 284);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(93, 35);
            this.btn_geri.TabIndex = 8;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // frm_odemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.A;
            this.ClientSize = new System.Drawing.Size(626, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Odeme);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpKisiBilgileri);
            this.Name = "frm_odemeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ödemeler";
            this.Load += new System.EventHandler(this.frm_odemeler_Load);
            this.grpKisiBilgileri.ResumeLayout(false);
            this.grpKisiBilgileri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbbx_telefonodeme;
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
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_Odeme;
        private System.Windows.Forms.ComboBox cmbbx_kartodemesi;
        private System.Windows.Forms.ComboBox cmbbx_egitimodeme;
        private System.Windows.Forms.RadioButton radio_egitimodemesi;
        private System.Windows.Forms.RadioButton radio_kartodemesi;
        private System.Windows.Forms.RadioButton radio_telefonodeme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cikis;
    }
}