namespace smoothsis
{
    partial class SiparisListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisListesi));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbAramaSiparisTipi = new System.Windows.Forms.ComboBox();
            this.cmbAramaSiparisDurumu = new System.Windows.Forms.ComboBox();
            this.cmbAramaUretimDetay = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAramaCariAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAramaCariKodu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAramaProjeAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAramaProjeKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAramaSiparisKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.siparisListGridView = new System.Windows.Forms.DataGridView();
            this.siparisListesiMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UretimKaydiOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siparisListGridView)).BeginInit();
            this.siparisListesiMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbAramaSiparisTipi);
            this.groupBox2.Controls.Add(this.cmbAramaSiparisDurumu);
            this.groupBox2.Controls.Add(this.cmbAramaUretimDetay);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtAramaCariAdi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAramaCariKodu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAramaProjeAdi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAramaProjeKodu);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAramaSiparisKodu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 532);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARAMA";
            // 
            // cmbAramaSiparisTipi
            // 
            this.cmbAramaSiparisTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAramaSiparisTipi.FormattingEnabled = true;
            this.cmbAramaSiparisTipi.Items.AddRange(new object[] {
            "",
            "YURT İÇİ",
            "YURT DIŞI"});
            this.cmbAramaSiparisTipi.Location = new System.Drawing.Point(18, 108);
            this.cmbAramaSiparisTipi.Name = "cmbAramaSiparisTipi";
            this.cmbAramaSiparisTipi.Size = new System.Drawing.Size(195, 23);
            this.cmbAramaSiparisTipi.TabIndex = 2;
            this.cmbAramaSiparisTipi.SelectedIndexChanged += new System.EventHandler(this.cmbAramaSiparisTipi_SelectedIndexChanged);
            // 
            // cmbAramaSiparisDurumu
            // 
            this.cmbAramaSiparisDurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAramaSiparisDurumu.FormattingEnabled = true;
            this.cmbAramaSiparisDurumu.Items.AddRange(new object[] {
            "",
            "AÇIK",
            "KAPALI"});
            this.cmbAramaSiparisDurumu.Location = new System.Drawing.Point(18, 478);
            this.cmbAramaSiparisDurumu.Name = "cmbAramaSiparisDurumu";
            this.cmbAramaSiparisDurumu.Size = new System.Drawing.Size(195, 23);
            this.cmbAramaSiparisDurumu.TabIndex = 8;
            this.cmbAramaSiparisDurumu.SelectedIndexChanged += new System.EventHandler(this.cmbAramaSiparisDurumu_SelectedIndexChanged);
            // 
            // cmbAramaUretimDetay
            // 
            this.cmbAramaUretimDetay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAramaUretimDetay.FormattingEnabled = true;
            this.cmbAramaUretimDetay.Items.AddRange(new object[] {
            "",
            "ÜRETİMDE",
            "SİPARİŞ AŞAMASINDA"});
            this.cmbAramaUretimDetay.Location = new System.Drawing.Point(18, 420);
            this.cmbAramaUretimDetay.Name = "cmbAramaUretimDetay";
            this.cmbAramaUretimDetay.Size = new System.Drawing.Size(195, 23);
            this.cmbAramaUretimDetay.TabIndex = 7;
            this.cmbAramaUretimDetay.SelectedIndexChanged += new System.EventHandler(this.cmbAramaUretimDetay_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "SİPARİŞ TİPİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "SİPARİŞ DURUMU";
            // 
            // txtAramaCariAdi
            // 
            this.txtAramaCariAdi.Location = new System.Drawing.Point(18, 361);
            this.txtAramaCariAdi.Name = "txtAramaCariAdi";
            this.txtAramaCariAdi.Size = new System.Drawing.Size(195, 23);
            this.txtAramaCariAdi.TabIndex = 6;
            this.txtAramaCariAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAramaCariAdi_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "ÜRETİM DETAY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "CARİ ADI";
            // 
            // txtAramaCariKodu
            // 
            this.txtAramaCariKodu.Location = new System.Drawing.Point(18, 301);
            this.txtAramaCariKodu.Name = "txtAramaCariKodu";
            this.txtAramaCariKodu.Size = new System.Drawing.Size(195, 23);
            this.txtAramaCariKodu.TabIndex = 5;
            this.txtAramaCariKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAramaCariKodu_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "CARİ KODU";
            // 
            // txtAramaProjeAdi
            // 
            this.txtAramaProjeAdi.Location = new System.Drawing.Point(18, 234);
            this.txtAramaProjeAdi.Name = "txtAramaProjeAdi";
            this.txtAramaProjeAdi.Size = new System.Drawing.Size(195, 23);
            this.txtAramaProjeAdi.TabIndex = 4;
            this.txtAramaProjeAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAramaProjeAdi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "PROJE ADI";
            // 
            // txtAramaProjeKodu
            // 
            this.txtAramaProjeKodu.Location = new System.Drawing.Point(18, 170);
            this.txtAramaProjeKodu.Name = "txtAramaProjeKodu";
            this.txtAramaProjeKodu.Size = new System.Drawing.Size(195, 23);
            this.txtAramaProjeKodu.TabIndex = 3;
            this.txtAramaProjeKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAramaProjeKodu_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "PROJE KODU";
            // 
            // txtAramaSiparisKodu
            // 
            this.txtAramaSiparisKodu.Location = new System.Drawing.Point(18, 51);
            this.txtAramaSiparisKodu.Name = "txtAramaSiparisKodu";
            this.txtAramaSiparisKodu.Size = new System.Drawing.Size(195, 23);
            this.txtAramaSiparisKodu.TabIndex = 1;
            this.txtAramaSiparisKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAramaSiparisKodu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SİPARİŞ KODU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.siparisListGridView);
            this.groupBox1.Location = new System.Drawing.Point(253, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 532);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // siparisListGridView
            // 
            this.siparisListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siparisListGridView.ContextMenuStrip = this.siparisListesiMenu;
            this.siparisListGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.siparisListGridView.Location = new System.Drawing.Point(6, 13);
            this.siparisListGridView.MultiSelect = false;
            this.siparisListGridView.Name = "siparisListGridView";
            this.siparisListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.siparisListGridView.Size = new System.Drawing.Size(932, 513);
            this.siparisListGridView.TabIndex = 19;
            this.siparisListGridView.VirtualMode = true;
            this.siparisListGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.siparisListGridView_CellMouseDown);
            // 
            // siparisListesiMenu
            // 
            this.siparisListesiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UretimKaydiOlusturToolStripMenuItem});
            this.siparisListesiMenu.Name = "siparisListesiMenu";
            this.siparisListesiMenu.Size = new System.Drawing.Size(185, 48);
            this.siparisListesiMenu.Opening += new System.ComponentModel.CancelEventHandler(this.siparisListesiMenu_Opening);
            // 
            // UretimKaydiOlusturToolStripMenuItem
            // 
            this.UretimKaydiOlusturToolStripMenuItem.Name = "UretimKaydiOlusturToolStripMenuItem";
            this.UretimKaydiOlusturToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.UretimKaydiOlusturToolStripMenuItem.Text = "Üretim Paneline Giriş";
            this.UretimKaydiOlusturToolStripMenuItem.Click += new System.EventHandler(this.UretimKaydiOlusturToolStripMenuItem_Click);
            // 
            // SiparisListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1208, 564);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SiparisListesi";
            this.Text = "SMOOTHSIS [ SİPARİŞ LİSTESİ ]";
            this.Load += new System.EventHandler(this.SiparisListesi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siparisListGridView)).EndInit();
            this.siparisListesiMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAramaSiparisKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView siparisListGridView;
        private System.Windows.Forms.ComboBox cmbAramaUretimDetay;
        private System.Windows.Forms.TextBox txtAramaCariAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAramaCariKodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAramaProjeAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAramaProjeKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAramaSiparisTipi;
        private System.Windows.Forms.ComboBox cmbAramaSiparisDurumu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip siparisListesiMenu;
        private System.Windows.Forms.ToolStripMenuItem UretimKaydiOlusturToolStripMenuItem;
    }
}