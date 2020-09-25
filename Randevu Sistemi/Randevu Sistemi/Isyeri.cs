using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu_Sistemi
{
    public class Isyeri
    {
        public string IsyeriKategori { get; set; }
        public string IsyeriAdi { get; set; }
        public IsyeriYetkilisi IsyeriYetkilisi { get; protected set; }
        public string IsyeriAdresi { get; set; }
        public string IsyeriTelefonNo { get; set; }
        public Isyeri()
        {
            IsyeriYetkilisi = new IsyeriYetkilisi();
           
        }
    }
}
