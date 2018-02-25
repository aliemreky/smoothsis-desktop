namespace smoothsis
{
    partial class grup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grup));
            this.grupList = new System.Windows.Forms.DataGridView();
            this.grupAdTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ekleButton = new System.Windows.Forms.Button();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grupList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupList
            // 
            this.grupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupList.Location = new System.Drawing.Point(24, 31);
            this.grupList.Name = "grupList";
            this.grupList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grupList.Size = new System.Drawing.Size(260, 241);
            this.grupList.TabIndex = 0;
            this.grupList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grupList_CellMouseClick);
            this.grupList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grupList_CellMouseDoubleClick);
            // 
            // grupAdTB
            // 
            this.grupAdTB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grupAdTB.Location = new System.Drawing.Point(117, 28);
            this.grupAdTB.Multiline = true;
            this.grupAdTB.Name = "grupAdTB";
            this.grupAdTB.Size = new System.Drawing.Size(278, 35);
            this.grupAdTB.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guncelleButton);
            this.groupBox1.Controls.Add(this.ekleButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grupAdTB);
            this.groupBox1.Location = new System.Drawing.Point(353, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "GRUP ADI";
            // 
            // ekleButton
            // 
            this.ekleButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleButton.Location = new System.Drawing.Point(117, 78);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(131, 36);
            this.ekleButton.TabIndex = 3;
            this.ekleButton.Text = "EKLE";
            this.ekleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.grupEkle);
            // 
            // guncelleButton
            // 
            this.guncelleButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleButton.Location = new System.Drawing.Point(264, 78);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(131, 36);
            this.guncelleButton.TabIndex = 4;
            this.guncelleButton.Text = "GUNCELLE";
            this.guncelleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.grupGuncelle);
            // 
            // silButton
            // 
            this.silButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.Location = new System.Drawing.Point(24, 292);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(131, 36);
            this.silButton.TabIndex = 5;
            this.silButton.Text = "SIL";
            this.silButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.grupSil);
            // 
            // grup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 367);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "grup";
            this.Text = "SMOOTHSIS [ GRUP ]";
            this.Load += new System.EventHandler(this.grup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grupList;
        private System.Windows.Forms.TextBox grupAdTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.Button silButton;
    }
}