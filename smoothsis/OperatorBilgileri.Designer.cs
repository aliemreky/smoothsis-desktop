namespace smoothsis
{
    partial class OperatorBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OperatorBilgileri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOperatorBaslamaTarih = new System.Windows.Forms.TextBox();
            this.txtOperatorDurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOperatorAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOperatorBaslamaTarih);
            this.groupBox1.Controls.Add(this.txtOperatorDurum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtOperatorAdiSoyadi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 163);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPERATÖR BİLGİLERİ";
            // 
            // txtOperatorBaslamaTarih
            // 
            this.txtOperatorBaslamaTarih.Enabled = false;
            this.txtOperatorBaslamaTarih.Location = new System.Drawing.Point(125, 106);
            this.txtOperatorBaslamaTarih.Name = "txtOperatorBaslamaTarih";
            this.txtOperatorBaslamaTarih.ReadOnly = true;
            this.txtOperatorBaslamaTarih.Size = new System.Drawing.Size(295, 23);
            this.txtOperatorBaslamaTarih.TabIndex = 23;
            // 
            // txtOperatorDurum
            // 
            this.txtOperatorDurum.Enabled = false;
            this.txtOperatorDurum.Location = new System.Drawing.Point(125, 66);
            this.txtOperatorDurum.Name = "txtOperatorDurum";
            this.txtOperatorDurum.ReadOnly = true;
            this.txtOperatorDurum.Size = new System.Drawing.Size(295, 23);
            this.txtOperatorDurum.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "BAŞLAMA TARİHİ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(51, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "DURUMU";
            // 
            // txtOperatorAdiSoyadi
            // 
            this.txtOperatorAdiSoyadi.Enabled = false;
            this.txtOperatorAdiSoyadi.Location = new System.Drawing.Point(125, 28);
            this.txtOperatorAdiSoyadi.Name = "txtOperatorAdiSoyadi";
            this.txtOperatorAdiSoyadi.ReadOnly = true;
            this.txtOperatorAdiSoyadi.Size = new System.Drawing.Size(295, 23);
            this.txtOperatorAdiSoyadi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADI SOYADI";
            // 
            // OperatorBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(453, 187);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OperatorBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMOOTHSIS [ OPERATÖR BİLGİLERİ ]";
            this.Load += new System.EventHandler(this.OperatorBilgileri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOperatorAdiSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOperatorBaslamaTarih;
        private System.Windows.Forms.TextBox txtOperatorDurum;
    }
}