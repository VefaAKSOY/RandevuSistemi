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
    public partial class frmIsyeriSilme_Arama : Form
    {
        public frmIsyeriSilme_Arama()
        {
            InitializeComponent();
        }
        VeritabaniBaglanti VeritabaniBaglanti = new VeritabaniBaglanti();
        private void btnIsyeriSil_Click(object sender, EventArgs e)
        {
            VeritabaniBaglanti.IsyeriSil(txtSilinecekIsyeriAdi.Text);
            dgvIsyeriListesi.DataSource = VeritabaniBaglanti.IsyeriListeleme();

        }

        private void btnIsyeriArama_Click(object sender, EventArgs e)
        {
            
            dgvIsyeriListesi.DataSource = VeritabaniBaglanti.IsyeriArama(txtSilinecekIsyeriAdi.Text);
        }
    }
}
