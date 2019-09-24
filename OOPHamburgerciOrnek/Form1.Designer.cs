namespace OOPHamburgerciOrnek
{
    partial class Form1
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
            this.cbMenuler = new System.Windows.Forms.ComboBox();
            this.gbEkstralar = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiparisAl = new System.Windows.Forms.Button();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.gbBoyut = new System.Windows.Forms.GroupBox();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.SiparisSil = new System.Windows.Forms.Button();
            this.gbEkstralar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.gbBoyut.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMenuler
            // 
            this.cbMenuler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenuler.FormattingEnabled = true;
            this.cbMenuler.Location = new System.Drawing.Point(13, 34);
            this.cbMenuler.Margin = new System.Windows.Forms.Padding(2);
            this.cbMenuler.Name = "cbMenuler";
            this.cbMenuler.Size = new System.Drawing.Size(172, 21);
            this.cbMenuler.TabIndex = 0;
            // 
            // gbEkstralar
            // 
            this.gbEkstralar.Controls.Add(this.checkBox6);
            this.gbEkstralar.Controls.Add(this.checkBox5);
            this.gbEkstralar.Controls.Add(this.checkBox3);
            this.gbEkstralar.Controls.Add(this.checkBox4);
            this.gbEkstralar.Controls.Add(this.checkBox2);
            this.gbEkstralar.Controls.Add(this.checkBox1);
            this.gbEkstralar.Location = new System.Drawing.Point(13, 130);
            this.gbEkstralar.Margin = new System.Windows.Forms.Padding(2);
            this.gbEkstralar.Name = "gbEkstralar";
            this.gbEkstralar.Padding = new System.Windows.Forms.Padding(2);
            this.gbEkstralar.Size = new System.Drawing.Size(171, 129);
            this.gbEkstralar.TabIndex = 1;
            this.gbEkstralar.TabStop = false;
            this.gbEkstralar.Text = "Ekstralar:";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(82, 92);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(57, 17);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Tag = "0,3";
            this.checkBox6.Text = "Hardal";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(82, 59);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(69, 17);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Tag = "0,1";
            this.checkBox5.Text = "Mayonez";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(4, 92);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(53, 17);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Tag = "1,2";
            this.checkBox3.Text = "Turşu";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(82, 29);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(79, 17);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Tag = "1";
            this.checkBox4.Text = "Ranch Sos";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(4, 59);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 17);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Tag = "0,1";
            this.checkBox2.Text = "Ketçap";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(4, 29);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "0,5";
            this.checkBox1.Text = "Mısır";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(94, 285);
            this.nmrAdet.Margin = new System.Windows.Forms.Padding(2);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(90, 20);
            this.nmrAdet.TabIndex = 2;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menü Seç: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adet:";
            // 
            // btnSiparisAl
            // 
            this.btnSiparisAl.Location = new System.Drawing.Point(17, 349);
            this.btnSiparisAl.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiparisAl.Name = "btnSiparisAl";
            this.btnSiparisAl.Size = new System.Drawing.Size(166, 34);
            this.btnSiparisAl.TabIndex = 4;
            this.btnSiparisAl.Text = "Sipariş Al";
            this.btnSiparisAl.UseVisualStyleBackColor = true;
            this.btnSiparisAl.Click += new System.EventHandler(this.btnSiparisAl_Click);
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.Location = new System.Drawing.Point(205, 10);
            this.lstSiparisler.Margin = new System.Windows.Forms.Padding(2);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(554, 433);
            this.lstSiparisler.TabIndex = 5;
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiparisiTamamla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(591, 451);
            this.btnSiparisiTamamla.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(166, 39);
            this.btnSiparisiTamamla.TabIndex = 4;
            this.btnSiparisiTamamla.Text = "Siparişi Tamamla";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 462);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toplam Tutar:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(280, 462);
            this.lblToplamTutar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(22, 13);
            this.lblToplamTutar.TabIndex = 6;
            this.lblToplamTutar.Text = "0 ₺";
            // 
            // gbBoyut
            // 
            this.gbBoyut.Controls.Add(this.rbBuyuk);
            this.gbBoyut.Controls.Add(this.rbOrta);
            this.gbBoyut.Controls.Add(this.rbKucuk);
            this.gbBoyut.Location = new System.Drawing.Point(13, 73);
            this.gbBoyut.Margin = new System.Windows.Forms.Padding(2);
            this.gbBoyut.Name = "gbBoyut";
            this.gbBoyut.Padding = new System.Windows.Forms.Padding(2);
            this.gbBoyut.Size = new System.Drawing.Size(171, 52);
            this.gbBoyut.TabIndex = 7;
            this.gbBoyut.TabStop = false;
            this.gbBoyut.Text = "Boyut Seçiniz:";
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(100, 17);
            this.rbBuyuk.Margin = new System.Windows.Forms.Padding(2);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(55, 17);
            this.rbBuyuk.TabIndex = 0;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(54, 17);
            this.rbOrta.Margin = new System.Windows.Forms.Padding(2);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(45, 17);
            this.rbOrta.TabIndex = 0;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Checked = true;
            this.rbKucuk.Location = new System.Drawing.Point(4, 17);
            this.rbKucuk.Margin = new System.Windows.Forms.Padding(2);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(56, 17);
            this.rbKucuk.TabIndex = 0;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // SiparisSil
            // 
            this.SiparisSil.Location = new System.Drawing.Point(17, 397);
            this.SiparisSil.Margin = new System.Windows.Forms.Padding(2);
            this.SiparisSil.Name = "SiparisSil";
            this.SiparisSil.Size = new System.Drawing.Size(166, 34);
            this.SiparisSil.TabIndex = 8;
            this.SiparisSil.Text = "Sipariş Sil";
            this.SiparisSil.UseVisualStyleBackColor = true;
            this.SiparisSil.Click += new System.EventHandler(this.SiparisSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 514);
            this.Controls.Add(this.SiparisSil);
            this.Controls.Add(this.gbBoyut);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.btnSiparisAl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.gbEkstralar);
            this.Controls.Add(this.cbMenuler);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEkstralar.ResumeLayout(false);
            this.gbEkstralar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.gbBoyut.ResumeLayout(false);
            this.gbBoyut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMenuler;
        private System.Windows.Forms.GroupBox gbEkstralar;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSiparisAl;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.GroupBox gbBoyut;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.Button SiparisSil;
    }
}

