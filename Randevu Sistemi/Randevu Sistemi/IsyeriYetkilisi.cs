using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu_Sistemi
{
    public class IsyeriYetkilisi:Kullanici
    {
        public DateTime YetkiliDogumTarihi { get; private set; }
        public int YetkiliTC { get; set; }
        public IsyeriYetkilisi()
        {

        }
        public IsyeriYetkilisi(DateTime YetkiliDogumTarihi)
        {
            YetkiliDogumTarihi = new DateTime();
            YetkiliDogumTarihi= YetkiliDogumTarihi.Date;
        }
    }
}
