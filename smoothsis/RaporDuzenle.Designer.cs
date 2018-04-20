namespace smoothsis
{
    partial class RaporDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporDuzenle));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.kaydetBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sillBttn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.iptalButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.operator_result = new System.Windows.Forms.ListView();
            this.operator_result_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operator_result_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operator_list = new System.Windows.Forms.ListView();
            this.operator_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.operator_adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnComeBackOperator = new System.Windows.Forms.Button();
            this.btnMoveOperator = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRaporVardiya = new System.Windows.Forms.ComboBox();
            this.txtIskartaNedeni = new System.Windows.Forms.TextBox();
            this.txtBeslenenMiktar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFireMiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpRaporTarih = new System.Windows.Forms.DateTimePicker();
            this.txtUretilenMiktar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFireNedeni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIskartaMiktar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.sillBttn,
            this.toolStripSeparator3,
            this.iptalButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 1, 2, 1);
            this.toolStrip1.Size = new System.Drawing.Size(961, 32);
            this.toolStrip1.TabIndex = 20;
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(12, 28);
            // 
            // sillBttn
            // 
            this.sillBttn.Image = global::smoothsis.Properties.Resources.ic_delete_forever_black_24dp_1x;
            this.sillBttn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sillBttn.Name = "sillBttn";
            this.sillBttn.Size = new System.Drawing.Size(41, 27);
            this.sillBttn.Text = "Sil";
            this.sillBttn.Click += new System.EventHandler(this.sillBttn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(12, 28);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAciklama);
            this.groupBox2.Location = new System.Drawing.Point(500, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 150);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAPOR AÇIKLAMASI";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(13, 25);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(420, 110);
            this.txtAciklama.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.operator_result);
            this.groupBox3.Controls.Add(this.operator_list);
            this.groupBox3.Controls.Add(this.btnComeBackOperator);
            this.groupBox3.Controls.Add(this.btnMoveOperator);
            this.groupBox3.Location = new System.Drawing.Point(500, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 222);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OPERATÖR İŞLEMLERİ";
            // 
            // operator_result
            // 
            this.operator_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.operator_result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.operator_result_id,
            this.operator_result_name});
            this.operator_result.FullRowSelect = true;
            this.operator_result.GridLines = true;
            this.operator_result.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.operator_result.Location = new System.Drawing.Point(262, 26);
            this.operator_result.Name = "operator_result";
            this.operator_result.Size = new System.Drawing.Size(171, 179);
            this.operator_result.TabIndex = 0;
            this.operator_result.TabStop = false;
            this.operator_result.UseCompatibleStateImageBehavior = false;
            this.operator_result.View = System.Windows.Forms.View.Details;
            // 
            // operator_result_id
            // 
            this.operator_result_id.Text = "ID";
            this.operator_result_id.Width = 0;
            // 
            // operator_result_name
            // 
            this.operator_result_name.Text = "OPERATOR ADI";
            this.operator_result_name.Width = 147;
            // 
            // operator_list
            // 
            this.operator_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.operator_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.operator_id,
            this.operator_adi});
            this.operator_list.FullRowSelect = true;
            this.operator_list.GridLines = true;
            this.operator_list.Location = new System.Drawing.Point(13, 26);
            this.operator_list.Name = "operator_list";
            this.operator_list.Size = new System.Drawing.Size(183, 179);
            this.operator_list.TabIndex = 0;
            this.operator_list.TabStop = false;
            this.operator_list.UseCompatibleStateImageBehavior = false;
            this.operator_list.View = System.Windows.Forms.View.Details;
            // 
            // operator_id
            // 
            this.operator_id.Text = "ID";
            this.operator_id.Width = 0;
            // 
            // operator_adi
            // 
            this.operator_adi.Text = "OPERATOR ADI";
            this.operator_adi.Width = 154;
            // 
            // btnComeBackOperator
            // 
            this.btnComeBackOperator.BackColor = System.Drawing.Color.Tomato;
            this.btnComeBackOperator.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnComeBackOperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComeBackOperator.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnComeBackOperator.Location = new System.Drawing.Point(211, 117);
            this.btnComeBackOperator.Name = "btnComeBackOperator";
            this.btnComeBackOperator.Size = new System.Drawing.Size(37, 37);
            this.btnComeBackOperator.TabIndex = 0;
            this.btnComeBackOperator.TabStop = false;
            this.btnComeBackOperator.Text = "<";
            this.btnComeBackOperator.UseVisualStyleBackColor = false;
            this.btnComeBackOperator.Click += new System.EventHandler(this.btnComeBackOperator_Click);
            // 
            // btnMoveOperator
            // 
            this.btnMoveOperator.BackColor = System.Drawing.Color.YellowGreen;
            this.btnMoveOperator.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnMoveOperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveOperator.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMoveOperator.Location = new System.Drawing.Point(211, 61);
            this.btnMoveOperator.Name = "btnMoveOperator";
            this.btnMoveOperator.Size = new System.Drawing.Size(37, 37);
            this.btnMoveOperator.TabIndex = 0;
            this.btnMoveOperator.TabStop = false;
            this.btnMoveOperator.Text = ">";
            this.btnMoveOperator.UseVisualStyleBackColor = false;
            this.btnMoveOperator.Click += new System.EventHandler(this.btnMoveOperator_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRaporVardiya);
            this.groupBox1.Controls.Add(this.txtIskartaNedeni);
            this.groupBox1.Controls.Add(this.txtBeslenenMiktar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtFireMiktar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpRaporTarih);
            this.groupBox1.Controls.Add(this.txtUretilenMiktar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFireNedeni);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIskartaMiktar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 383);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RAPOR BİLGİLERİ";
            // 
            // cbRaporVardiya
            // 
            this.cbRaporVardiya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRaporVardiya.FormattingEnabled = true;
            this.cbRaporVardiya.Location = new System.Drawing.Point(136, 65);
            this.cbRaporVardiya.Name = "cbRaporVardiya";
            this.cbRaporVardiya.Size = new System.Drawing.Size(306, 23);
            this.cbRaporVardiya.TabIndex = 2;
            // 
            // txtIskartaNedeni
            // 
            this.txtIskartaNedeni.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIskartaNedeni.Location = new System.Drawing.Point(136, 311);
            this.txtIskartaNedeni.Multiline = true;
            this.txtIskartaNedeni.Name = "txtIskartaNedeni";
            this.txtIskartaNedeni.Size = new System.Drawing.Size(306, 57);
            this.txtIskartaNedeni.TabIndex = 9;
            // 
            // txtBeslenenMiktar
            // 
            this.txtBeslenenMiktar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBeslenenMiktar.Location = new System.Drawing.Point(136, 103);
            this.txtBeslenenMiktar.Name = "txtBeslenenMiktar";
            this.txtBeslenenMiktar.Size = new System.Drawing.Size(306, 23);
            this.txtBeslenenMiktar.TabIndex = 3;
            this.txtBeslenenMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimalValidate);
            this.txtBeslenenMiktar.Leave += new System.EventHandler(this.txtBeslenenMiktar_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(13, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "BESLENEN MİKTAR *";
            // 
            // txtFireMiktar
            // 
            this.txtFireMiktar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFireMiktar.Location = new System.Drawing.Point(136, 176);
            this.txtFireMiktar.Name = "txtFireMiktar";
            this.txtFireMiktar.Size = new System.Drawing.Size(306, 23);
            this.txtFireMiktar.TabIndex = 6;
            this.txtFireMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimalValidate);
            this.txtFireMiktar.Leave += new System.EventHandler(this.txtFireMiktar_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "FİRE MİKTARI *";
            // 
            // dtpRaporTarih
            // 
            this.dtpRaporTarih.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpRaporTarih.Location = new System.Drawing.Point(136, 27);
            this.dtpRaporTarih.MinimumSize = new System.Drawing.Size(4, 23);
            this.dtpRaporTarih.Name = "dtpRaporTarih";
            this.dtpRaporTarih.Size = new System.Drawing.Size(306, 23);
            this.dtpRaporTarih.TabIndex = 1;
            // 
            // txtUretilenMiktar
            // 
            this.txtUretilenMiktar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUretilenMiktar.Location = new System.Drawing.Point(136, 141);
            this.txtUretilenMiktar.Name = "txtUretilenMiktar";
            this.txtUretilenMiktar.Size = new System.Drawing.Size(306, 23);
            this.txtUretilenMiktar.TabIndex = 4;
            this.txtUretilenMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimalValidate);
            this.txtUretilenMiktar.Leave += new System.EventHandler(this.txtUretilenMiktar_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "ÜRETİLEN MİKTAR *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(54, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "FİRE NEDENİ";
            // 
            // txtFireNedeni
            // 
            this.txtFireNedeni.AcceptsReturn = true;
            this.txtFireNedeni.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFireNedeni.Location = new System.Drawing.Point(136, 210);
            this.txtFireNedeni.Multiline = true;
            this.txtFireNedeni.Name = "txtFireNedeni";
            this.txtFireNedeni.Size = new System.Drawing.Size(306, 57);
            this.txtFireNedeni.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(36, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "RAPOR TARİHİ *";
            // 
            // txtIskartaMiktar
            // 
            this.txtIskartaMiktar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIskartaMiktar.Location = new System.Drawing.Point(136, 277);
            this.txtIskartaMiktar.Name = "txtIskartaMiktar";
            this.txtIskartaMiktar.Size = new System.Drawing.Size(306, 23);
            this.txtIskartaMiktar.TabIndex = 8;
            this.txtIskartaMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.decimalValidate);
            this.txtIskartaMiktar.Leave += new System.EventHandler(this.txtIskartaMiktar_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(30, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "ISKARTA NEDENİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(18, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "ISKARTA MİKTARI *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "VARDİYA *";
            // 
            // RaporDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(961, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RaporDuzenle";
            this.Text = "SMOOTHSIS [ RAPOR DÜZENLE ]";
            this.Load += new System.EventHandler(this.RaporDuzenle_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton kaydetBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton sillBttn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton iptalButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView operator_result;
        private System.Windows.Forms.ColumnHeader operator_result_id;
        private System.Windows.Forms.ColumnHeader operator_result_name;
        private System.Windows.Forms.ListView operator_list;
        private System.Windows.Forms.ColumnHeader operator_id;
        private System.Windows.Forms.ColumnHeader operator_adi;
        private System.Windows.Forms.Button btnComeBackOperator;
        private System.Windows.Forms.Button btnMoveOperator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbRaporVardiya;
        private System.Windows.Forms.TextBox txtIskartaNedeni;
        private System.Windows.Forms.TextBox txtBeslenenMiktar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFireMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpRaporTarih;
        private System.Windows.Forms.TextBox txtUretilenMiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFireNedeni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIskartaMiktar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}