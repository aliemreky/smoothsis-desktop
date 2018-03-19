namespace smoothsis
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sirketCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICI ADI";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(22, 207);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(300, 23);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKullaniciAdi_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ŞİFRE";
            // 
            // sirketCombo
            // 
            this.sirketCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sirketCombo.IntegralHeight = false;
            this.sirketCombo.Location = new System.Drawing.Point(22, 145);
            this.sirketCombo.Name = "sirketCombo";
            this.sirketCombo.Size = new System.Drawing.Size(300, 23);
            this.sirketCombo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "ŞİRKET";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(180, 313);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(142, 36);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseMnemonic = false;
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(22, 313);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(141, 36);
            this.btnCikisYap.TabIndex = 5;
            this.btnCikisYap.Text = "ÇIKIŞ";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(22, 267);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(300, 23);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(348, 377);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.sirketCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMOOTHSIS [ GİRİŞ ]";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sirketCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.TextBox txtSifre;
    }
}

