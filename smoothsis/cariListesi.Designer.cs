namespace smoothsis
{
    partial class CariListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariListesi));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cariListesiGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAramaIl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAramaTcNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAramaVergiDaire = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAramaVergiNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAramaTicariUnvan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAramaAdiSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAramaCariKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cariListesiGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cariListesiGridView);
            this.groupBox2.Location = new System.Drawing.Point(267, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(979, 475);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cariListesiGridView
            // 
            this.cariListesiGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cariListesiGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cariListesiGridView.Location = new System.Drawing.Point(9, 18);
            this.cariListesiGridView.MultiSelect = false;
            this.cariListesiGridView.Name = "cariListesiGridView";
            this.cariListesiGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cariListesiGridView.Size = new System.Drawing.Size(964, 447);
            this.cariListesiGridView.TabIndex = 2;
            this.cariListesiGridView.TabStop = false;
            this.cariListesiGridView.VirtualMode = true;
            this.cariListesiGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cariListesiGridView_CellDoubleClick);
            this.cariListesiGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.cariListesiGridView_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtAramaIl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAramaTcNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAramaVergiDaire);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAramaVergiNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAramaTicariUnvan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAramaAdiSoyadi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAramaCariKodu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 475);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARAMA";
            // 
            // txtAramaIl
            // 
            this.txtAramaIl.Location = new System.Drawing.Point(19, 423);
            this.txtAramaIl.Name = "txtAramaIl";
            this.txtAramaIl.Size = new System.Drawing.Size(205, 23);
            this.txtAramaIl.TabIndex = 7;
            this.txtAramaIl.TextChanged += new System.EventHandler(this.txtAramaIl_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "İL";
            // 
            // txtAramaTcNo
            // 
            this.txtAramaTcNo.Location = new System.Drawing.Point(19, 360);
            this.txtAramaTcNo.Name = "txtAramaTcNo";
            this.txtAramaTcNo.Size = new System.Drawing.Size(205, 23);
            this.txtAramaTcNo.TabIndex = 6;
            this.txtAramaTcNo.TextChanged += new System.EventHandler(this.txtAramaTcNo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "TC NO";
            // 
            // txtAramaVergiDaire
            // 
            this.txtAramaVergiDaire.Location = new System.Drawing.Point(19, 300);
            this.txtAramaVergiDaire.Name = "txtAramaVergiDaire";
            this.txtAramaVergiDaire.Size = new System.Drawing.Size(205, 23);
            this.txtAramaVergiDaire.TabIndex = 5;
            this.txtAramaVergiDaire.TextChanged += new System.EventHandler(this.txtAramaVergiDaire_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "VERGİ DAİRE";
            // 
            // txtAramaVergiNo
            // 
            this.txtAramaVergiNo.Location = new System.Drawing.Point(19, 235);
            this.txtAramaVergiNo.Name = "txtAramaVergiNo";
            this.txtAramaVergiNo.Size = new System.Drawing.Size(205, 23);
            this.txtAramaVergiNo.TabIndex = 4;
            this.txtAramaVergiNo.TextChanged += new System.EventHandler(this.txtAramaVergiNo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "VERGİ NO";
            // 
            // txtAramaTicariUnvan
            // 
            this.txtAramaTicariUnvan.Location = new System.Drawing.Point(19, 173);
            this.txtAramaTicariUnvan.Name = "txtAramaTicariUnvan";
            this.txtAramaTicariUnvan.Size = new System.Drawing.Size(205, 23);
            this.txtAramaTicariUnvan.TabIndex = 3;
            this.txtAramaTicariUnvan.TextChanged += new System.EventHandler(this.txtAramaTicariUnvan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "TİCARİ ÜNVANI";
            // 
            // txtAramaAdiSoyadi
            // 
            this.txtAramaAdiSoyadi.Location = new System.Drawing.Point(19, 112);
            this.txtAramaAdiSoyadi.Name = "txtAramaAdiSoyadi";
            this.txtAramaAdiSoyadi.Size = new System.Drawing.Size(205, 23);
            this.txtAramaAdiSoyadi.TabIndex = 2;
            this.txtAramaAdiSoyadi.TextChanged += new System.EventHandler(this.txtAramaAdiSoyadi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADI SOYADI";
            // 
            // txtAramaCariKodu
            // 
            this.txtAramaCariKodu.Location = new System.Drawing.Point(19, 56);
            this.txtAramaCariKodu.Name = "txtAramaCariKodu";
            this.txtAramaCariKodu.Size = new System.Drawing.Size(205, 23);
            this.txtAramaCariKodu.TabIndex = 1;
            this.txtAramaCariKodu.TextChanged += new System.EventHandler(this.txtAramaCariKodu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARİ KODU";
            // 
            // CariListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1260, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CariListesi";
            this.Text = "SMOOTHSIS [ CARİ LİSTESİ ]";
            this.Load += new System.EventHandler(this.CariListesi_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cariListesiGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView cariListesiGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAramaIl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAramaTcNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAramaVergiDaire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAramaVergiNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAramaTicariUnvan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAramaAdiSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAramaCariKodu;
    }
}