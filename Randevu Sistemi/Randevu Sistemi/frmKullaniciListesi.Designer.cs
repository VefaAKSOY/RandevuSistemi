namespace Randevu_Sistemi
{
    partial class frmKullaniciListesi
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
            this.dgvKullaniciListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKullaniciListesi
            // 
            this.dgvKullaniciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullaniciListesi.Location = new System.Drawing.Point(12, 12);
            this.dgvKullaniciListesi.Name = "dgvKullaniciListesi";
            this.dgvKullaniciListesi.RowTemplate.Height = 24;
            this.dgvKullaniciListesi.Size = new System.Drawing.Size(776, 426);
            this.dgvKullaniciListesi.TabIndex = 0;
            // 
            // frmKullaniciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKullaniciListesi);
            this.Name = "frmKullaniciListesi";
            this.Text = "Kullanıcı Listesi";
            this.Load += new System.EventHandler(this.frmKullaniciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullaniciListesi;
    }
}