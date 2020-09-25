namespace Randevu_Sistemi
{
    partial class frmIsyeriSilme_Arama
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
            this.btnIsyeriArama = new System.Windows.Forms.Button();
            this.btnIsyeriSil = new System.Windows.Forms.Button();
            this.txtSilinecekIsyeriAdi = new System.Windows.Forms.TextBox();
            this.lblSilinecekIsyeriAdi = new System.Windows.Forms.Label();
            this.dgvIsyeriListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIsyeriArama
            // 
            this.btnIsyeriArama.Location = new System.Drawing.Point(137, 116);
            this.btnIsyeriArama.Name = "btnIsyeriArama";
            this.btnIsyeriArama.Size = new System.Drawing.Size(319, 33);
            this.btnIsyeriArama.TabIndex = 0;
            this.btnIsyeriArama.Text = "İşyeri Ara";
            this.btnIsyeriArama.UseVisualStyleBackColor = true;
            this.btnIsyeriArama.Click += new System.EventHandler(this.btnIsyeriArama_Click);
            // 
            // btnIsyeriSil
            // 
            this.btnIsyeriSil.Location = new System.Drawing.Point(462, 116);
            this.btnIsyeriSil.Name = "btnIsyeriSil";
            this.btnIsyeriSil.Size = new System.Drawing.Size(326, 33);
            this.btnIsyeriSil.TabIndex = 1;
            this.btnIsyeriSil.Text = "İşyeri Sil";
            this.btnIsyeriSil.UseVisualStyleBackColor = true;
            this.btnIsyeriSil.Click += new System.EventHandler(this.btnIsyeriSil_Click);
            // 
            // txtSilinecekIsyeriAdi
            // 
            this.txtSilinecekIsyeriAdi.Location = new System.Drawing.Point(137, 88);
            this.txtSilinecekIsyeriAdi.Name = "txtSilinecekIsyeriAdi";
            this.txtSilinecekIsyeriAdi.Size = new System.Drawing.Size(651, 22);
            this.txtSilinecekIsyeriAdi.TabIndex = 2;
            // 
            // lblSilinecekIsyeriAdi
            // 
            this.lblSilinecekIsyeriAdi.AutoSize = true;
            this.lblSilinecekIsyeriAdi.Location = new System.Drawing.Point(66, 88);
            this.lblSilinecekIsyeriAdi.Name = "lblSilinecekIsyeriAdi";
            this.lblSilinecekIsyeriAdi.Size = new System.Drawing.Size(65, 17);
            this.lblSilinecekIsyeriAdi.TabIndex = 5;
            this.lblSilinecekIsyeriAdi.Text = "İşyeri Adı";
            // 
            // dgvIsyeriListesi
            // 
            this.dgvIsyeriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsyeriListesi.Location = new System.Drawing.Point(137, 172);
            this.dgvIsyeriListesi.Name = "dgvIsyeriListesi";
            this.dgvIsyeriListesi.RowTemplate.Height = 24;
            this.dgvIsyeriListesi.Size = new System.Drawing.Size(651, 224);
            this.dgvIsyeriListesi.TabIndex = 6;
            // 
            // frmIsyeriSilme_Arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvIsyeriListesi);
            this.Controls.Add(this.lblSilinecekIsyeriAdi);
            this.Controls.Add(this.txtSilinecekIsyeriAdi);
            this.Controls.Add(this.btnIsyeriSil);
            this.Controls.Add(this.btnIsyeriArama);
            this.Name = "frmIsyeriSilme_Arama";
            this.Text = "IsyeriSilme/Arama";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsyeriListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIsyeriArama;
        private System.Windows.Forms.Button btnIsyeriSil;
        private System.Windows.Forms.TextBox txtSilinecekIsyeriAdi;
        private System.Windows.Forms.Label lblSilinecekIsyeriAdi;
        private System.Windows.Forms.DataGridView dgvIsyeriListesi;
    }
}