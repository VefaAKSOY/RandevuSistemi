namespace Randevu_Sistemi
{
    partial class frmGenelAdminPaneli
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.islemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işyeriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isyeriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isyeriSilmeAramaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.isyeriGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiliTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işyeriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiliListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.islemlerToolStripMenuItem,
            this.raporAlToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // islemlerToolStripMenuItem
            // 
            this.islemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işyeriİşlemleriToolStripMenuItem,
            this.yetkiliTanımlamaToolStripMenuItem});
            this.islemlerToolStripMenuItem.Name = "islemlerToolStripMenuItem";
            this.islemlerToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.islemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // işyeriİşlemleriToolStripMenuItem
            // 
            this.işyeriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.isyeriEklemeToolStripMenuItem,
            this.isyeriSilmeAramaToolStripMenuItem1,
            this.isyeriGüncellemeToolStripMenuItem});
            this.işyeriİşlemleriToolStripMenuItem.Name = "işyeriİşlemleriToolStripMenuItem";
            this.işyeriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.işyeriİşlemleriToolStripMenuItem.Text = "İşyeri İşlemleri";
            // 
            // isyeriEklemeToolStripMenuItem
            // 
            this.isyeriEklemeToolStripMenuItem.Name = "isyeriEklemeToolStripMenuItem";
            this.isyeriEklemeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.isyeriEklemeToolStripMenuItem.Text = "İşyeri Ekleme";
            this.isyeriEklemeToolStripMenuItem.Click += new System.EventHandler(this.isyeriEklemeToolStripMenuItem_Click);
            // 
            // isyeriSilmeAramaToolStripMenuItem1
            // 
            this.isyeriSilmeAramaToolStripMenuItem1.Name = "isyeriSilmeAramaToolStripMenuItem1";
            this.isyeriSilmeAramaToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.isyeriSilmeAramaToolStripMenuItem1.Text = "İşyeri Silme/Arama";
            this.isyeriSilmeAramaToolStripMenuItem1.Click += new System.EventHandler(this.isyeriSilmeAramaToolStripMenuItem1_Click);
            // 
            // isyeriGüncellemeToolStripMenuItem
            // 
            this.isyeriGüncellemeToolStripMenuItem.Name = "isyeriGüncellemeToolStripMenuItem";
            this.isyeriGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.isyeriGüncellemeToolStripMenuItem.Text = "İşyeri Güncelleme";
            this.isyeriGüncellemeToolStripMenuItem.Click += new System.EventHandler(this.isyeriGüncellemeToolStripMenuItem_Click);
            // 
            // yetkiliTanımlamaToolStripMenuItem
            // 
            this.yetkiliTanımlamaToolStripMenuItem.Name = "yetkiliTanımlamaToolStripMenuItem";
            this.yetkiliTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.yetkiliTanımlamaToolStripMenuItem.Text = "Yetkili Tanımlama";
            this.yetkiliTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.yetkiliTanımlamaToolStripMenuItem_Click);
            // 
            // raporAlToolStripMenuItem
            // 
            this.raporAlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işyeriListeleToolStripMenuItem,
            this.kullanıcıListeleToolStripMenuItem,
            this.yetkiliListeleToolStripMenuItem});
            this.raporAlToolStripMenuItem.Name = "raporAlToolStripMenuItem";
            this.raporAlToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.raporAlToolStripMenuItem.Text = "Rapor Al";
            // 
            // işyeriListeleToolStripMenuItem
            // 
            this.işyeriListeleToolStripMenuItem.Name = "işyeriListeleToolStripMenuItem";
            this.işyeriListeleToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.işyeriListeleToolStripMenuItem.Text = "İşyeri Listele";
            this.işyeriListeleToolStripMenuItem.Click += new System.EventHandler(this.işyeriListeleToolStripMenuItem_Click);
            // 
            // kullanıcıListeleToolStripMenuItem
            // 
            this.kullanıcıListeleToolStripMenuItem.Name = "kullanıcıListeleToolStripMenuItem";
            this.kullanıcıListeleToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.kullanıcıListeleToolStripMenuItem.Text = "Kullanıcı Listele ";
            this.kullanıcıListeleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıListeleToolStripMenuItem_Click);
            // 
            // yetkiliListeleToolStripMenuItem
            // 
            this.yetkiliListeleToolStripMenuItem.Name = "yetkiliListeleToolStripMenuItem";
            this.yetkiliListeleToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.yetkiliListeleToolStripMenuItem.Text = "Yetkili Listele";
            this.yetkiliListeleToolStripMenuItem.Click += new System.EventHandler(this.yetkiliListeleToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar ";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // frmGenelAdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 559);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmGenelAdminPaneli";
            this.Text = "Genel Admin Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem islemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işyeriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isyeriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isyeriSilmeAramaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem isyeriGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işyeriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiliListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiliTanımlamaToolStripMenuItem;
    }
}

