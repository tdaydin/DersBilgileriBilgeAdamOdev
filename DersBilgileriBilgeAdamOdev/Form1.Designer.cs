namespace DersBilgileriBilgeAdamOdev
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
            this.dgvDersListesi = new System.Windows.Forms.DataGridView();
            this.gbYeniDers = new System.Windows.Forms.GroupBox();
            this.bYeniDersKaydet = new System.Windows.Forms.Button();
            this.tbIcerik = new System.Windows.Forms.TextBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.nudKredi = new System.Windows.Forms.NumericUpDown();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bYeniDersEkle = new System.Windows.Forms.Button();
            this.rbHafiza = new System.Windows.Forms.RadioButton();
            this.rbDosya = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersListesi)).BeginInit();
            this.gbYeniDers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKredi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDersListesi
            // 
            this.dgvDersListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDersListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersListesi.Location = new System.Drawing.Point(87, 71);
            this.dgvDersListesi.Name = "dgvDersListesi";
            this.dgvDersListesi.RowHeadersWidth = 102;
            this.dgvDersListesi.RowTemplate.Height = 40;
            this.dgvDersListesi.Size = new System.Drawing.Size(1240, 516);
            this.dgvDersListesi.TabIndex = 0;
            // 
            // gbYeniDers
            // 
            this.gbYeniDers.Controls.Add(this.bYeniDersKaydet);
            this.gbYeniDers.Controls.Add(this.tbIcerik);
            this.gbYeniDers.Controls.Add(this.cbKategori);
            this.gbYeniDers.Controls.Add(this.nudKredi);
            this.gbYeniDers.Controls.Add(this.tbAdi);
            this.gbYeniDers.Controls.Add(this.label4);
            this.gbYeniDers.Controls.Add(this.label3);
            this.gbYeniDers.Controls.Add(this.label2);
            this.gbYeniDers.Controls.Add(this.label1);
            this.gbYeniDers.Location = new System.Drawing.Point(87, 678);
            this.gbYeniDers.Name = "gbYeniDers";
            this.gbYeniDers.Size = new System.Drawing.Size(1240, 379);
            this.gbYeniDers.TabIndex = 1;
            this.gbYeniDers.TabStop = false;
            this.gbYeniDers.Text = "Yeni Ders";
            this.gbYeniDers.Visible = false;
            // 
            // bYeniDersKaydet
            // 
            this.bYeniDersKaydet.Location = new System.Drawing.Point(19, 255);
            this.bYeniDersKaydet.Name = "bYeniDersKaydet";
            this.bYeniDersKaydet.Size = new System.Drawing.Size(455, 79);
            this.bYeniDersKaydet.TabIndex = 5;
            this.bYeniDersKaydet.Text = "Yeni Ders Kaydet";
            this.bYeniDersKaydet.UseVisualStyleBackColor = true;
            this.bYeniDersKaydet.Click += new System.EventHandler(this.bYeniDersKaydet_Click);
            // 
            // tbIcerik
            // 
            this.tbIcerik.Location = new System.Drawing.Point(729, 45);
            this.tbIcerik.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tbIcerik.Multiline = true;
            this.tbIcerik.Name = "tbIcerik";
            this.tbIcerik.Size = new System.Drawing.Size(442, 162);
            this.tbIcerik.TabIndex = 10;
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(209, 112);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(371, 39);
            this.cbKategori.TabIndex = 8;
            // 
            // nudKredi
            // 
            this.nudKredi.Location = new System.Drawing.Point(209, 175);
            this.nudKredi.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudKredi.Name = "nudKredi";
            this.nudKredi.Size = new System.Drawing.Size(371, 38);
            this.nudKredi.TabIndex = 7;
            this.nudKredi.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(209, 45);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(371, 38);
            this.tbAdi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kredisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Icerigi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategorisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adi";
            // 
            // bYeniDersEkle
            // 
            this.bYeniDersEkle.Location = new System.Drawing.Point(87, 611);
            this.bYeniDersEkle.Name = "bYeniDersEkle";
            this.bYeniDersEkle.Size = new System.Drawing.Size(385, 55);
            this.bYeniDersEkle.TabIndex = 2;
            this.bYeniDersEkle.Text = "Yeni Ders Ekle";
            this.bYeniDersEkle.UseVisualStyleBackColor = true;
            this.bYeniDersEkle.Click += new System.EventHandler(this.bYeniDersEkle_Click);
            // 
            // rbHafiza
            // 
            this.rbHafiza.AutoSize = true;
            this.rbHafiza.Checked = true;
            this.rbHafiza.Location = new System.Drawing.Point(570, 629);
            this.rbHafiza.Name = "rbHafiza";
            this.rbHafiza.Size = new System.Drawing.Size(133, 36);
            this.rbHafiza.TabIndex = 3;
            this.rbHafiza.TabStop = true;
            this.rbHafiza.Text = "Hafiza";
            this.rbHafiza.UseVisualStyleBackColor = true;
            this.rbHafiza.CheckedChanged += new System.EventHandler(this.rbHafiza_CheckedChanged);
            // 
            // rbDosya
            // 
            this.rbDosya.AutoSize = true;
            this.rbDosya.Location = new System.Drawing.Point(857, 629);
            this.rbDosya.Name = "rbDosya";
            this.rbDosya.Size = new System.Drawing.Size(132, 36);
            this.rbDosya.TabIndex = 4;
            this.rbDosya.Text = "Dosya";
            this.rbDosya.UseVisualStyleBackColor = true;
            this.rbDosya.CheckedChanged += new System.EventHandler(this.rbDosya_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1365, 1087);
            this.Controls.Add(this.rbDosya);
            this.Controls.Add(this.rbHafiza);
            this.Controls.Add(this.bYeniDersEkle);
            this.Controls.Add(this.gbYeniDers);
            this.Controls.Add(this.dgvDersListesi);
            this.Name = "Form1";
            this.Text = "Ders Listesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersListesi)).EndInit();
            this.gbYeniDers.ResumeLayout(false);
            this.gbYeniDers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKredi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDersListesi;
        private System.Windows.Forms.GroupBox gbYeniDers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudKredi;
        private System.Windows.Forms.TextBox tbAdi;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.TextBox tbIcerik;
        private System.Windows.Forms.Button bYeniDersEkle;
        private System.Windows.Forms.RadioButton rbHafiza;
        private System.Windows.Forms.RadioButton rbDosya;
        private System.Windows.Forms.Button bYeniDersKaydet;
    }
}

