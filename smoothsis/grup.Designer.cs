namespace smoothsis
{
    partial class Grup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grup));
            this.grupList = new System.Windows.Forms.DataGridView();
            this.grupAdTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.kaydetBttn = new System.Windows.Forms.ToolStripButton();
            this.tllStrip = new System.Windows.Forms.ToolStripSeparator();
            this.temizleBttn = new System.Windows.Forms.ToolStripButton();
            this.tllStrip2 = new System.Windows.Forms.ToolStripSeparator();
            this.silBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iptalButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grupList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupList
            // 
            this.grupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupList.Location = new System.Drawing.Point(17, 22);
            this.grupList.MultiSelect = false;
            this.grupList.Name = "grupList";
            this.grupList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grupList.Size = new System.Drawing.Size(379, 226);
            this.grupList.TabIndex = 0;
            this.grupList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grupList_CellMouseClick);
            // 
            // grupAdTB
            // 
            this.grupAdTB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupAdTB.Location = new System.Drawing.Point(111, 22);
            this.grupAdTB.Multiline = true;
            this.grupAdTB.Name = "grupAdTB";
            this.grupAdTB.Size = new System.Drawing.Size(283, 26);
            this.grupAdTB.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grupAdTB);
            this.groupBox1.Location = new System.Drawing.Point(29, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GRUP EKLE/GÜNCELLE/SİL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "GRUP ADI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grupList);
            this.groupBox2.Location = new System.Drawing.Point(29, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 268);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GRUP LİSTESİ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetBttn,
            this.tllStrip,
            this.temizleBttn,
            this.tllStrip2,
            this.silBttn,
            this.toolStripSeparator2,
            this.iptalButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(472, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // kaydetBttn
            // 
            this.kaydetBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kaydetBttn.Image = global::smoothsis.Properties.Resources.ic_save_black_24dp_1x;
            this.kaydetBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kaydetBttn.Name = "kaydetBttn";
            this.kaydetBttn.Size = new System.Drawing.Size(70, 20);
            this.kaydetBttn.Text = "Kaydet";
            this.kaydetBttn.ToolTipText = "Değişiklikleri Kaydet";
            this.kaydetBttn.Click += new System.EventHandler(this.grupKaydet);
            // 
            // tllStrip
            // 
            this.tllStrip.Name = "tllStrip";
            this.tllStrip.Size = new System.Drawing.Size(6, 23);
            // 
            // temizleBttn
            // 
            this.temizleBttn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.temizleBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.temizleBttn.Name = "temizleBttn";
            this.temizleBttn.Size = new System.Drawing.Size(60, 20);
            this.temizleBttn.Text = "Temizle";
            this.temizleBttn.Click += new System.EventHandler(this.textTemizle);
            // 
            // tllStrip2
            // 
            this.tllStrip2.Name = "tllStrip2";
            this.tllStrip2.Size = new System.Drawing.Size(6, 23);
            // 
            // silBttn
            // 
            this.silBttn.Image = global::smoothsis.Properties.Resources.ic_delete_forever_black_24dp_1x;
            this.silBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.silBttn.Name = "silBttn";
            this.silBttn.Size = new System.Drawing.Size(43, 20);
            this.silBttn.Text = "Sil";
            this.silBttn.Click += new System.EventHandler(this.grupSil);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // iptalButton
            // 
            this.iptalButton.Image = global::smoothsis.Properties.Resources.ic_highlight_off_black_24dp_1x;
            this.iptalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(57, 20);
            this.iptalButton.Text = "Çıkış";
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // Grup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(472, 423);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Grup";
            this.Text = "SMOOTHSIS [ GRUP ]";
            this.Load += new System.EventHandler(this.Grup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grupList;
        private System.Windows.Forms.TextBox grupAdTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton kaydetBttn;
        private System.Windows.Forms.ToolStripButton silBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton iptalButton;
        private System.Windows.Forms.ToolStripSeparator tllStrip;
        private System.Windows.Forms.ToolStripSeparator tllStrip2;
        private System.Windows.Forms.ToolStripButton temizleBttn;
    }
}