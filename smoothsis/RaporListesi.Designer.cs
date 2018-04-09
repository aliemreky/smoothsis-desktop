namespace smoothsis
{
    partial class RaporListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporListesi));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRaporListesiGetir = new System.Windows.Forms.Button();
            this.dtAramaRaporTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAramaRaporVardiya = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raporListGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üretimBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatörBilgıleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raporListGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnRaporListesiGetir);
            this.groupBox2.Controls.Add(this.dtAramaRaporTarih);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAramaRaporVardiya);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(11, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 496);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARAMA";
            // 
            // btnRaporListesiGetir
            // 
            this.btnRaporListesiGetir.Location = new System.Drawing.Point(17, 34);
            this.btnRaporListesiGetir.Name = "btnRaporListesiGetir";
            this.btnRaporListesiGetir.Size = new System.Drawing.Size(195, 43);
            this.btnRaporListesiGetir.TabIndex = 0;
            this.btnRaporListesiGetir.TabStop = false;
            this.btnRaporListesiGetir.Text = "RAPOR LİSTESİNİ YENİLE";
            this.btnRaporListesiGetir.UseVisualStyleBackColor = true;
            this.btnRaporListesiGetir.Click += new System.EventHandler(this.btnRaporListesiGetir_Click);
            // 
            // dtAramaRaporTarih
            // 
            this.dtAramaRaporTarih.CustomFormat = "";
            this.dtAramaRaporTarih.Location = new System.Drawing.Point(17, 200);
            this.dtAramaRaporTarih.Name = "dtAramaRaporTarih";
            this.dtAramaRaporTarih.Size = new System.Drawing.Size(195, 23);
            this.dtAramaRaporTarih.TabIndex = 6;
            this.dtAramaRaporTarih.ValueChanged += new System.EventHandler(this.searchForRaporTarih);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "RAPOR TARİHİ";
            // 
            // txtAramaRaporVardiya
            // 
            this.txtAramaRaporVardiya.Location = new System.Drawing.Point(17, 130);
            this.txtAramaRaporVardiya.Name = "txtAramaRaporVardiya";
            this.txtAramaRaporVardiya.Size = new System.Drawing.Size(195, 23);
            this.txtAramaRaporVardiya.TabIndex = 2;
            this.txtAramaRaporVardiya.TextChanged += new System.EventHandler(this.searchForRaporVardiya);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "VARDIYA";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.raporListGridView);
            this.groupBox1.Location = new System.Drawing.Point(252, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 496);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // raporListGridView
            // 
            this.raporListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.raporListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raporListGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.raporListGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.raporListGridView.Location = new System.Drawing.Point(6, 13);
            this.raporListGridView.MultiSelect = false;
            this.raporListGridView.Name = "raporListGridView";
            this.raporListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.raporListGridView.Size = new System.Drawing.Size(1045, 477);
            this.raporListGridView.TabIndex = 19;
            this.raporListGridView.VirtualMode = true;
            this.raporListGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.raporListGridView_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.üretimBilgileriToolStripMenuItem,
            this.operatörBilgıleriToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 70);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.duzenleToolStripMenuItem_Click);
            // 
            // üretimBilgileriToolStripMenuItem
            // 
            this.üretimBilgileriToolStripMenuItem.Name = "üretimBilgileriToolStripMenuItem";
            this.üretimBilgileriToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.üretimBilgileriToolStripMenuItem.Text = "Üretim Bilgileri";
            this.üretimBilgileriToolStripMenuItem.Click += new System.EventHandler(this.uretimBilgileriToolStripMenuItem_Click);
            // 
            // operatörBilgıleriToolStripMenuItem
            // 
            this.operatörBilgıleriToolStripMenuItem.Name = "operatörBilgıleriToolStripMenuItem";
            this.operatörBilgıleriToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.operatörBilgıleriToolStripMenuItem.Text = "Operatör Bilgileri";
            this.operatörBilgıleriToolStripMenuItem.Click += new System.EventHandler(this.operatorBilgileriToolStripMenuItem_Click);
            // 
            // RaporListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1321, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RaporListesi";
            this.Text = "SMOOTHSIS [RAPOR LİSTESİ ]";
            this.Load += new System.EventHandler(this.RaporListesi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raporListGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRaporListesiGetir;
        private System.Windows.Forms.DateTimePicker dtAramaRaporTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAramaRaporVardiya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView raporListGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üretimBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatörBilgıleriToolStripMenuItem;
    }
}