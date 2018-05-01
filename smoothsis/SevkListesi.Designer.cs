namespace smoothsis
{
    partial class SevkListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SevkListesi));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSevkListesiGetir = new System.Windows.Forms.Button();
            this.dtAramaSevkTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAramaIrsaliyeNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAramaSiparisKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sevkListGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sevkListGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnSevkListesiGetir);
            this.groupBox2.Controls.Add(this.dtAramaSevkTarih);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAramaIrsaliyeNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAramaSiparisKodu);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 526);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARAMA";
            // 
            // btnSevkListesiGetir
            // 
            this.btnSevkListesiGetir.Location = new System.Drawing.Point(17, 34);
            this.btnSevkListesiGetir.Name = "btnSevkListesiGetir";
            this.btnSevkListesiGetir.Size = new System.Drawing.Size(195, 43);
            this.btnSevkListesiGetir.TabIndex = 0;
            this.btnSevkListesiGetir.TabStop = false;
            this.btnSevkListesiGetir.Text = "SEVK LİSTESİNİ YENİLE";
            this.btnSevkListesiGetir.UseVisualStyleBackColor = true;
            this.btnSevkListesiGetir.Click += new System.EventHandler(this.btnSevkListesiGetir_Click);
            // 
            // dtAramaSevkTarih
            // 
            this.dtAramaSevkTarih.CustomFormat = "";
            this.dtAramaSevkTarih.Location = new System.Drawing.Point(17, 260);
            this.dtAramaSevkTarih.Name = "dtAramaSevkTarih";
            this.dtAramaSevkTarih.Size = new System.Drawing.Size(195, 23);
            this.dtAramaSevkTarih.TabIndex = 6;
            this.dtAramaSevkTarih.ValueChanged += new System.EventHandler(this.searchForSevkTarih);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "SEVK TARİHİ";
            // 
            // txtAramaIrsaliyeNo
            // 
            this.txtAramaIrsaliyeNo.Location = new System.Drawing.Point(17, 188);
            this.txtAramaIrsaliyeNo.Name = "txtAramaIrsaliyeNo";
            this.txtAramaIrsaliyeNo.Size = new System.Drawing.Size(195, 23);
            this.txtAramaIrsaliyeNo.TabIndex = 2;
            this.txtAramaIrsaliyeNo.TextChanged += new System.EventHandler(this.searchForIrsaliyeNo);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "İRSALİYE NO";
            // 
            // txtAramaSiparisKodu
            // 
            this.txtAramaSiparisKodu.Location = new System.Drawing.Point(17, 120);
            this.txtAramaSiparisKodu.Name = "txtAramaSiparisKodu";
            this.txtAramaSiparisKodu.Size = new System.Drawing.Size(195, 23);
            this.txtAramaSiparisKodu.TabIndex = 1;
            this.txtAramaSiparisKodu.TextChanged += new System.EventHandler(this.searchForSiparisKod);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SİPARİŞ KODU";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sevkListGridView);
            this.groupBox1.Location = new System.Drawing.Point(250, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 526);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // sevkListGridView
            // 
            this.sevkListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sevkListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sevkListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sevkListGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.sevkListGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sevkListGridView.Location = new System.Drawing.Point(6, 13);
            this.sevkListGridView.MultiSelect = false;
            this.sevkListGridView.Name = "sevkListGridView";
            this.sevkListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sevkListGridView.Size = new System.Drawing.Size(795, 507);
            this.sevkListGridView.TabIndex = 19;
            this.sevkListGridView.VirtualMode = true;
            this.sevkListGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sevkListGridView_CellMouseDown);
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
            // SevkListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1069, 541);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SevkListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMOOTHSIS [ SEVK LİSTESİ ]";
            this.Load += new System.EventHandler(this.SevkListesi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sevkListGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSevkListesiGetir;
        private System.Windows.Forms.DateTimePicker dtAramaSevkTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAramaIrsaliyeNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAramaSiparisKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView sevkListGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
    }
}