﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randevu_Sistemi
{
    public partial class frmYetkiliAtama : Form
    {
        public frmYetkiliAtama()
        {
            InitializeComponent();
        }
        
        private void btnYetkiliyiAta_Click(object sender, EventArgs e)
        {
            VeritabaniBaglanti veritabaniBaglanti = new VeritabaniBaglanti();
            dgvIsyeriYetkiliListesi.DataSource = veritabaniBaglanti.YetkiliTanimla(Convert.ToInt32(txtYetkiliId.Text));


        }
    }
}
