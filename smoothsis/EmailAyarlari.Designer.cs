namespace smoothsis
{
    partial class EmailAyarlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailAyarlari));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.kaydetBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.iptalButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListEkle = new System.Windows.Forms.Button();
            this.listGonderilecekAdresler = new System.Windows.Forms.ListBox();
            this.txtListEkle = new System.Windows.Forms.TextBox();
            this.txtEmailGonderenSifre = new System.Windows.Forms.TextBox();
            this.txtEmailGonderAdSoyad = new System.Windows.Forms.TextBox();
            this.txtEmailGonderenMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.toolStripSeparator4,
            this.iptalButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 1, 2, 1);
            this.toolStrip1.Size = new System.Drawing.Size(482, 32);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // kaydetBttn
            // 
            this.kaydetBttn.Image = ((System.Drawing.Image)(resources.GetObject("kaydetBttn.Image")));
            this.kaydetBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kaydetBttn.Name = "kaydetBttn";
            this.kaydetBttn.Size = new System.Drawing.Size(68, 27);
            this.kaydetBttn.Text = "Kaydet";
            this.kaydetBttn.ToolTipText = "Değişiklikleri Kaydet";
            this.kaydetBttn.Click += new System.EventHandler(this.kaydetBttn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.BackColor = System.Drawing.Color.White;
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(12, 28);
            // 
            // iptalButton
            // 
            this.iptalButton.Image = ((System.Drawing.Image)(resources.GetObject("iptalButton.Image")));
            this.iptalButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(54, 27);
            this.iptalButton.Text = "Çıkış";
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListEkle);
            this.groupBox1.Controls.Add(this.listGonderilecekAdresler);
            this.groupBox1.Controls.Add(this.txtListEkle);
            this.groupBox1.Controls.Add(this.txtEmailGonderenSifre);
            this.groupBox1.Controls.Add(this.txtEmailGonderAdSoyad);
            this.groupBox1.Controls.Add(this.txtEmailGonderenMail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmailPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmailHost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 370);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "E-Posta Ayarları";
            // 
            // btnListEkle
            // 
            this.btnListEkle.Location = new System.Drawing.Point(350, 330);
            this.btnListEkle.Name = "btnListEkle";
            this.btnListEkle.Size = new System.Drawing.Size(81, 24);
            this.btnListEkle.TabIndex = 7;
            this.btnListEkle.Text = "EKLE";
            this.btnListEkle.UseVisualStyleBackColor = true;
            this.btnListEkle.Click += new System.EventHandler(this.btnListEkle_Click);
            // 
            // listGonderilecekAdresler
            // 
            this.listGonderilecekAdresler.FormattingEnabled = true;
            this.listGonderilecekAdresler.ItemHeight = 15;
            this.listGonderilecekAdresler.Location = new System.Drawing.Point(24, 227);
            this.listGonderilecekAdresler.Name = "listGonderilecekAdresler";
            this.listGonderilecekAdresler.Size = new System.Drawing.Size(407, 94);
            this.listGonderilecekAdresler.TabIndex = 4;
            this.listGonderilecekAdresler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listGonderilecekAdresler_KeyPress);
            // 
            // txtListEkle
            // 
            this.txtListEkle.Location = new System.Drawing.Point(24, 331);
            this.txtListEkle.Name = "txtListEkle";
            this.txtListEkle.Size = new System.Drawing.Size(320, 23);
            this.txtListEkle.TabIndex = 6;
            this.txtListEkle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtListEkle_KeyPress);
            // 
            // txtEmailGonderenSifre
            // 
            this.txtEmailGonderenSifre.Location = new System.Drawing.Point(140, 168);
            this.txtEmailGonderenSifre.Name = "txtEmailGonderenSifre";
            this.txtEmailGonderenSifre.Size = new System.Drawing.Size(291, 23);
            this.txtEmailGonderenSifre.TabIndex = 5;
            // 
            // txtEmailGonderAdSoyad
            // 
            this.txtEmailGonderAdSoyad.Location = new System.Drawing.Point(140, 98);
            this.txtEmailGonderAdSoyad.Name = "txtEmailGonderAdSoyad";
            this.txtEmailGonderAdSoyad.Size = new System.Drawing.Size(291, 23);
            this.txtEmailGonderAdSoyad.TabIndex = 3;
            // 
            // txtEmailGonderenMail
            // 
            this.txtEmailGonderenMail.Location = new System.Drawing.Point(140, 132);
            this.txtEmailGonderenMail.Name = "txtEmailGonderenMail";
            this.txtEmailGonderenMail.Size = new System.Drawing.Size(291, 23);
            this.txtEmailGonderenMail.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email Gönderilecek Adresler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gönderen Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gönderen Ad Soyad";
            // 
            // txtEmailPort
            // 
            this.txtEmailPort.Location = new System.Drawing.Point(140, 61);
            this.txtEmailPort.Name = "txtEmailPort";
            this.txtEmailPort.Size = new System.Drawing.Size(291, 23);
            this.txtEmailPort.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gönderen Mail";
            // 
            // txtEmailHost
            // 
            this.txtEmailHost.Location = new System.Drawing.Point(140, 26);
            this.txtEmailHost.Name = "txtEmailHost";
            this.txtEmailHost.Size = new System.Drawing.Size(291, 23);
            this.txtEmailHost.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email Host";
            // 
            // EmailAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(482, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmailAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMOOTHSIS [ E-POSTA PANELİ ]";
            this.Load += new System.EventHandler(this.EmailAyarlari_Load);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton iptalButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListEkle;
        private System.Windows.Forms.ListBox listGonderilecekAdresler;
        private System.Windows.Forms.TextBox txtListEkle;
        private System.Windows.Forms.TextBox txtEmailGonderenSifre;
        private System.Windows.Forms.TextBox txtEmailGonderAdSoyad;
        private System.Windows.Forms.TextBox txtEmailGonderenMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmailPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmailHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}