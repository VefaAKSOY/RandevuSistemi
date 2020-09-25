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
    public partial class frmYetkiliListesi : Form
    {
        public frmYetkiliListesi()
        {
            InitializeComponent();
        }

        private void frmYetkiliListesi_Load(object sender, EventArgs e)
        {
            VeritabaniBaglanti veritabani = new VeritabaniBaglanti();
            dgvYetkiliListesi.DataSource = veritabani.YetkiliListele();

        }
    }
}
