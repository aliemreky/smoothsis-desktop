namespace smoothsis
{
    partial class stokOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stokOlustur));
            this.btnStokKodOlustur = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmbalajBilgi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEtiketBilgi = new System.Windows.Forms.TextBox();
            this.txtMalzOlcu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMalzSerisi = new System.Windows.Forms.TextBox();
            this.txtMalzCinsi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStokAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.kaydetBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.temizleBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iptalButton = new System.Windows.Forms.ToolStripButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStokKod = new System.Windows.Forms.TextBox();
            this.dtpGelisTarih = new System.Windows.Forms.DateTimePicker();
            this.cbMiktarBirim = new System.Windows.Forms.ComboBox();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStokKodOlustur
            // 
            this.btnStokKodOlustur.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStokKodOlustur.Location = new System.Drawing.Point(316, 40);
            this.btnStokKodOlustur.Name = "btnStokKodOlustur";
            this.btnStokKodOlustur.Size = new System.Drawing.Size(99, 23);
            this.btnStokKodOlustur.TabIndex = 13;
            this.btnStokKodOlustur.TabStop = false;
            this.btnStokKodOlustur.Text = "KOD OLUSTUR";
            this.btnStokKodOlustur.UseVisualStyleBackColor = true;
            this.btnStokKodOlustur.Click += new System.EventHandler(this.btnStokKodOlustur_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBirimFiyat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMiktarBirim);
            this.groupBox1.Controls.Add(this.dtpGelisTarih);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAmbalajBilgi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtEtiketBilgi);
            this.groupBox1.Controls.Add(this.txtMalzOlcu);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMalzSerisi);
            this.groupBox1.Controls.Add(this.txtMalzCinsi);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtStokAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 264);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(496, 142);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(263, 89);
            this.txtAciklama.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(424, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "AÇIKLAMA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "BİRİM *";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(112, 69);
            this.txtMiktar.Multiline = true;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(132, 23);
            this.txtMiktar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(48, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "MİKTAR *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "AMBALAJ BİLGİ";
            // 
            // txtAmbalajBilgi
            // 
            this.txtAmbalajBilgi.AcceptsReturn = true;
            this.txtAmbalajBilgi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmbalajBilgi.Location = new System.Drawing.Point(112, 174);
            this.txtAmbalajBilgi.Multiline = true;
            this.txtAmbalajBilgi.Name = "txtAmbalajBilgi";
            this.txtAmbalajBilgi.Size = new System.Drawing.Size(263, 23);
            this.txtAmbalajBilgi.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "GELİŞ TARİHİ";
            // 
            // txtEtiketBilgi
            // 
            this.txtEtiketBilgi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEtiketBilgi.Location = new System.Drawing.Point(496, 108);
            this.txtEtiketBilgi.Multiline = true;
            this.txtEtiketBilgi.Name = "txtEtiketBilgi";
            this.txtEtiketBilgi.Size = new System.Drawing.Size(263, 23);
            this.txtEtiketBilgi.TabIndex = 11;
            // 
            // txtMalzOlcu
            // 
            this.txtMalzOlcu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMalzOlcu.Location = new System.Drawing.Point(496, 71);
            this.txtMalzOlcu.Multiline = true;
            this.txtMalzOlcu.Name = "txtMalzOlcu";
            this.txtMalzOlcu.Size = new System.Drawing.Size(263, 23);
            this.txtMalzOlcu.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(414, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "ETİKET BİLGİ";
            // 
            // txtMalzSerisi
            // 
            this.txtMalzSerisi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMalzSerisi.Location = new System.Drawing.Point(112, 209);
            this.txtMalzSerisi.Multiline = true;
            this.txtMalzSerisi.Name = "txtMalzSerisi";
            this.txtMalzSerisi.Size = new System.Drawing.Size(263, 23);
            this.txtMalzSerisi.TabIndex = 8;
            // 
            // txtMalzCinsi
            // 
            this.txtMalzCinsi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMalzCinsi.Location = new System.Drawing.Point(496, 35);
            this.txtMalzCinsi.Multiline = true;
            this.txtMalzCinsi.Name = "txtMalzCinsi";
            this.txtMalzCinsi.Size = new System.Drawing.Size(263, 23);
            this.txtMalzCinsi.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(6, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "MALZEME SERİSİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(395, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "MALZEME ÖLÇÜ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(394, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "MALZEME CİNSİ";
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokAdi.Location = new System.Drawing.Point(112, 33);
            this.txtStokAdi.Multiline = true;
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(263, 23);
            this.txtStokAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOK ADI *";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetBttn,
            this.toolStripSeparator1,
            this.temizleBttn,
            this.toolStripSeparator2,
            this.iptalButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(795, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // kaydetBttn
            // 
            this.kaydetBttn.Image = ((System.Drawing.Image)(resources.GetObject("kaydetBttn.Image")));
            this.kaydetBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kaydetBttn.Name = "kaydetBttn";
            this.kaydetBttn.Size = new System.Drawing.Size(70, 20);
            this.kaydetBttn.Text = "Kaydet";
            this.kaydetBttn.ToolTipText = "Değişiklikleri Kaydet";
            this.kaydetBttn.Click += new System.EventHandler(this.kaydetBttn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // temizleBttn
            // 
            this.temizleBttn.Image = ((System.Drawing.Image)(resources.GetObject("temizleBttn.Image")));
            this.temizleBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.temizleBttn.Name = "temizleBttn";
            this.temizleBttn.Size = new System.Drawing.Size(76, 20);
            this.temizleBttn.Text = "Temizle";
            this.temizleBttn.Click += new System.EventHandler(this.temizleBttn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // iptalButton
            // 
            this.iptalButton.Image = ((System.Drawing.Image)(resources.GetObject("iptalButton.Image")));
            this.iptalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(57, 20);
            this.iptalButton.Text = "Çıkış";
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(41, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "STOK KODU *";
            // 
            // txtStokKod
            // 
            this.txtStokKod.Enabled = false;
            this.txtStokKod.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokKod.Location = new System.Drawing.Point(124, 40);
            this.txtStokKod.Multiline = true;
            this.txtStokKod.Name = "txtStokKod";
            this.txtStokKod.ReadOnly = true;
            this.txtStokKod.Size = new System.Drawing.Size(186, 23);
            this.txtStokKod.TabIndex = 15;
            // 
            // dtpGelisTarih
            // 
            this.dtpGelisTarih.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGelisTarih.Location = new System.Drawing.Point(112, 137);
            this.dtpGelisTarih.MinimumSize = new System.Drawing.Size(0, 23);
            this.dtpGelisTarih.Name = "dtpGelisTarih";
            this.dtpGelisTarih.Size = new System.Drawing.Size(263, 23);
            this.dtpGelisTarih.TabIndex = 13;
            // 
            // cbMiktarBirim
            // 
            this.cbMiktarBirim.FormattingEnabled = true;
            this.cbMiktarBirim.Location = new System.Drawing.Point(298, 71);
            this.cbMiktarBirim.Name = "cbMiktarBirim";
            this.cbMiktarBirim.Size = new System.Drawing.Size(77, 21);
            this.cbMiktarBirim.TabIndex = 14;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimFiyat.Location = new System.Drawing.Point(112, 103);
            this.txtBirimFiyat.Multiline = true;
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(263, 23);
            this.txtBirimFiyat.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "BİRİM FİYAT *";
            // 
            // stokOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(795, 362);
            this.Controls.Add(this.btnStokKodOlustur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtStokKod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "stokOlustur";
            this.Text = "SMOOTHSIS [ STOK KAYDI OLUŞTUR ]";
            this.Load += new System.EventHandler(this.stokOlustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStokKodOlustur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmbalajBilgi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEtiketBilgi;
        private System.Windows.Forms.TextBox txtMalzOlcu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMalzSerisi;
        private System.Windows.Forms.TextBox txtMalzCinsi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStokAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton kaydetBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton temizleBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton iptalButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStokKod;
        private System.Windows.Forms.DateTimePicker dtpGelisTarih;
        private System.Windows.Forms.ComboBox cbMiktarBirim;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label2;
    }
}