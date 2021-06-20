namespace WindowsFormsApp1
{
    partial class frm_hesapici
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
            this.btn_parayatırma = new System.Windows.Forms.Button();
            this.btn_paracekme = new System.Windows.Forms.Button();
            this.btn_paratransferi = new System.Windows.Forms.Button();
            this.btn_odemeler = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
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
            this.grpKisiBilgileri.Size = new System.Drawing.Size(289, 109);
            this.grpKisiBilgileri.TabIndex = 9;
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
            this.label4.Click += new System.EventHandler(this.label1_Click);
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
            this.lbl_11.Click += new System.EventHandler(this.label1_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(71, 71);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(22, 20);
            this.lbl_tc.TabIndex = 0;
            this.lbl_tc.Text = "tc";
            this.lbl_tc.Click += new System.EventHandler(this.lbl_tc_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(339, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 109);
            this.groupBox1.TabIndex = 9;
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
            // btn_parayatırma
            // 
            this.btn_parayatırma.Location = new System.Drawing.Point(125, 147);
            this.btn_parayatırma.Name = "btn_parayatırma";
            this.btn_parayatırma.Size = new System.Drawing.Size(176, 53);
            this.btn_parayatırma.TabIndex = 1;
            this.btn_parayatırma.Text = "PARA YATIRMA";
            this.btn_parayatırma.UseVisualStyleBackColor = true;
            this.btn_parayatırma.Click += new System.EventHandler(this.btn_parayatırma_Click);
            // 
            // btn_paracekme
            // 
            this.btn_paracekme.Location = new System.Drawing.Point(339, 147);
            this.btn_paracekme.Name = "btn_paracekme";
            this.btn_paracekme.Size = new System.Drawing.Size(176, 53);
            this.btn_paracekme.TabIndex = 2;
            this.btn_paracekme.Text = "PARA ÇEKME";
            this.btn_paracekme.UseVisualStyleBackColor = true;
            this.btn_paracekme.Click += new System.EventHandler(this.btn_paracekme_Click);
            // 
            // btn_paratransferi
            // 
            this.btn_paratransferi.Location = new System.Drawing.Point(339, 225);
            this.btn_paratransferi.Name = "btn_paratransferi";
            this.btn_paratransferi.Size = new System.Drawing.Size(176, 53);
            this.btn_paratransferi.TabIndex = 4;
            this.btn_paratransferi.Text = "PARA TRANSFERİ";
            this.btn_paratransferi.UseVisualStyleBackColor = true;
            this.btn_paratransferi.Click += new System.EventHandler(this.btn_paratransferi_Click);
            // 
            // btn_odemeler
            // 
            this.btn_odemeler.Location = new System.Drawing.Point(125, 225);
            this.btn_odemeler.Name = "btn_odemeler";
            this.btn_odemeler.Size = new System.Drawing.Size(176, 53);
            this.btn_odemeler.TabIndex = 3;
            this.btn_odemeler.Text = "ÖDEMELER";
            this.btn_odemeler.UseVisualStyleBackColor = true;
            this.btn_odemeler.Click += new System.EventHandler(this.btn_odemeler_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.exit_signal;
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.Location = new System.Drawing.Point(500, 306);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(130, 37);
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // frm_hesapici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.A;
            this.ClientSize = new System.Drawing.Size(642, 355);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_odemeler);
            this.Controls.Add(this.btn_paratransferi);
            this.Controls.Add(this.btn_paracekme);
            this.Controls.Add(this.btn_parayatırma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpKisiBilgileri);
            this.Name = "frm_hesapici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hesapici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_hesapici_FormClosing);
            this.Load += new System.EventHandler(this.frm_hesapici_Load);
            this.grpKisiBilgileri.ResumeLayout(false);
            this.grpKisiBilgileri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKisiBilgileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_hesapno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Button btn_parayatırma;
        private System.Windows.Forms.Button btn_paracekme;
        private System.Windows.Forms.Button btn_paratransferi;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label lbl_11;
        private System.Windows.Forms.Button btn_odemeler;
    }
}