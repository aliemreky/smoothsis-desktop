namespace smoothsis
{
    partial class UretimListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UretimListesi));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUretimListesiGetir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAramaStokAdi = new System.Windows.Forms.TextBox();
            this.txtAramaMakine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAramaIslem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAramaStokKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uretimListGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.raporOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uretimListGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnUretimListesiGetir);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtAramaStokAdi);
            this.groupBox2.Controls.Add(this.txtAramaMakine);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAramaIslem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAramaStokKodu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 532);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARAMA";
            // 
            // btnUretimListesiGetir
            // 
            this.btnUretimListesiGetir.Location = new System.Drawing.Point(18, 31);
            this.btnUretimListesiGetir.Name = "btnUretimListesiGetir";
            this.btnUretimListesiGetir.Size = new System.Drawing.Size(195, 43);
            this.btnUretimListesiGetir.TabIndex = 6;
            this.btnUretimListesiGetir.TabStop = false;
            this.btnUretimListesiGetir.Text = "LİSTEYİ YENİLE";
            this.btnUretimListesiGetir.UseVisualStyleBackColor = true;
            this.btnUretimListesiGetir.Click += new System.EventHandler(this.btnUretimListesiGetir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "STOK ADI";
            // 
            // txtAramaStokAdi
            // 
            this.txtAramaStokAdi.Location = new System.Drawing.Point(18, 184);
            this.txtAramaStokAdi.Name = "txtAramaStokAdi";
            this.txtAramaStokAdi.Size = new System.Drawing.Size(195, 23);
            this.txtAramaStokAdi.TabIndex = 5;
            this.txtAramaStokAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAramaStokAdi_KeyPress);
            // 
            // txtAramaMakine
            // 
            this.txtAramaMakine.Location = new System.Drawing.Point(18, 309);
            this.txtAramaMakine.Name = "txtAramaMakine";
            this.txtAramaMakine.Size = new System.Drawing.Size(195, 23);
            this.txtAramaMakine.TabIndex = 4;
            this.txtAramaMakine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAramaMakine_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "MAKİNE";
            // 
            // txtAramaIslem
            // 
            this.txtAramaIslem.Location = new System.Drawing.Point(18, 245);
            this.txtAramaIslem.Name = "txtAramaIslem";
            this.txtAramaIslem.Size = new System.Drawing.Size(195, 23);
            this.txtAramaIslem.TabIndex = 3;
            this.txtAramaIslem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAramaIslem_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "İŞLEM";
            // 
            // txtAramaStokKodu
            // 
            this.txtAramaStokKodu.Location = new System.Drawing.Point(18, 123);
            this.txtAramaStokKodu.Name = "txtAramaStokKodu";
            this.txtAramaStokKodu.Size = new System.Drawing.Size(195, 23);
            this.txtAramaStokKodu.TabIndex = 1;
            this.txtAramaStokKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAramaStokKodu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOK KODU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uretimListGridView);
            this.groupBox1.Location = new System.Drawing.Point(250, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 532);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // uretimListGridView
            // 
            this.uretimListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uretimListGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.uretimListGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.uretimListGridView.Location = new System.Drawing.Point(6, 13);
            this.uretimListGridView.MultiSelect = false;
            this.uretimListGridView.Name = "uretimListGridView";
            this.uretimListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uretimListGridView.Size = new System.Drawing.Size(932, 513);
            this.uretimListGridView.TabIndex = 19;
            this.uretimListGridView.VirtualMode = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporOluşturToolStripMenuItem,
            this.raporListesiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // raporOluşturToolStripMenuItem
            // 
            this.raporOluşturToolStripMenuItem.Name = "raporOluşturToolStripMenuItem";
            this.raporOluşturToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.raporOluşturToolStripMenuItem.Text = "Rapor Oluştur";
            this.raporOluşturToolStripMenuItem.Click += new System.EventHandler(this.raporOlusturToolStripMenuItem_Click);
            // 
            // raporListesiToolStripMenuItem
            // 
            this.raporListesiToolStripMenuItem.Name = "raporListesiToolStripMenuItem";
            this.raporListesiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.raporListesiToolStripMenuItem.Text = "Rapor Listesi";
            this.raporListesiToolStripMenuItem.Click += new System.EventHandler(this.raporListesiToolStripMenuItem_Click);
            // 
            // UretimListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1209, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UretimListesi";
            this.Text = "SMOOTHSIS [ ÜRETİM LİSTESİ ]";
            this.Load += new System.EventHandler(this.UretimListesi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uretimListGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAramaStokAdi;
        private System.Windows.Forms.TextBox txtAramaMakine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAramaIslem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAramaStokKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView uretimListGridView;
        private System.Windows.Forms.Button btnUretimListesiGetir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem raporOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporListesiToolStripMenuItem;
    }
}