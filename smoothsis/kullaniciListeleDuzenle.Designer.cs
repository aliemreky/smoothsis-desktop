namespace smoothsis
{
    partial class KullaniciListeleDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciListeleDuzenle));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kullaniciListesiGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGrupKey = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.kaydetBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.iptalButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciListesiGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kullaniciListesiGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(815, 271);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KULLANICI LİSTESİ";
            // 
            // kullaniciListesiGridView
            // 
            this.kullaniciListesiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kullaniciListesiGridView.Location = new System.Drawing.Point(13, 24);
            this.kullaniciListesiGridView.MultiSelect = false;
            this.kullaniciListesiGridView.Name = "kullaniciListesiGridView";
            this.kullaniciListesiGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kullaniciListesiGridView.Size = new System.Drawing.Size(787, 233);
            this.kullaniciListesiGridView.TabIndex = 0;
            this.kullaniciListesiGridView.TabStop = false;
            this.kullaniciListesiGridView.VirtualMode = true;
            this.kullaniciListesiGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.fillDataToTextBoxs);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGrupKey);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 152);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KULLANICI DÜZENLE";
            // 
            // cbGrupKey
            // 
            this.cbGrupKey.DisplayMember = "GRUP_ADI";
            this.cbGrupKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupKey.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGrupKey.FormattingEnabled = true;
            this.cbGrupKey.Location = new System.Drawing.Point(92, 25);
            this.cbGrupKey.Name = "cbGrupKey";
            this.cbGrupKey.Size = new System.Drawing.Size(299, 23);
            this.cbGrupKey.TabIndex = 28;
            this.cbGrupKey.Tag = "";
            this.cbGrupKey.ValueMember = "GRUP_INCKEY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "YETKİ GRUBU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "AD SOYAD *";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(469, 102);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 25);
            this.txtEmail.TabIndex = 26;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(92, 64);
            this.txtAdSoyad.Multiline = true;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(299, 25);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(421, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "EMAİL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(41, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "ŞİFRE *";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(469, 63);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(310, 25);
            this.txtTelefon.TabIndex = 24;
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkIsTel);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(92, 103);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(299, 25);
            this.txtSifre.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(407, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "TELEFON";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetBttn,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.iptalButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 1, 2, 1);
            this.toolStrip1.Size = new System.Drawing.Size(842, 32);
            this.toolStrip1.TabIndex = 14;
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
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::smoothsis.Properties.Resources.ic_delete_forever_black_24dp_1x;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(41, 27);
            this.toolStripButton1.Text = "Sil";
            this.toolStripButton1.Click += new System.EventHandler(this.silBttn_Click);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(12, 28);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(12, 28);
            // 
            // KullaniciListeleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(842, 486);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciListeleDuzenle";
            this.Text = "SMOOTHSIS [ KULLANICI LİSTESİ & DÜZENLE ]";
            this.Load += new System.EventHandler(this.KullaniciListeleDuzenle_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciListesiGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView kullaniciListesiGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton kaydetBttn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton iptalButton;
        private System.Windows.Forms.ComboBox cbGrupKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}