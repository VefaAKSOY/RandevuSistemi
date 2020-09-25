namespace Randevu_Sistemi
{
    partial class frmIsyeriGuncelle
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
            this.cmbIsyeriKategori = new System.Windows.Forms.ComboBox();
            this.mtxtTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.lblIsyeriTelefonNo = new System.Windows.Forms.Label();
            this.lblIsyeriAdresi = new System.Windows.Forms.Label();
            this.txtYetkiliAdi = new System.Windows.Forms.TextBox();
            this.lblIsyeriYetkili = new System.Windows.Forms.Label();
            this.txtIsyeriAdresi = new System.Windows.Forms.TextBox();
            this.lblIsyeriTuru = new System.Windows.Forms.Label();
            this.lblIsyeriAdi = new System.Windows.Forms.Label();
            this.txtIsyeriAdi = new System.Windows.Forms.TextBox();
            this.btnIsyeriGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbIsyeriKategori
            // 
            this.cmbIsyeriKategori.AllowDrop = true;
            this.cmbIsyeriKategori.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbIsyeriKategori.FormattingEnabled = true;
            this.cmbIsyeriKategori.Items.AddRange(new object[] {
            "Dişçi",
            "Psikolog",
            "Kuaför"});
            this.cmbIsyeriKategori.Location = new System.Drawing.Point(321, 109);
            this.cmbIsyeriKategori.Name = "cmbIsyeriKategori";
            this.cmbIsyeriKategori.Size = new System.Drawing.Size(164, 24);
            this.cmbIsyeriKategori.TabIndex = 23;
            // 
            // mtxtTelefonNo
            // 
            this.mtxtTelefonNo.Location = new System.Drawing.Point(321, 207);
            this.mtxtTelefonNo.Mask = "(999) 000-0000";
            this.mtxtTelefonNo.Name = "mtxtTelefonNo";
            this.mtxtTelefonNo.Size = new System.Drawing.Size(164, 22);
            this.mtxtTelefonNo.TabIndex = 22;
            // 
            // lblIsyeriTelefonNo
            // 
            this.lblIsyeriTelefonNo.AutoSize = true;
            this.lblIsyeriTelefonNo.Location = new System.Drawing.Point(227, 207);
            this.lblIsyeriTelefonNo.Name = "lblIsyeriTelefonNo";
            this.lblIsyeriTelefonNo.Size = new System.Drawing.Size(78, 17);
            this.lblIsyeriTelefonNo.TabIndex = 21;
            this.lblIsyeriTelefonNo.Text = "Telefon No";
            // 
            // lblIsyeriAdresi
            // 
            this.lblIsyeriAdresi.AutoSize = true;
            this.lblIsyeriAdresi.BackColor = System.Drawing.SystemColors.Control;
            this.lblIsyeriAdresi.Location = new System.Drawing.Point(227, 242);
            this.lblIsyeriAdresi.Name = "lblIsyeriAdresi";
            this.lblIsyeriAdresi.Size = new System.Drawing.Size(85, 17);
            this.lblIsyeriAdresi.TabIndex = 20;
            this.lblIsyeriAdresi.Text = "İşyeri Adresi";
            // 
            // txtYetkiliAdi
            // 
            this.txtYetkiliAdi.Location = new System.Drawing.Point(321, 160);
            this.txtYetkiliAdi.Name = "txtYetkiliAdi";
            this.txtYetkiliAdi.Size = new System.Drawing.Size(164, 22);
            this.txtYetkiliAdi.TabIndex = 19;
            // 
            // lblIsyeriYetkili
            // 
            this.lblIsyeriYetkili.AutoSize = true;
            this.lblIsyeriYetkili.Location = new System.Drawing.Point(227, 160);
            this.lblIsyeriYetkili.Name = "lblIsyeriYetkili";
            this.lblIsyeriYetkili.Size = new System.Drawing.Size(69, 17);
            this.lblIsyeriYetkili.TabIndex = 18;
            this.lblIsyeriYetkili.Text = "Yetkili Adı";
            // 
            // txtIsyeriAdresi
            // 
            this.txtIsyeriAdresi.Location = new System.Drawing.Point(321, 242);
            this.txtIsyeriAdresi.Multiline = true;
            this.txtIsyeriAdresi.Name = "txtIsyeriAdresi";
            this.txtIsyeriAdresi.Size = new System.Drawing.Size(164, 60);
            this.txtIsyeriAdresi.TabIndex = 17;
            // 
            // lblIsyeriTuru
            // 
            this.lblIsyeriTuru.AutoSize = true;
            this.lblIsyeriTuru.Location = new System.Drawing.Point(227, 112);
            this.lblIsyeriTuru.Name = "lblIsyeriTuru";
            this.lblIsyeriTuru.Size = new System.Drawing.Size(75, 17);
            this.lblIsyeriTuru.TabIndex = 16;
            this.lblIsyeriTuru.Text = "İşyeri Türü";
            // 
            // lblIsyeriAdi
            // 
            this.lblIsyeriAdi.AutoSize = true;
            this.lblIsyeriAdi.Location = new System.Drawing.Point(227, 70);
            this.lblIsyeriAdi.Name = "lblIsyeriAdi";
            this.lblIsyeriAdi.Size = new System.Drawing.Size(69, 17);
            this.lblIsyeriAdi.TabIndex = 15;
            this.lblIsyeriAdi.Text = "İşyeri İsmi";
            // 
            // txtIsyeriAdi
            // 
            this.txtIsyeriAdi.Location = new System.Drawing.Point(321, 65);
            this.txtIsyeriAdi.Name = "txtIsyeriAdi";
            this.txtIsyeriAdi.Size = new System.Drawing.Size(164, 22);
            this.txtIsyeriAdi.TabIndex = 14;
            // 
            // btnIsyeriGuncelle
            // 
            this.btnIsyeriGuncelle.Location = new System.Drawing.Point(321, 327);
            this.btnIsyeriGuncelle.Name = "btnIsyeriGuncelle";
            this.btnIsyeriGuncelle.Size = new System.Drawing.Size(164, 27);
            this.btnIsyeriGuncelle.TabIndex = 13;
            this.btnIsyeriGuncelle.Text = "İşyeri Güncelle";
            this.btnIsyeriGuncelle.UseVisualStyleBackColor = true;
            this.btnIsyeriGuncelle.Click += new System.EventHandler(this.btnIsyeriGuncelle_Click);
            // 
            // frmIsyeriGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbIsyeriKategori);
            this.Controls.Add(this.mtxtTelefonNo);
            this.Controls.Add(this.lblIsyeriTelefonNo);
            this.Controls.Add(this.lblIsyeriAdresi);
            this.Controls.Add(this.txtYetkiliAdi);
            this.Controls.Add(this.lblIsyeriYetkili);
            this.Controls.Add(this.txtIsyeriAdresi);
            this.Controls.Add(this.lblIsyeriTuru);
            this.Controls.Add(this.lblIsyeriAdi);
            this.Controls.Add(this.txtIsyeriAdi);
            this.Controls.Add(this.btnIsyeriGuncelle);
            this.Name = "frmIsyeriGuncelle";
            this.Text = "İşyeri Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIsyeriKategori;
        private System.Windows.Forms.MaskedTextBox mtxtTelefonNo;
        private System.Windows.Forms.Label lblIsyeriTelefonNo;
        private System.Windows.Forms.Label lblIsyeriAdresi;
        private System.Windows.Forms.TextBox txtYetkiliAdi;
        private System.Windows.Forms.Label lblIsyeriYetkili;
        private System.Windows.Forms.TextBox txtIsyeriAdresi;
        private System.Windows.Forms.Label lblIsyeriTuru;
        private System.Windows.Forms.Label lblIsyeriAdi;
        private System.Windows.Forms.TextBox txtIsyeriAdi;
        private System.Windows.Forms.Button btnIsyeriGuncelle;
    }
}