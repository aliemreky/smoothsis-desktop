namespace smoothsis
{
    partial class OperatorCalismaRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorCalismaRaporu));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListeyiYenile = new System.Windows.Forms.Button();
            this.btnTarihAraligi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OperatorRaporuGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.excelButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iptalButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperatorRaporuGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListeyiYenile);
            this.groupBox2.Controls.Add(this.btnTarihAraligi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtEndDate);
            this.groupBox2.Controls.Add(this.dtStartDate);
            this.groupBox2.Location = new System.Drawing.Point(16, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(892, 71);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtre";
            // 
            // btnListeyiYenile
            // 
            this.btnListeyiYenile.Location = new System.Drawing.Point(768, 23);
            this.btnListeyiYenile.Name = "btnListeyiYenile";
            this.btnListeyiYenile.Size = new System.Drawing.Size(115, 30);
            this.btnListeyiYenile.TabIndex = 2;
            this.btnListeyiYenile.Text = "TÜM KAYITLAR";
            this.btnListeyiYenile.UseVisualStyleBackColor = true;
            this.btnListeyiYenile.Click += new System.EventHandler(this.btnListeyiYenile_Click);
            // 
            // btnTarihAraligi
            // 
            this.btnTarihAraligi.Location = new System.Drawing.Point(636, 23);
            this.btnTarihAraligi.Name = "btnTarihAraligi";
            this.btnTarihAraligi.Size = new System.Drawing.Size(98, 30);
            this.btnTarihAraligi.TabIndex = 2;
            this.btnTarihAraligi.Text = "UYGULA";
            this.btnTarihAraligi.UseVisualStyleBackColor = true;
            this.btnTarihAraligi.Click += new System.EventHandler(this.btnTarihAraligi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(401, 27);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(215, 23);
            this.dtEndDate.TabIndex = 0;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(108, 27);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(209, 23);
            this.dtStartDate.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OperatorRaporuGridView);
            this.groupBox1.Location = new System.Drawing.Point(16, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 358);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // OperatorRaporuGridView
            // 
            this.OperatorRaporuGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OperatorRaporuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperatorRaporuGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OperatorRaporuGridView.Location = new System.Drawing.Point(6, 16);
            this.OperatorRaporuGridView.MultiSelect = false;
            this.OperatorRaporuGridView.Name = "OperatorRaporuGridView";
            this.OperatorRaporuGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OperatorRaporuGridView.Size = new System.Drawing.Size(880, 335);
            this.OperatorRaporuGridView.TabIndex = 3;
            this.OperatorRaporuGridView.TabStop = false;
            this.OperatorRaporuGridView.VirtualMode = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelButton,
            this.toolStripSeparator2,
            this.iptalButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(12, 1, 2, 1);
            this.toolStrip1.Size = new System.Drawing.Size(926, 32);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // excelButton
            // 
            this.excelButton.Image = global::smoothsis.Properties.Resources.ic_save_black_24dp_1x;
            this.excelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excelButton.Name = "excelButton";
            this.excelButton.Size = new System.Drawing.Size(101, 27);
            this.excelButton.Text = "Excel\'e Aktar";
            this.excelButton.ToolTipText = "Değişiklikleri Kaydet";
            this.excelButton.Click += new System.EventHandler(this.excelButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(12, 28);
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
            // OperatorCalismaRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(926, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OperatorCalismaRaporu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMOOTHSIS [ OPERATÖR RAPORU ]";
            this.Load += new System.EventHandler(this.OperatorCalismaRaporu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OperatorRaporuGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnListeyiYenile;
        private System.Windows.Forms.Button btnTarihAraligi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView OperatorRaporuGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton excelButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton iptalButton;
    }
}