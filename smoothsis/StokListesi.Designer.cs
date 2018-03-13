﻿namespace smoothsis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokListesi));
            this.stokListGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stokTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.allStokList = new System.Windows.Forms.Button();
            this.dtAramaGelisTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAramaStokAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAramaStokKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stokListGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.stokListGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.stokListGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.stokListGridView.Location = new System.Drawing.Point(6, 22);
            this.stokListGridView.MultiSelect = false;
            this.stokListGridView.Name = "stokListGridView";
            this.stokListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stokListGridView.Size = new System.Drawing.Size(1042, 482);
            this.stokListGridView.TabIndex = 19;
            this.stokListGridView.VirtualMode = true;
            this.stokListGridView.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.selectRowWithRightMenu);
            this.stokListGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showStok);
            this.stokListGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stokListGridView_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokTransferToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 26);
            // 
            // stokTransferToolStripMenuItem
            // 
            this.stokTransferToolStripMenuItem.Name = "stokTransferToolStripMenuItem";
            this.stokTransferToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.stokTransferToolStripMenuItem.Text = "Stok Transferi Yap ";
            this.stokTransferToolStripMenuItem.Click += new System.EventHandler(this.stokTransferToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stokListGridView);
            this.groupBox1.Location = new System.Drawing.Point(236, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 519);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.allStokList);
            this.groupBox2.Controls.Add(this.dtAramaGelisTarih);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAramaStokAdi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAramaStokKodu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 519);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARAMA";
            // 
            // allStokList
            // 
            this.allStokList.Location = new System.Drawing.Point(9, 22);
            this.allStokList.Name = "allStokList";
            this.allStokList.Size = new System.Drawing.Size(195, 32);
            this.allStokList.TabIndex = 4;
            this.allStokList.Text = "TÜM STOKLAR";
            this.allStokList.UseVisualStyleBackColor = true;
            this.allStokList.Click += new System.EventHandler(this.allStokList_Click);
            // 
            // dtAramaGelisTarih
            // 
            this.dtAramaGelisTarih.CustomFormat = "";
            this.dtAramaGelisTarih.Location = new System.Drawing.Point(9, 209);
            this.dtAramaGelisTarih.Name = "dtAramaGelisTarih";
            this.dtAramaGelisTarih.Size = new System.Drawing.Size(195, 23);
            this.dtAramaGelisTarih.TabIndex = 3;
            this.dtAramaGelisTarih.ValueChanged += new System.EventHandler(this.searchForGelisTarih);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "GELİŞ TARİHİ";
            // 
            // txtAramaStokAdi
            // 
            this.txtAramaStokAdi.Location = new System.Drawing.Point(9, 147);
            this.txtAramaStokAdi.Name = "txtAramaStokAdi";
            this.txtAramaStokAdi.Size = new System.Drawing.Size(195, 23);
            this.txtAramaStokAdi.TabIndex = 2;
            this.txtAramaStokAdi.TextChanged += new System.EventHandler(this.searchForStokAdi);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "STOK ADI";
            // 
            // txtAramaStokKodu
            // 
            this.txtAramaStokKodu.Location = new System.Drawing.Point(9, 91);
            this.txtAramaStokKodu.Name = "txtAramaStokKodu";
            this.txtAramaStokKodu.Size = new System.Drawing.Size(195, 23);
            this.txtAramaStokKodu.TabIndex = 1;
            this.txtAramaStokKodu.TextChanged += new System.EventHandler(this.searchForStokKodu);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
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
            this.ClientSize = new System.Drawing.Size(1302, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StokListesi";
            this.Text = "SMOOTHSIS [ STOK LİSTESİ ]";
            this.Load += new System.EventHandler(this.StokListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stokListGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stokTransferToolStripMenuItem;
        private System.Windows.Forms.Button allStokList;
    }
}