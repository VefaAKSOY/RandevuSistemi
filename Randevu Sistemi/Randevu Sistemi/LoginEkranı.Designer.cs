namespace Randevu_Sistemi
{
    partial class frmLoginEkrani
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
            this.lblGenelAdminKullaniciAdi = new System.Windows.Forms.Label();
            this.lblGenelAdminSifre = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtGenelAdminKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtGenelAdminSifre = new System.Windows.Forms.TextBox();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGenelAdminKullaniciAdi
            // 
            this.lblGenelAdminKullaniciAdi.AutoSize = true;
            this.lblGenelAdminKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenelAdminKullaniciAdi.Location = new System.Drawing.Point(178, 97);
            this.lblGenelAdminKullaniciAdi.Name = "lblGenelAdminKullaniciAdi";
            this.lblGenelAdminKullaniciAdi.Size = new System.Drawing.Size(119, 25);
            this.lblGenelAdminKullaniciAdi.TabIndex = 0;
            this.lblGenelAdminKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblGenelAdminSifre
            // 
            this.lblGenelAdminSifre.AutoSize = true;
            this.lblGenelAdminSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenelAdminSifre.Location = new System.Drawing.Point(178, 154);
            this.lblGenelAdminSifre.Name = "lblGenelAdminSifre";
            this.lblGenelAdminSifre.Size = new System.Drawing.Size(52, 25);
            this.lblGenelAdminSifre.TabIndex = 1;
            this.lblGenelAdminSifre.Text = "Şifre";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(183, 251);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(187, 52);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtGenelAdminKullaniciAdi
            // 
            this.txtGenelAdminKullaniciAdi.Location = new System.Drawing.Point(357, 97);
            this.txtGenelAdminKullaniciAdi.Name = "txtGenelAdminKullaniciAdi";
            this.txtGenelAdminKullaniciAdi.Size = new System.Drawing.Size(187, 22);
            this.txtGenelAdminKullaniciAdi.TabIndex = 3;
            // 
            // txtGenelAdminSifre
            // 
            this.txtGenelAdminSifre.Location = new System.Drawing.Point(357, 156);
            this.txtGenelAdminSifre.Name = "txtGenelAdminSifre";
            this.txtGenelAdminSifre.Size = new System.Drawing.Size(187, 22);
            this.txtGenelAdminSifre.TabIndex = 4;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Location = new System.Drawing.Point(376, 251);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(168, 52);
            this.btnCikisYap.TabIndex = 5;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.UseVisualStyleBackColor = true;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // frmLoginEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.txtGenelAdminSifre);
            this.Controls.Add(this.txtGenelAdminKullaniciAdi);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.lblGenelAdminSifre);
            this.Controls.Add(this.lblGenelAdminKullaniciAdi);
            this.Name = "frmLoginEkrani";
            this.Text = "Login Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenelAdminKullaniciAdi;
        private System.Windows.Forms.Label lblGenelAdminSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtGenelAdminKullaniciAdi;
        private System.Windows.Forms.TextBox txtGenelAdminSifre;
        private System.Windows.Forms.Button btnCikisYap;
    }
}