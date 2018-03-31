namespace smoothsis
{
    partial class StokTransferListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokTransferListesi));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStokTransferListesiGetir = new System.Windows.Forms.Button();
            this.dtAramaKayitTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAramaKaynakDepo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stokTransferListGridView = new System.Windows.Forms.DataGridView();
            this.txtAramaHedefDepo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAramaStokAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAramaKayitYapan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokTransferListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtAramaKayitYapan);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtAramaStokAdi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtAramaHedefDepo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnStokTransferListesiGetir);
            this.groupBox2.Controls.Add(this.dtAramaKayitTarih);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAramaKaynakDepo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(14, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 522);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARAMA";
            // 
            // btnStokTransferListesiGetir
            // 
            this.btnStokTransferListesiGetir.Location = new System.Drawing.Point(20, 39);
            this.btnStokTransferListesiGetir.Name = "btnStokTransferListesiGetir";
            this.btnStokTransferListesiGetir.Size = new System.Drawing.Size(227, 50);
            this.btnStokTransferListesiGetir.TabIndex = 0;
            this.btnStokTransferListesiGetir.TabStop = false;
            this.btnStokTransferListesiGetir.Text = "TRANSFER LİSTESİNİ YENİLE";
            this.btnStokTransferListesiGetir.UseVisualStyleBackColor = true;
            this.btnStokTransferListesiGetir.Click += new System.EventHandler(this.btnStokTransferListesiGetir_Click);
            // 
            // dtAramaKayitTarih
            // 
            this.dtAramaKayitTarih.CustomFormat = "";
            this.dtAramaKayitTarih.Location = new System.Drawing.Point(19, 360);
            this.dtAramaKayitTarih.Name = "dtAramaKayitTarih";
            this.dtAramaKayitTarih.Size = new System.Drawing.Size(227, 23);
            this.dtAramaKayitTarih.TabIndex = 6;
            this.dtAramaKayitTarih.ValueChanged += new System.EventHandler(this.searchForKayitTarih);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "TRANSFER TARİHİ";
            // 
            // txtAramaKaynakDepo
            // 
            this.txtAramaKaynakDepo.Location = new System.Drawing.Point(19, 122);
            this.txtAramaKaynakDepo.Name = "txtAramaKaynakDepo";
            this.txtAramaKaynakDepo.Size = new System.Drawing.Size(227, 23);
            this.txtAramaKaynakDepo.TabIndex = 1;
            this.txtAramaKaynakDepo.TextChanged += new System.EventHandler(this.searchForKaynakDepo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "KAYNAK DEPO";
            // 
            // stokTransferListGridView
            // 
            this.stokTransferListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stokTransferListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.stokTransferListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stokTransferListGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.stokTransferListGridView.Location = new System.Drawing.Point(295, 12);
            this.stokTransferListGridView.MultiSelect = false;
            this.stokTransferListGridView.Name = "stokTransferListGridView";
            this.stokTransferListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stokTransferListGridView.Size = new System.Drawing.Size(726, 513);
            this.stokTransferListGridView.TabIndex = 24;
            this.stokTransferListGridView.VirtualMode = true;
            // 
            // txtAramaHedefDepo
            // 
            this.txtAramaHedefDepo.Location = new System.Drawing.Point(19, 177);
            this.txtAramaHedefDepo.Name = "txtAramaHedefDepo";
            this.txtAramaHedefDepo.Size = new System.Drawing.Size(227, 23);
            this.txtAramaHedefDepo.TabIndex = 8;
            this.txtAramaHedefDepo.TextChanged += new System.EventHandler(this.searchForHedefDepo);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "HEDEF DEPO";
            // 
            // txtAramaStokAdi
            // 
            this.txtAramaStokAdi.Location = new System.Drawing.Point(19, 235);
            this.txtAramaStokAdi.Name = "txtAramaStokAdi";
            this.txtAramaStokAdi.Size = new System.Drawing.Size(227, 23);
            this.txtAramaStokAdi.TabIndex = 10;
            this.txtAramaStokAdi.TextChanged += new System.EventHandler(this.searchForStokAdi);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "STOK ADI";
            // 
            // txtAramaKayitYapan
            // 
            this.txtAramaKayitYapan.Location = new System.Drawing.Point(19, 297);
            this.txtAramaKayitYapan.Name = "txtAramaKayitYapan";
            this.txtAramaKayitYapan.Size = new System.Drawing.Size(227, 23);
            this.txtAramaKayitYapan.TabIndex = 12;
            this.txtAramaKayitYapan.TextChanged += new System.EventHandler(this.searchForKayitYapan);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "TRANSFER YAPAN";
            // 
            // StokTransferListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1035, 539);
            this.Controls.Add(this.stokTransferListGridView);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StokTransferListesi";
            this.Text = "SMOOTHSIS [ STOK TRANSFER LİSTESİ ]";
            this.Load += new System.EventHandler(this.StokTransferListesi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokTransferListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStokTransferListesiGetir;
        private System.Windows.Forms.DateTimePicker dtAramaKayitTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAramaKaynakDepo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stokTransferListGridView;
        private System.Windows.Forms.TextBox txtAramaHedefDepo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAramaStokAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAramaKayitYapan;
        private System.Windows.Forms.Label label5;
    }
}