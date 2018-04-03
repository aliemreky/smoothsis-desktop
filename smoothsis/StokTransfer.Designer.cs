namespace smoothsis
{
    partial class StokTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokTransfer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.kaydetBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.temizleBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iptalButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStokDepo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sourceDepoLokasyonLabel = new System.Windows.Forms.TextBox();
            this.sourceDepoNameLabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sourceStokBirimLabel = new System.Windows.Forms.TextBox();
            this.sourceStokMiktarLabel = new System.Windows.Forms.TextBox();
            this.sourceStokAdiLabel = new System.Windows.Forms.TextBox();
            this.destBirimLabel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetBttn,
            this.toolStripSeparator1,
            this.temizleBttn,
            this.toolStripSeparator2,
            this.iptalButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(649, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // kaydetBttn
            // 
            this.kaydetBttn.Image = global::smoothsis.Properties.Resources.ic_save_black_24dp_1x;
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
            // temizleBttn
            // 
            this.temizleBttn.Image = global::smoothsis.Properties.Resources.ic_delete_forever_black_24dp_1x;
            this.temizleBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.temizleBttn.Name = "temizleBttn";
            this.temizleBttn.Size = new System.Drawing.Size(76, 20);
            this.temizleBttn.Text = "Temizle";
            this.temizleBttn.Click += new System.EventHandler(this.temizleBttn_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.destBirimLabel);
            this.groupBox1.Controls.Add(this.cbStokDepo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(374, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 200);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRANSFER DEPO";
            // 
            // cbStokDepo
            // 
            this.cbStokDepo.DisplayMember = "GRUP_ADI";
            this.cbStokDepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStokDepo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbStokDepo.FormattingEnabled = true;
            this.cbStokDepo.Location = new System.Drawing.Point(9, 74);
            this.cbStokDepo.Name = "cbStokDepo";
            this.cbStokDepo.Size = new System.Drawing.Size(247, 23);
            this.cbStokDepo.TabIndex = 0;
            this.cbStokDepo.ValueMember = "GRUP_INCKEY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "TRANSFER YERİ";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(9, 133);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(95, 23);
            this.txtMiktar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "MİKTAR";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sourceDepoLokasyonLabel);
            this.groupBox2.Controls.Add(this.sourceDepoNameLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(14, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 82);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KAYNAK DEPO";
            // 
            // sourceDepoLokasyonLabel
            // 
            this.sourceDepoLokasyonLabel.Enabled = false;
            this.sourceDepoLokasyonLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sourceDepoLokasyonLabel.Location = new System.Drawing.Point(84, 50);
            this.sourceDepoLokasyonLabel.Name = "sourceDepoLokasyonLabel";
            this.sourceDepoLokasyonLabel.ReadOnly = true;
            this.sourceDepoLokasyonLabel.Size = new System.Drawing.Size(255, 23);
            this.sourceDepoLokasyonLabel.TabIndex = 20;
            // 
            // sourceDepoNameLabel
            // 
            this.sourceDepoNameLabel.Enabled = false;
            this.sourceDepoNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sourceDepoNameLabel.Location = new System.Drawing.Point(84, 21);
            this.sourceDepoNameLabel.Name = "sourceDepoNameLabel";
            this.sourceDepoNameLabel.ReadOnly = true;
            this.sourceDepoNameLabel.Size = new System.Drawing.Size(255, 23);
            this.sourceDepoNameLabel.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "LOKASYON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "DEPO ADI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(31, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "BİRİM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "STOK ADI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "MİKTAR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sourceStokBirimLabel);
            this.groupBox3.Controls.Add(this.sourceStokMiktarLabel);
            this.groupBox3.Controls.Add(this.sourceStokAdiLabel);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(14, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 107);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "STOK BİLGİLERİ";
            // 
            // sourceStokBirimLabel
            // 
            this.sourceStokBirimLabel.Enabled = false;
            this.sourceStokBirimLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sourceStokBirimLabel.Location = new System.Drawing.Point(84, 78);
            this.sourceStokBirimLabel.Name = "sourceStokBirimLabel";
            this.sourceStokBirimLabel.ReadOnly = true;
            this.sourceStokBirimLabel.Size = new System.Drawing.Size(255, 23);
            this.sourceStokBirimLabel.TabIndex = 23;
            // 
            // sourceStokMiktarLabel
            // 
            this.sourceStokMiktarLabel.Enabled = false;
            this.sourceStokMiktarLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sourceStokMiktarLabel.Location = new System.Drawing.Point(84, 49);
            this.sourceStokMiktarLabel.Name = "sourceStokMiktarLabel";
            this.sourceStokMiktarLabel.ReadOnly = true;
            this.sourceStokMiktarLabel.Size = new System.Drawing.Size(255, 23);
            this.sourceStokMiktarLabel.TabIndex = 22;
            // 
            // sourceStokAdiLabel
            // 
            this.sourceStokAdiLabel.Enabled = false;
            this.sourceStokAdiLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sourceStokAdiLabel.Location = new System.Drawing.Point(84, 22);
            this.sourceStokAdiLabel.Name = "sourceStokAdiLabel";
            this.sourceStokAdiLabel.ReadOnly = true;
            this.sourceStokAdiLabel.Size = new System.Drawing.Size(255, 23);
            this.sourceStokAdiLabel.TabIndex = 21;
            // 
            // destBirimLabel
            // 
            this.destBirimLabel.Enabled = false;
            this.destBirimLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.destBirimLabel.Location = new System.Drawing.Point(169, 133);
            this.destBirimLabel.Name = "destBirimLabel";
            this.destBirimLabel.ReadOnly = true;
            this.destBirimLabel.Size = new System.Drawing.Size(87, 23);
            this.destBirimLabel.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(123, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "BİRİM";
            // 
            // StokTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(649, 242);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StokTransfer";
            this.Text = "SMOOTHSIS [ STOK TRANSFER ]";
            this.Load += new System.EventHandler(this.StokTransfer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton kaydetBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton temizleBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton iptalButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbStokDepo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sourceDepoNameLabel;
        private System.Windows.Forms.TextBox sourceDepoLokasyonLabel;
        private System.Windows.Forms.TextBox sourceStokAdiLabel;
        private System.Windows.Forms.TextBox sourceStokMiktarLabel;
        private System.Windows.Forms.TextBox sourceStokBirimLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox destBirimLabel;
    }
}