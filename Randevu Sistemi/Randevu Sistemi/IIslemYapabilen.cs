using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu_Sistemi
{
    interface IIslemYapabilen
    {
        void IsyeriEkle(string Adi, string Kategori, string adresi, string telNo, string YetkiliAdi);
        void IsyeriSil(string IsyeriAdi);
        
    }
}
