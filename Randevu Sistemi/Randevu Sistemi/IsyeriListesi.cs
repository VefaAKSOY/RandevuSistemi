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
    public partial class frmIsyeriListesi : Form
    {
        public frmIsyeriListesi()
        {
            InitializeComponent();
        }

        private void frmIsyeriListesi_Load(object sender, EventArgs e)
        {
            VeritabaniBaglanti veritabaniBaglanti = new VeritabaniBaglanti();
            dgvIsyeriListesi.DataSource = veritabaniBaglanti.IsyeriListeleme();
        }
    }
}
