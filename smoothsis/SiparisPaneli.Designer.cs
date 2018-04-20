namespace smoothsis
{
    partial class SiparisPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisPaneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.siparisTipi = new System.Windows.Forms.ComboBox();
            this.btnCariListeAc = new System.Windows.Forms.Button();
            this.btnSiparisKoduOlustur = new System.Windows.Forms.Button();
            this.txtSiparisTeslimTarih = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSiparisTarih = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCariKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSiparisKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.kaydetBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iptalButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSiparis = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAciklama2 = new System.Windows.Forms.TextBox();
            this.txtAciklama1 = new System.Windows.Forms.TextBox();
            this.txtProjeAdi = new System.Windows.Forms.TextBox();
            this.txtOzelKod = new System.Windows.Forms.TextBox();
            this.txtProjeKodu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIlIlce = new System.Windows.Forms.TextBox();
            this.txtTicariUnvan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCariIsim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabStok = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.siparisListesiGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbStokDepo = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnListeyeEkle = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.btnStokListesi = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtStokBirim = new System.Windows.Forms.TextBox();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStokMiktar = new System.Windows.Forms.TextBox();
            this.txtStokAdi = new System.Windows.Forms.TextBox();
            this.txtStokKodu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSiparis.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabStok.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siparisListesiGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.siparisTipi);
            this.groupBox1.Controls.Add(this.btnCariListeAc);
            this.groupBox1.Controls.Add(this.btnSiparisKoduOlustur);
            this.groupBox1.Controls.Add(this.txtSiparisTeslimTarih);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSiparisTarih);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCariKod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSiparisKodu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SİPARİŞ İŞLEMLERİ";
            // 
            // siparisTipi
            // 
            this.siparisTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siparisTipi.FormattingEnabled = true;
            this.siparisTipi.Items.AddRange(new object[] {
            "YURT İÇİ",
            "YURT DIŞI"});
            this.siparisTipi.Location = new System.Drawing.Point(9, 298);
            this.siparisTipi.Name = "siparisTipi";
            this.siparisTipi.Size = new System.Drawing.Size(195, 23);
            this.siparisTipi.TabIndex = 6;
            // 
            // btnCariListeAc
            // 
            this.btnCariListeAc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCariListeAc.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCariListeAc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCariListeAc.Image = ((System.Drawing.Image)(resources.GetObject("btnCariListeAc.Image")));
            this.btnCariListeAc.Location = new System.Drawing.Point(209, 110);
            this.btnCariListeAc.Name = "btnCariListeAc";
            this.btnCariListeAc.Size = new System.Drawing.Size(31, 25);
            this.btnCariListeAc.TabIndex = 4;
            this.btnCariListeAc.UseVisualStyleBackColor = true;
            this.btnCariListeAc.Click += new System.EventHandler(this.btnCariListeAc_Click);
            // 
            // btnSiparisKoduOlustur
            // 
            this.btnSiparisKoduOlustur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSiparisKoduOlustur.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSiparisKoduOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisKoduOlustur.Image = ((System.Drawing.Image)(resources.GetObject("btnSiparisKoduOlustur.Image")));
            this.btnSiparisKoduOlustur.Location = new System.Drawing.Point(209, 53);
            this.btnSiparisKoduOlustur.Name = "btnSiparisKoduOlustur";
            this.btnSiparisKoduOlustur.Size = new System.Drawing.Size(31, 25);
            this.btnSiparisKoduOlustur.TabIndex = 2;
            this.btnSiparisKoduOlustur.UseVisualStyleBackColor = true;
            this.btnSiparisKoduOlustur.Click += new System.EventHandler(this.btnSiparisKoduOlustur_Click);
            // 
            // txtSiparisTeslimTarih
            // 
            this.txtSiparisTeslimTarih.Location = new System.Drawing.Point(9, 234);
            this.txtSiparisTeslimTarih.Name = "txtSiparisTeslimTarih";
            this.txtSiparisTeslimTarih.Size = new System.Drawing.Size(195, 23);
            this.txtSiparisTeslimTarih.TabIndex = 5;
            this.txtSiparisTeslimTarih.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSiparisTeslimTarih_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sipariş Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Teslim Tarihi";
            // 
            // txtSiparisTarih
            // 
            this.txtSiparisTarih.Location = new System.Drawing.Point(9, 169);
            this.txtSiparisTarih.Name = "txtSiparisTarih";
            this.txtSiparisTarih.Size = new System.Drawing.Size(195, 23);
            this.txtSiparisTarih.TabIndex = 4;
            this.txtSiparisTarih.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSiparisTarih_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sipariş Tarihi";
            // 
            // txtCariKod
            // 
            this.txtCariKod.Location = new System.Drawing.Point(9, 111);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Size = new System.Drawing.Size(195, 23);
            this.txtCariKod.TabIndex = 3;
            this.txtCariKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCariKod_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari Kod";
            // 
            // txtSiparisKodu
            // 
            this.txtSiparisKodu.Location = new System.Drawing.Point(9, 54);
            this.txtSiparisKodu.Name = "txtSiparisKodu";
            this.txtSiparisKodu.Size = new System.Drawing.Size(195, 23);
            this.txtSiparisKodu.TabIndex = 0;
            this.txtSiparisKodu.TabStop = false;
            this.txtSiparisKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSiparisKodu_KeyPress);
            this.txtSiparisKodu.Leave += new System.EventHandler(this.txtSiparisKodu_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş Kodu";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetBttn,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.iptalButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(955, 25);
            this.toolStrip1.TabIndex = 13;
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
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(76, 20);
            this.toolStripButton1.Text = "Temizle";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSiparis);
            this.tabControl1.Controls.Add(this.tabStok);
            this.tabControl1.Location = new System.Drawing.Point(8, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 486);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabSiparis
            // 
            this.tabSiparis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabSiparis.Controls.Add(this.groupBox3);
            this.tabSiparis.Controls.Add(this.groupBox2);
            this.tabSiparis.Controls.Add(this.groupBox1);
            this.tabSiparis.Location = new System.Drawing.Point(4, 24);
            this.tabSiparis.Name = "tabSiparis";
            this.tabSiparis.Padding = new System.Windows.Forms.Padding(3);
            this.tabSiparis.Size = new System.Drawing.Size(939, 458);
            this.tabSiparis.TabIndex = 0;
            this.tabSiparis.Text = "Sipariş Bilgisi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtAciklama2);
            this.groupBox3.Controls.Add(this.txtAciklama1);
            this.groupBox3.Controls.Add(this.txtProjeAdi);
            this.groupBox3.Controls.Add(this.txtOzelKod);
            this.groupBox3.Controls.Add(this.txtProjeKodu);
            this.groupBox3.Location = new System.Drawing.Point(269, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(662, 259);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EK BİLGİLER";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(34, 211);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 15);
            this.label19.TabIndex = 0;
            this.label19.Text = "Açıklama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Açıklama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Proje Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Özel Kod";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Proje Kodu";
            // 
            // txtAciklama2
            // 
            this.txtAciklama2.Location = new System.Drawing.Point(110, 208);
            this.txtAciklama2.Multiline = true;
            this.txtAciklama2.Name = "txtAciklama2";
            this.txtAciklama2.Size = new System.Drawing.Size(533, 34);
            this.txtAciklama2.TabIndex = 10;
            // 
            // txtAciklama1
            // 
            this.txtAciklama1.Location = new System.Drawing.Point(110, 154);
            this.txtAciklama1.Multiline = true;
            this.txtAciklama1.Name = "txtAciklama1";
            this.txtAciklama1.Size = new System.Drawing.Size(533, 34);
            this.txtAciklama1.TabIndex = 10;
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.Location = new System.Drawing.Point(110, 111);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Size = new System.Drawing.Size(533, 23);
            this.txtProjeAdi.TabIndex = 9;
            // 
            // txtOzelKod
            // 
            this.txtOzelKod.Location = new System.Drawing.Point(110, 32);
            this.txtOzelKod.Name = "txtOzelKod";
            this.txtOzelKod.Size = new System.Drawing.Size(533, 23);
            this.txtOzelKod.TabIndex = 7;
            // 
            // txtProjeKodu
            // 
            this.txtProjeKodu.Location = new System.Drawing.Point(110, 72);
            this.txtProjeKodu.Name = "txtProjeKodu";
            this.txtProjeKodu.Size = new System.Drawing.Size(533, 23);
            this.txtProjeKodu.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIlIlce);
            this.groupBox2.Controls.Add(this.txtTicariUnvan);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtCariIsim);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(269, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 163);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CARİ BİLGİSİ";
            // 
            // txtIlIlce
            // 
            this.txtIlIlce.Enabled = false;
            this.txtIlIlce.Location = new System.Drawing.Point(110, 108);
            this.txtIlIlce.Name = "txtIlIlce";
            this.txtIlIlce.ReadOnly = true;
            this.txtIlIlce.Size = new System.Drawing.Size(533, 23);
            this.txtIlIlce.TabIndex = 0;
            this.txtIlIlce.TabStop = false;
            // 
            // txtTicariUnvan
            // 
            this.txtTicariUnvan.Enabled = false;
            this.txtTicariUnvan.Location = new System.Drawing.Point(110, 66);
            this.txtTicariUnvan.Name = "txtTicariUnvan";
            this.txtTicariUnvan.ReadOnly = true;
            this.txtTicariUnvan.Size = new System.Drawing.Size(533, 23);
            this.txtTicariUnvan.TabIndex = 0;
            this.txtTicariUnvan.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "İl / İlçe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ticari Ünvan";
            // 
            // txtCariIsim
            // 
            this.txtCariIsim.Enabled = false;
            this.txtCariIsim.Location = new System.Drawing.Point(110, 29);
            this.txtCariIsim.Name = "txtCariIsim";
            this.txtCariIsim.ReadOnly = true;
            this.txtCariIsim.Size = new System.Drawing.Size(533, 23);
            this.txtCariIsim.TabIndex = 0;
            this.txtCariIsim.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cari İsim";
            // 
            // tabStok
            // 
            this.tabStok.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabStok.Controls.Add(this.groupBox5);
            this.tabStok.Controls.Add(this.groupBox4);
            this.tabStok.Location = new System.Drawing.Point(4, 24);
            this.tabStok.Name = "tabStok";
            this.tabStok.Padding = new System.Windows.Forms.Padding(3);
            this.tabStok.Size = new System.Drawing.Size(939, 458);
            this.tabStok.TabIndex = 1;
            this.tabStok.Text = "Kalemler";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.siparisListesiGridView);
            this.groupBox5.Location = new System.Drawing.Point(12, 151);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(909, 301);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // siparisListesiGridView
            // 
            this.siparisListesiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siparisListesiGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.siparisListesiGridView.Location = new System.Drawing.Point(9, 18);
            this.siparisListesiGridView.MultiSelect = false;
            this.siparisListesiGridView.Name = "siparisListesiGridView";
            this.siparisListesiGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.siparisListesiGridView.Size = new System.Drawing.Size(891, 293);
            this.siparisListesiGridView.TabIndex = 2;
            this.siparisListesiGridView.TabStop = false;
            this.siparisListesiGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.siparisListesiGridView_CellDoubleClick);
            this.siparisListesiGridView.CurrentCellChanged += new System.EventHandler(this.siparisListesiGridView_CurrentCellChanged);
            this.siparisListesiGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.siparisListesiGridView_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.cbStokDepo);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.btnListeyeEkle);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.txtToplamFiyat);
            this.groupBox4.Controls.Add(this.btnStokListesi);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtStokBirim);
            this.groupBox4.Controls.Add(this.txtBirimFiyat);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtStokMiktar);
            this.groupBox4.Controls.Add(this.txtStokAdi);
            this.groupBox4.Controls.Add(this.txtStokKodu);
            this.groupBox4.Location = new System.Drawing.Point(12, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(909, 139);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(406, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 20);
            this.label21.TabIndex = 8;
            this.label21.Text = "TL";
            // 
            // cbStokDepo
            // 
            this.cbStokDepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStokDepo.FormattingEnabled = true;
            this.cbStokDepo.Location = new System.Drawing.Point(10, 93);
            this.cbStokDepo.Name = "cbStokDepo";
            this.cbStokDepo.Size = new System.Drawing.Size(172, 23);
            this.cbStokDepo.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 15);
            this.label20.TabIndex = 6;
            this.label20.Text = "Depo";
            // 
            // btnListeyeEkle
            // 
            this.btnListeyeEkle.Location = new System.Drawing.Point(447, 88);
            this.btnListeyeEkle.Name = "btnListeyeEkle";
            this.btnListeyeEkle.Size = new System.Drawing.Size(124, 31);
            this.btnListeyeEkle.TabIndex = 5;
            this.btnListeyeEkle.Text = "LİSTEYE EKLE";
            this.btnListeyeEkle.UseVisualStyleBackColor = true;
            this.btnListeyeEkle.Click += new System.EventHandler(this.btnListeyeEkle_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(198, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "TOPLAM TUTAR";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.BackColor = System.Drawing.Color.Honeydew;
            this.txtToplamFiyat.Enabled = false;
            this.txtToplamFiyat.Location = new System.Drawing.Point(201, 93);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.ReadOnly = true;
            this.txtToplamFiyat.Size = new System.Drawing.Size(199, 23);
            this.txtToplamFiyat.TabIndex = 0;
            this.txtToplamFiyat.TabStop = false;
            this.txtToplamFiyat.TextChanged += new System.EventHandler(this.txtToplamFiyat_TextChanged);
            // 
            // btnStokListesi
            // 
            this.btnStokListesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStokListesi.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnStokListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokListesi.Image = ((System.Drawing.Image)(resources.GetObject("btnStokListesi.Image")));
            this.btnStokListesi.Location = new System.Drawing.Point(151, 36);
            this.btnStokListesi.Name = "btnStokListesi";
            this.btnStokListesi.Size = new System.Drawing.Size(31, 25);
            this.btnStokListesi.TabIndex = 2;
            this.btnStokListesi.UseVisualStyleBackColor = true;
            this.btnStokListesi.Click += new System.EventHandler(this.btnStokListesi_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(666, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "Birim";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(760, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 15);
            this.label16.TabIndex = 2;
            this.label16.Text = "Birim Fiyatı";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(530, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 15);
            this.label15.TabIndex = 2;
            this.label15.Text = "Miktar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(198, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Stok Adı";
            // 
            // txtStokBirim
            // 
            this.txtStokBirim.Enabled = false;
            this.txtStokBirim.Location = new System.Drawing.Point(669, 38);
            this.txtStokBirim.Name = "txtStokBirim";
            this.txtStokBirim.ReadOnly = true;
            this.txtStokBirim.Size = new System.Drawing.Size(82, 23);
            this.txtStokBirim.TabIndex = 0;
            this.txtStokBirim.TabStop = false;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Enabled = false;
            this.txtBirimFiyat.Location = new System.Drawing.Point(763, 38);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.ReadOnly = true;
            this.txtBirimFiyat.Size = new System.Drawing.Size(134, 23);
            this.txtBirimFiyat.TabIndex = 0;
            this.txtBirimFiyat.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Stok Kodu";
            // 
            // txtStokMiktar
            // 
            this.txtStokMiktar.Location = new System.Drawing.Point(533, 38);
            this.txtStokMiktar.Name = "txtStokMiktar";
            this.txtStokMiktar.Size = new System.Drawing.Size(125, 23);
            this.txtStokMiktar.TabIndex = 4;
            this.txtStokMiktar.TextChanged += new System.EventHandler(this.txtStokMiktar_TextChanged);
            this.txtStokMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStokMiktar_KeyPress);
            this.txtStokMiktar.Leave += new System.EventHandler(this.txtStokMiktar_Leave);
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(201, 38);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.ReadOnly = true;
            this.txtStokAdi.Size = new System.Drawing.Size(318, 23);
            this.txtStokAdi.TabIndex = 3;
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(10, 38);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(135, 23);
            this.txtStokKodu.TabIndex = 1;
            this.txtStokKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStokKodu_KeyPress);
            // 
            // SiparisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(955, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SiparisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMOOTHSIS [ SİPARİŞ PANELİ ]";
            this.Load += new System.EventHandler(this.SiparisOlustur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSiparis.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabStok.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siparisListesiGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton kaydetBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton iptalButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSiparis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabStok;
        private System.Windows.Forms.Button btnSiparisKoduOlustur;
        private System.Windows.Forms.TextBox txtSiparisKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox siparisTipi;
        private System.Windows.Forms.TextBox txtSiparisTeslimTarih;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSiparisTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCariKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAciklama1;
        private System.Windows.Forms.TextBox txtProjeAdi;
        private System.Windows.Forms.TextBox txtProjeKodu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOzelKod;
        private System.Windows.Forms.TextBox txtIlIlce;
        private System.Windows.Forms.TextBox txtTicariUnvan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCariIsim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCariListeAc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStokKodu;
        private System.Windows.Forms.Button btnStokListesi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView siparisListesiGridView;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtStokMiktar;
        private System.Windows.Forms.TextBox txtStokAdi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Button btnListeyeEkle;
        private System.Windows.Forms.TextBox txtStokBirim;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAciklama2;
        private System.Windows.Forms.ComboBox cbStokDepo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}