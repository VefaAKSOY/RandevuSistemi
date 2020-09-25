using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randevu_Sistemi
{
    public partial class frmGenelAdminPaneli : Form
    {
        public frmGenelAdminPaneli()
        {
            InitializeComponent();
        }
        GenelAdmin GenelAdmin = new GenelAdmin();

        private void işyeriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyeriListesi frmIsyeriListesi = new frmIsyeriListesi();
            frmIsyeriListesi.MdiParent=this;
            frmIsyeriListesi.Show();
            
            
            
        }

        private void isyeriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyeriEkleme frmIsyeriEkleme = new frmIsyeriEkleme();
            frmIsyeriEkleme.MdiParent = this;
            frmIsyeriEkleme.Show();
        }

        private void isyeriSilmeAramaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIsyeriSilme_Arama frmIsyeriSilme_Arama = new frmIsyeriSilme_Arama();
            frmIsyeriSilme_Arama.MdiParent = this;
            frmIsyeriSilme_Arama.Show();

        }


        private void isyeriGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsyeriGuncelle frmIsyeriGuncelle = new frmIsyeriGuncelle();
            frmIsyeriGuncelle.MdiParent = this;
            frmIsyeriGuncelle.Show();
        }

        private void kullanıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciListesi frmKullaniciListesi = new frmKullaniciListesi();
            frmKullaniciListesi.MdiParent = this;
            frmKullaniciListesi.Show();
        }

        private void yetkiliListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYetkiliListesi frmYetkiliListesi = new frmYetkiliListesi();
            frmYetkiliListesi.MdiParent = this;
            frmYetkiliListesi.Show();

        }

        private void yetkiliTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYetkiliAtama yetkiliAtama = new frmYetkiliAtama();
            yetkiliAtama.MdiParent = this;
            yetkiliAtama.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
