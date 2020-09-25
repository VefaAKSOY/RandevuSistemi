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
    public partial class frmIsyeriEkleme : Form
    {
        public frmIsyeriEkleme()
        {
            InitializeComponent();
        }
        GenelAdmin GenelAdmin = new GenelAdmin();
        VeritabaniBaglanti VeritabaniBaglanti = new VeritabaniBaglanti();
        private void btnIsyeriEkle_Click(object sender, EventArgs e)
        {
            VeritabaniBaglanti.IsyeriEkle(txtIsyeriAdi.Text, cmbIsyeriKategori.Text, txtIsyeriAdresi.Text,mtxtTelefonNo.Text, txtYetkiliAdi.Text);
            GenelAdmin.IsyeriEkle(txtIsyeriAdi.Text, cmbIsyeriKategori.Text, txtIsyeriAdresi.Text,mtxtTelefonNo.Text, txtYetkiliAdi.Text);
            
        }
    }
}
