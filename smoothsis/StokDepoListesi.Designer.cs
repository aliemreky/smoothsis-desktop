namespace smoothsis
{
    partial class StokDepoListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokDepoListesi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.transferYapBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.silBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.iptalButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stokDepoListGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStokKod = new System.Windows.Forms.TextBox();
            this.txtStokAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStokBirim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokDepoListGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferYapBttn,
            this.toolStripSeparator4,
            this.silBttn,
            this.toolStripSeparator3,
            this.iptalButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 1, 2, 1);
            this.toolStrip1.Size = new System.Drawing.Size(825, 32);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // transferYapBttn
            // 
            this.transferYapBttn.Image = global::smoothsis.Properties.Resources.ic_save_black_24dp_1x;
            this.transferYapBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.transferYapBttn.Name = "transferYapBttn";
            this.transferYapBttn.Size = new System.Drawing.Size(100, 27);
            this.transferYapBttn.Text = "Transfer Yap";
            this.transferYapBttn.ToolTipText = "Değişiklikleri Kaydet";
            this.transferYapBttn.Click += new System.EventHandler(this.transferYapBttn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(12, 28);
            // 
            // silBttn
            // 
            this.silBttn.Image = global::smoothsis.Properties.Resources.ic_delete_forever_black_24dp_1x;
            this.silBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.silBttn.Name = "silBttn";
            this.silBttn.Size = new System.Drawing.Size(41, 27);
            this.silBttn.Text = "Sil";
            this.silBttn.Click += new System.EventHandler(this.silBttn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(12, 28);
            // 
            // iptalButton
            // 
            this.iptalButton.Image = global::smoothsis.Properties.Resources.ic_highlight_off_black_24dp_1x;
            this.iptalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(54, 27);
            this.iptalButton.Text = "Çıkış";
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stokDepoListGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 275);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // stokDepoListGridView
            // 
            this.stokDepoListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stokDepoListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stokDepoListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stokDepoListGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.stokDepoListGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.stokDepoListGridView.Location = new System.Drawing.Point(6, 13);
            this.stokDepoListGridView.Name = "stokDepoListGridView";
            this.stokDepoListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stokDepoListGridView.Size = new System.Drawing.Size(788, 256);
            this.stokDepoListGridView.TabIndex = 0;
            this.stokDepoListGridView.VirtualMode = true;
            this.stokDepoListGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selectRow);
            this.stokDepoListGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stokDepoListGridView_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("düzenleToolStripMenuItem.Image")));
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(15, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "STOK KODU ";
            // 
            // txtStokKod
            // 
            this.txtStokKod.Enabled = false;
            this.txtStokKod.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokKod.Location = new System.Drawing.Point(97, 45);
            this.txtStokKod.Name = "txtStokKod";
            this.txtStokKod.ReadOnly = true;
            this.txtStokKod.Size = new System.Drawing.Size(157, 23);
            this.txtStokKod.TabIndex = 15;
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtStokAdi.Enabled = false;
            this.txtStokAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokAdi.Location = new System.Drawing.Point(381, 46);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.ReadOnly = true;
            this.txtStokAdi.Size = new System.Drawing.Size(158, 23);
            this.txtStokAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(314, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOK ADI";
            // 
            // txtStokBirim
            // 
            this.txtStokBirim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtStokBirim.Enabled = false;
            this.txtStokBirim.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokBirim.Location = new System.Drawing.Point(655, 46);
            this.txtStokBirim.Name = "txtStokBirim";
            this.txtStokBirim.ReadOnly = true;
            this.txtStokBirim.Size = new System.Drawing.Size(158, 23);
            this.txtStokBirim.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(609, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "BIRIM";
            // 
            // StokDepoListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(825, 359);
            this.Controls.Add(this.txtStokBirim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtStokAdi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtStokKod);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StokDepoListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMOOTHSISI [ STOK DEPO LİSTESİ ]";
            this.Load += new System.EventHandler(this.StokDepoListesi_Load);
            this.Shown += new System.EventHandler(this.StokDepoListesi_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stokDepoListGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton silBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton iptalButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStokKod;
        private System.Windows.Forms.TextBox txtStokAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stokDepoListGridView;
        private System.Windows.Forms.ToolStripButton transferYapBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.TextBox txtStokBirim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
    }
}