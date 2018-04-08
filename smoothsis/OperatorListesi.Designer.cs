namespace smoothsis
{
    partial class OperatorListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorListesi));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.operatorListGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.duzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOperatorListesiGetir = new System.Windows.Forms.Button();
            this.dtpIseBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOperatorDurum = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAramaAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operatorListGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.operatorListGridView);
            this.groupBox2.Location = new System.Drawing.Point(15, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 299);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // operatorListGridView
            // 
            this.operatorListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operatorListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operatorListGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.operatorListGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.operatorListGridView.Location = new System.Drawing.Point(8, 18);
            this.operatorListGridView.MultiSelect = false;
            this.operatorListGridView.Name = "operatorListGridView";
            this.operatorListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.operatorListGridView.Size = new System.Drawing.Size(786, 275);
            this.operatorListGridView.TabIndex = 0;
            this.operatorListGridView.TabStop = false;
            this.operatorListGridView.VirtualMode = true;
            this.operatorListGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.showOperator);
            this.operatorListGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.operatorListGridView_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // duzenleToolStripMenuItem
            // 
            this.duzenleToolStripMenuItem.Name = "duzenleToolStripMenuItem";
            this.duzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.duzenleToolStripMenuItem.Text = "Düzenle";
            this.duzenleToolStripMenuItem.Click += new System.EventHandler(this.operatorDuzenleToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnOperatorListesiGetir);
            this.groupBox1.Controls.Add(this.dtpIseBaslamaTarihi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbOperatorDurum);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtAramaAdiSoyadi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 69);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARAMA";
            // 
            // btnOperatorListesiGetir
            // 
            this.btnOperatorListesiGetir.Location = new System.Drawing.Point(570, 14);
            this.btnOperatorListesiGetir.Name = "btnOperatorListesiGetir";
            this.btnOperatorListesiGetir.Size = new System.Drawing.Size(224, 45);
            this.btnOperatorListesiGetir.TabIndex = 24;
            this.btnOperatorListesiGetir.TabStop = false;
            this.btnOperatorListesiGetir.Text = "OPERATÖR LİSTESİNİ YENİLE";
            this.btnOperatorListesiGetir.UseVisualStyleBackColor = true;
            this.btnOperatorListesiGetir.Click += new System.EventHandler(this.btnOperatorListesiGetir_Click);
            // 
            // dtpIseBaslamaTarihi
            // 
            this.dtpIseBaslamaTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpIseBaslamaTarihi.Location = new System.Drawing.Point(363, 36);
            this.dtpIseBaslamaTarihi.MinimumSize = new System.Drawing.Size(4, 23);
            this.dtpIseBaslamaTarihi.Name = "dtpIseBaslamaTarihi";
            this.dtpIseBaslamaTarihi.Size = new System.Drawing.Size(175, 23);
            this.dtpIseBaslamaTarihi.TabIndex = 23;
            this.dtpIseBaslamaTarihi.ValueChanged += new System.EventHandler(this.dtpIseBaslamaTarihi_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(360, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "İŞE BAŞLAMA TARİHİ";
            // 
            // cbOperatorDurum
            // 
            this.cbOperatorDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperatorDurum.FormattingEnabled = true;
            this.cbOperatorDurum.Location = new System.Drawing.Point(249, 36);
            this.cbOperatorDurum.Name = "cbOperatorDurum";
            this.cbOperatorDurum.Size = new System.Drawing.Size(82, 23);
            this.cbOperatorDurum.TabIndex = 20;
            this.cbOperatorDurum.SelectedIndexChanged += new System.EventHandler(this.cbOperatorDurum_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(246, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "DURUMU";
            // 
            // txtAramaAdiSoyadi
            // 
            this.txtAramaAdiSoyadi.Location = new System.Drawing.Point(8, 36);
            this.txtAramaAdiSoyadi.Name = "txtAramaAdiSoyadi";
            this.txtAramaAdiSoyadi.Size = new System.Drawing.Size(205, 23);
            this.txtAramaAdiSoyadi.TabIndex = 1;
            this.txtAramaAdiSoyadi.TextChanged += new System.EventHandler(this.searchForAdSoyad);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI SOYADI";
            // 
            // OperatorListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(831, 388);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OperatorListesi";
            this.Text = "SMOOTHSIS [ OPERATÖR LİSTESİ ]";
            this.Load += new System.EventHandler(this.OperatorListesi_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operatorListGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView operatorListGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAramaAdiSoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOperatorDurum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem duzenleToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpIseBaslamaTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOperatorListesiGetir;
    }
}