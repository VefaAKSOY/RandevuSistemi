using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu_Sistemi
{
    public abstract class Kullanici
    {
        public string EPosta { get; protected set; }
        public string AdiSoyadi { get; set; }      
        public string Adres { get; protected set; }
        public string KullaniciTelefonNo { get; protected set; }


    }
}
