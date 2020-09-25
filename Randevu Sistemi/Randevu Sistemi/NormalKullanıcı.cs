using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu_Sistemi
{
    public class NormalKullanıcı:Kullanici
    {
        public DateTime SonGirisTarihi { get; private set; }
        public NormalKullanıcı()
        {
            SonGirisTarihi = DateTime.Now;     
        }
        public NormalKullanıcı(string EPosta, string AdiSoyadi, string Adres, string TelefonNo)
        {
            this.EPosta = EPosta;
            this.AdiSoyadi = AdiSoyadi;
            
            this.Adres = Adres;
            KullaniciTelefonNo = TelefonNo;
        }
    }
}
