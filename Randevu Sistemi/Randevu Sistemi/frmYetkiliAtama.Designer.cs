namespace Randevu_Sistemi
{
    partial class frmYetkiliAtama
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
            this.txtYetkiliId = new System.Windows.Forms.TextBox();
            this.txtIsyeriId = new System.Windows.Forms.TextBox();
            this.btnYetkiliyiAta = new System.Windows.Forms.Button();
            this.dgvIsyeriYetkiliListesi = new System.Windows.Forms.DataGridView();
            this.lblAtanacakYetkiliId = new System.Windows.Forms.Label();
            this.lblIsyeriAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriYetkiliListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYetkiliId
            // 
            this.txtYetkiliId.Location = new System.Drawing.Point(231, 104);
            this.txtYetkiliId.Name = "txtYetkiliId";
            this.txtYetkiliId.Size = new System.Drawing.Size(100, 22);
            this.txtYetkiliId.TabIndex = 0;
            // 
            // txtIsyeriId
            // 
            this.txtIsyeriId.Location = new System.Drawing.Point(374, 104);
            this.txtIsyeriId.Name = "txtIsyeriId";
            this.txtIsyeriId.Size = new System.Drawing.Size(100, 22);
            this.txtIsyeriId.TabIndex = 1;
            // 
            // btnYetkiliyiAta
            // 
            this.btnYetkiliyiAta.Location = new System.Drawing.Point(231, 147);
            this.btnYetkiliyiAta.Name = "btnYetkiliyiAta";
            this.btnYetkiliyiAta.Size = new System.Drawing.Size(243, 29);
            this.btnYetkiliyiAta.TabIndex = 2;
            this.btnYetkiliyiAta.Text = "Yetkiliyi Ata";
            this.btnYetkiliyiAta.UseVisualStyleBackColor = true;
            this.btnYetkiliyiAta.Click += new System.EventHandler(this.btnYetkiliyiAta_Click);
            // 
            // dgvIsyeriYetkiliListesi
            // 
            this.dgvIsyeriYetkiliListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsyeriYetkiliListesi.Location = new System.Drawing.Point(9, 198);
            this.dgvIsyeriYetkiliListesi.Name = "dgvIsyeriYetkiliListesi";
            this.dgvIsyeriYetkiliListesi.RowTemplate.Height = 24;
            this.dgvIsyeriYetkiliListesi.Size = new System.Drawing.Size(779, 240);
            this.dgvIsyeriYetkiliListesi.TabIndex = 3;
            // 
            // lblAtanacakYetkiliId
            // 
            this.lblAtanacakYetkiliId.AutoSize = true;
            this.lblAtanacakYetkiliId.Location = new System.Drawing.Point(231, 52);
            this.lblAtanacakYetkiliId.Name = "lblAtanacakYetkiliId";
            this.lblAtanacakYetkiliId.Size = new System.Drawing.Size(123, 17);
            this.lblAtanacakYetkiliId.TabIndex = 4;
            this.lblAtanacakYetkiliId.Text = "Atanacak Yetkili Id";
            // 
            // lblIsyeriAdi
            // 
            this.lblIsyeriAdi.AutoSize = true;
            this.lblIsyeriAdi.Location = new System.Drawing.Point(383, 52);
            this.lblIsyeriAdi.Name = "lblIsyeriAdi";
            this.lblIsyeriAdi.Size = new System.Drawing.Size(56, 17);
            this.lblIsyeriAdi.TabIndex = 5;
            this.lblIsyeriAdi.Text = "İşyeri Id";
            // 
            // frmYetkiliAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIsyeriAdi);
            this.Controls.Add(this.lblAtanacakYetkiliId);
            this.Controls.Add(this.dgvIsyeriYetkiliListesi);
            this.Controls.Add(this.btnYetkiliyiAta);
            this.Controls.Add(this.txtIsyeriId);
            this.Controls.Add(this.txtYetkiliId);
            this.Name = "frmYetkiliAtama";
            this.Text = "frmYetkiliAtama";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriYetkiliListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYetkiliId;
        private System.Windows.Forms.TextBox txtIsyeriId;
        private System.Windows.Forms.Button btnYetkiliyiAta;
        private System.Windows.Forms.DataGridView dgvIsyeriYetkiliListesi;
        private System.Windows.Forms.Label lblAtanacakYetkiliId;
        private System.Windows.Forms.Label lblIsyeriAdi;
    }
}