namespace smoothsis
{
    partial class StokListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokListesi));
            this.stokListGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStokListesiGetir = new System.Windows.Forms.Button();
            this.dtAramaGelisTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMalzemeEtiketBilgi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAramaMalzemeCinsi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAramaMalzemeSerisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAramaStokAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAramaStokKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stokListGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stokListGridView
            // 
            this.stokListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stokListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stokListGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.stokListGridView.Location = new System.Drawing.Point(6, 13);
            this.stokListGridView.MultiSelect = false;
            this.stokListGridView.Name = "stokListGridView";
            this.stokListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stokListGridView.Size = new System.Drawing.Size(932, 482);
            this.stokListGridView.TabIndex = 19;
            this.stokListGridView.VirtualMode = true;
            this.stokListGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stokListGridView_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.stokListGridView);
            this.groupBox1.Location = new System.Drawing.Point(253, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 501);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnStokListesiGetir);
            this.groupBox2.Controls.Add(this.dtAramaGelisTarih);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMalzemeEtiketBilgi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAramaMalzemeCinsi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAramaMalzemeSerisi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAramaStokAdi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAramaStokKodu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 501);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARAMA";
            // 
            // btnStokListesiGetir
            // 
            this.btnStokListesiGetir.Location = new System.Drawing.Point(17, 34);
            this.btnStokListesiGetir.Name = "btnStokListesiGetir";
            this.btnStokListesiGetir.Size = new System.Drawing.Size(195, 43);
            this.btnStokListesiGetir.TabIndex = 0;
            this.btnStokListesiGetir.TabStop = false;
            this.btnStokListesiGetir.Text = "STOK LİSTESİNİ YENİLE";
            this.btnStokListesiGetir.UseVisualStyleBackColor = true;
            this.btnStokListesiGetir.Click += new System.EventHandler(this.btnStokListesiGetir_Click);
            // 
            // dtAramaGelisTarih
            // 
            this.dtAramaGelisTarih.CustomFormat = "";
            this.dtAramaGelisTarih.Location = new System.Drawing.Point(17, 445);
            this.dtAramaGelisTarih.Name = "dtAramaGelisTarih";
            this.dtAramaGelisTarih.Size = new System.Drawing.Size(195, 23);
            this.dtAramaGelisTarih.TabIndex = 6;
            this.dtAramaGelisTarih.ValueChanged += new System.EventHandler(this.searchForGelisTarih);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "GELİŞ TARİHİ";
            // 
            // txtMalzemeEtiketBilgi
            // 
            this.txtMalzemeEtiketBilgi.Location = new System.Drawing.Point(17, 379);
            this.txtMalzemeEtiketBilgi.Name = "txtMalzemeEtiketBilgi";
            this.txtMalzemeEtiketBilgi.Size = new System.Drawing.Size(195, 23);
            this.txtMalzemeEtiketBilgi.TabIndex = 5;
            this.txtMalzemeEtiketBilgi.TextChanged += new System.EventHandler(this.txtMalzemeEtiketBilgi_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "ETİKET BİLGİ";
            // 
            // txtAramaMalzemeCinsi
            // 
            this.txtAramaMalzemeCinsi.Location = new System.Drawing.Point(17, 313);
            this.txtAramaMalzemeCinsi.Name = "txtAramaMalzemeCinsi";
            this.txtAramaMalzemeCinsi.Size = new System.Drawing.Size(195, 23);
            this.txtAramaMalzemeCinsi.TabIndex = 4;
            this.txtAramaMalzemeCinsi.TextChanged += new System.EventHandler(this.txtAramaMalzemeCinsi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "MALZEME CİNSİ";
            // 
            // txtAramaMalzemeSerisi
            // 
            this.txtAramaMalzemeSerisi.Location = new System.Drawing.Point(17, 249);
            this.txtAramaMalzemeSerisi.Name = "txtAramaMalzemeSerisi";
            this.txtAramaMalzemeSerisi.Size = new System.Drawing.Size(195, 23);
            this.txtAramaMalzemeSerisi.TabIndex = 3;
            this.txtAramaMalzemeSerisi.TextChanged += new System.EventHandler(this.txtAramaMalzemeSerisi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "MALZEME SERİSİ";
            // 
            // txtAramaStokAdi
            // 
            this.txtAramaStokAdi.Location = new System.Drawing.Point(17, 188);
            this.txtAramaStokAdi.Name = "txtAramaStokAdi";
            this.txtAramaStokAdi.Size = new System.Drawing.Size(195, 23);
            this.txtAramaStokAdi.TabIndex = 2;
            this.txtAramaStokAdi.TextChanged += new System.EventHandler(this.searchForStokAdi);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "STOK ADI";
            // 
            // txtAramaStokKodu
            // 
            this.txtAramaStokKodu.Location = new System.Drawing.Point(17, 120);
            this.txtAramaStokKodu.Name = "txtAramaStokKodu";
            this.txtAramaStokKodu.Size = new System.Drawing.Size(195, 23);
            this.txtAramaStokKodu.TabIndex = 1;
            this.txtAramaStokKodu.TextChanged += new System.EventHandler(this.searchForStokKodu);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOK KODU";
            // 
            // StokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1219, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StokListesi";
            this.Text = "SMOOTHSIS [ STOK LİSTESİ ]";
            this.Load += new System.EventHandler(this.StokListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokListGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView stokListGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAramaStokAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAramaStokKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtAramaGelisTarih;
        private System.Windows.Forms.Button btnStokListesiGetir;
        private System.Windows.Forms.TextBox txtMalzemeEtiketBilgi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAramaMalzemeCinsi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAramaMalzemeSerisi;
        private System.Windows.Forms.Label label4;
    }
}