namespace smoothsis
{
    partial class DepoListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepoListesi));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.depoListGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stokListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAramaDepoLokasyon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAramaDepoAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depoListGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.depoListGridView);
            this.groupBox2.Location = new System.Drawing.Point(248, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 314);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // depoListGridView
            // 
            this.depoListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.depoListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depoListGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.depoListGridView.Location = new System.Drawing.Point(8, 18);
            this.depoListGridView.MultiSelect = false;
            this.depoListGridView.Name = "depoListGridView";
            this.depoListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.depoListGridView.Size = new System.Drawing.Size(640, 290);
            this.depoListGridView.TabIndex = 0;
            this.depoListGridView.TabStop = false;
            this.depoListGridView.VirtualMode = true;
            this.depoListGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showDepo);
            this.depoListGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.depoListGridView_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokListesiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 26);
            // 
            // stokListesiToolStripMenuItem
            // 
            this.stokListesiToolStripMenuItem.Name = "stokListesiToolStripMenuItem";
            this.stokListesiToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.stokListesiToolStripMenuItem.Text = "Stok Listesi";
            this.stokListesiToolStripMenuItem.Click += new System.EventHandler(this.stokListesiToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtAramaDepoLokasyon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAramaDepoAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 314);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARAMA";
            // 
            // txtAramaDepoLokasyon
            // 
            this.txtAramaDepoLokasyon.Location = new System.Drawing.Point(15, 109);
            this.txtAramaDepoLokasyon.Multiline = true;
            this.txtAramaDepoLokasyon.Name = "txtAramaDepoLokasyon";
            this.txtAramaDepoLokasyon.Size = new System.Drawing.Size(189, 25);
            this.txtAramaDepoLokasyon.TabIndex = 2;
            this.txtAramaDepoLokasyon.TextChanged += new System.EventHandler(this.searchForDepoLokasyon);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "DEPO LOKASYON";
            // 
            // txtAramaDepoAdi
            // 
            this.txtAramaDepoAdi.Location = new System.Drawing.Point(15, 47);
            this.txtAramaDepoAdi.Multiline = true;
            this.txtAramaDepoAdi.Name = "txtAramaDepoAdi";
            this.txtAramaDepoAdi.Size = new System.Drawing.Size(189, 25);
            this.txtAramaDepoAdi.TabIndex = 1;
            this.txtAramaDepoAdi.TextChanged += new System.EventHandler(this.searchForDepoAdi);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEPO ADI";
            // 
            // DepoListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(921, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepoListesi";
            this.Text = "SMOOTHSIS [ DEPO LİSTESİ ]";
            this.Load += new System.EventHandler(this.DepoListesi_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.depoListGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView depoListGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAramaDepoLokasyon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAramaDepoAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stokListesiToolStripMenuItem;
    }
}