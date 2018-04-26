namespace smoothsis
{
    partial class StokDepoDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokDepoDuzenle));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.kaydetBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.temizleBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.iptalButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetBttn,
            this.toolStripSeparator2,
            this.temizleBttn,
            this.toolStripSeparator5,
            this.iptalButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 1, 2, 1);
            this.toolStrip1.Size = new System.Drawing.Size(455, 32);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // kaydetBttn
            // 
            this.kaydetBttn.Image = global::smoothsis.Properties.Resources.ic_save_black_24dp_1x;
            this.kaydetBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kaydetBttn.Name = "kaydetBttn";
            this.kaydetBttn.Size = new System.Drawing.Size(68, 27);
            this.kaydetBttn.Text = "Kaydet";
            this.kaydetBttn.ToolTipText = "Değişiklikleri Kaydet";
            this.kaydetBttn.Click += new System.EventHandler(this.kaydetBttn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(12, 28);
            // 
            // temizleBttn
            // 
            this.temizleBttn.Image = global::smoothsis.Properties.Resources.ic_delete_forever_black_24dp_1x;
            this.temizleBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.temizleBttn.Name = "temizleBttn";
            this.temizleBttn.Size = new System.Drawing.Size(71, 27);
            this.temizleBttn.Text = "Temizle";
            this.temizleBttn.Click += new System.EventHandler(this.temizleBttn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.AutoSize = false;
            this.toolStripSeparator5.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(12, 28);
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
            this.groupBox1.Controls.Add(this.txtMiktar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 70);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(106, 28);
            this.txtMiktar.Multiline = true;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(314, 25);
            this.txtMiktar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "STOK MİKTARI *";
            // 
            // StokDepoDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(455, 123);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StokDepoDuzenle";
            this.Text = "SMOOTHSIS [ STOK DEPO DÜZENLE ]";
            this.Load += new System.EventHandler(this.StokDepoDuzenle_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton kaydetBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton temizleBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton iptalButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label2;
    }
}