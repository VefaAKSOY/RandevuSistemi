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
    public partial class frmKullaniciListesi : Form
    {
        public frmKullaniciListesi()
        {
            InitializeComponent();
        }

        private void frmKullaniciListesi_Load(object sender, EventArgs e)
        {
            VeritabaniBaglanti veritabaniBaglanti = new VeritabaniBaglanti();
            dgvKullaniciListesi.DataSource = veritabaniBaglanti.KullaniciListele();
            
        }
    }
}
