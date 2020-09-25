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
    public partial class frmIsyeriGuncelle : Form
    {
        public frmIsyeriGuncelle()
        {
            InitializeComponent();
        }

        private void btnIsyeriGuncelle_Click(object sender, EventArgs e)
        {
            VeritabaniBaglanti veritabani =new VeritabaniBaglanti();
            veritabani.IsyeriGuncelle(txtIsyeriAdi.Text, cmbIsyeriKategori.Text, txtIsyeriAdresi.Text, mtxtTelefonNo.Text, txtYetkiliAdi.Text);
        }
    }
}
